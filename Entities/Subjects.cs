namespace DatabankApi.Entities;

/// <summary>
/// This Entities is for adding a subject
/// </summary>
public class Subjects
{
    public int SubjectId { get; init; }
    public required string SubjectCode { get; init; }
    public required string SubjectTitle { get; init; }
    public required string Department { get; init; }
}