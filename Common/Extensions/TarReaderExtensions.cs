using Common.Utils;
using System.Formats.Tar;
using System.IO.Compression;

namespace Common.Extensions;

public static class TarReaderExtensions
{
    public static async Task ExtractToDirectory(this TarReader source, string destinationDirectoryName, IExtendedProgress<int> prog, Action<TarEntry>? afterExtractHook = null) {
        TarEntry? entry = source.GetNextEntry();
        do
        {
            if (entry == null) {
                continue;
            }
            var destinationFileName = Path.Combine(destinationDirectoryName, entry.Name);

            if (entry.EntryType.HasFlag(TarEntryType.V7RegularFile) || entry.EntryType.HasFlag(TarEntryType.RegularFile) || entry.EntryType.HasFlag(TarEntryType.ContiguousFile)) {
                entry.ExtractToFile(destinationFileName, false);
            }

            var FullNameFixed = entry.Name;

            // Fixup slashes for Non-Windows platforms
            if (!OperatingSystem.IsWindows()) {
                FullNameFixed = FullNameFixed.Replace('\\', '/');
            }

            var FullPath = Path.Combine(destinationDirectoryName, FullNameFixed);

            if (entry.Length == 0 && (FullNameFixed.EndsWith('/') || FullNameFixed.EndsWith('\\'))) {
                Directory.CreateDirectory(FullPath);
                continue;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(FullPath)!);

            if (entry.DataStream == null) {
                throw new Exception("No DataStream");
            }
            
            using (var file = new FileStream(FullPath, FileMode.Create, FileAccess.Write, FileShare.None)) {
                prog.SetSubOperation($"Extracting {FullNameFixed}");
                // Convert absolute progress (bytes unzipped) into relative progress (0% - 100%)
                var relativeProgress = new Progress<long>(totalBytes => prog.Report((int)(((float)totalBytes / entry.Length)*100)));

                // Use extension method to report progress while downloading
                await entry.DataStream.CopyToAsync(file, 81920, relativeProgress, default);
                afterExtractHook?.Invoke(entry);
            } 
        } while (entry != null);
    }
}