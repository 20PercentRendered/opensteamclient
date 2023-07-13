using Common.Utils;
using System.IO.Compression;

namespace Common.Extensions;

public static class ZipArchiveExtensions
{
    public static async Task ExtractToDirectory(this ZipArchive source, string destinationDirectoryName, IExtendedProgress<int> prog, Action<ZipArchiveEntry, string>? afterExtractHook = null) {
        foreach (ZipArchiveEntry entry in source.Entries)
        {
            var FullNameFixed = entry.FullName;

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

            using (Stream zipstream = entry.Open()) {
                using (var file = new FileStream(FullPath, FileMode.Create, FileAccess.Write, FileShare.None)) {
                    prog.SetSubOperation($"Extracting {FullNameFixed}");
                    // Convert absolute progress (bytes unzipped) into relative progress (0% - 100%)
                    var relativeProgress = new Progress<long>(totalBytes => prog.Report((int)(((float)totalBytes / entry.Length)*100)));
                    
                    // Use extension method to report progress while downloading
                    await zipstream.CopyToAsync(file, 81920, relativeProgress, default);
                    afterExtractHook?.Invoke(entry, FullNameFixed);
                }
            }
        }   
    }
}