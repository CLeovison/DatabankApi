namespace DatabankApi.Domain.Entities;


public class ExamGenerated
{
    public int ExamGeneratedId { get; init; }
    public int SubjectId { get; init; }
    public required Subjects Subjecs { get; init; }
    public required string ExamPeriod { get; init; }
    public required string Semester { get; init; }
    public int SchoolYear { get; init; }
}