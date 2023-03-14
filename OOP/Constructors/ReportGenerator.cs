namespace Constructors;

public class ReportGenerator
{
    public string? ReportFormat { get; set; } = string.Empty;
    public string? SavedPath { get; set; } = string.Empty;
    public string? ReadingDataPath { get; set; } = string.Empty;

/*     public ReportGenerator()
    {
        ReportFormat = "PDF";
    }

    public ReportGenerator(string reportFormat)
    {
        ReportFormat = reportFormat;
    } */

    public ReportGenerator(string readingPath)
    {
        ReadingDataPath = readingPath;
    }
}