namespace Common.Startup;

using System.Text.Json;

internal class BootstrapperState
{
    public uint NativeBuildDate { get; set; }
    public uint InstalledVersion { get; set; }
    public bool SkipVerification { get; set; }
    public Dictionary<string, long> InstalledFiles { get; set; }
    public static BootstrapperState LoadFromFile(string file) {
        var result = JsonSerializer.Deserialize<BootstrapperState>(File.ReadAllText(file));
        if (result == null) {
            throw new Exception("Deserialization of bootstrapper state file failed");
        }
        return result;
    }
    public void SaveToFile(string file) {
        File.WriteAllText(file, JsonSerializer.Serialize(this, new JsonSerializerOptions {
            WriteIndented = true
        }));
    }
    public BootstrapperState() {
        InstalledVersion = 0;
        InstalledFiles = new Dictionary<string, long>();
        SkipVerification = false;
        NativeBuildDate = 0;
    }

}