namespace DatabankApi.Entities;


public class Subjects
{
    public int SubjectId { get; init; }
    public required string SubjectCode { get; init; }
    public required string SubjectTitle { get; init; }
}