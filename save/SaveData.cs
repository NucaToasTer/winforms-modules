namespace boilerplate;

/// <summary>
/// The data that gets persisted to disk.
/// Add more fields here as your app grows.
/// </summary>
public class SaveData
{
    public List<string> SavedTexts { get; set; } = new();
    public List<string> SavedTexts2 { get; set; } = new();
    public DateTime LastWrite { get; set; } = DateTime.MinValue;
}
