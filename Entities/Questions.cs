namespace DatabankApi.Entities;

public class Questions
{
    public int QuestionId { get; init; }
    public int UserId { get; init; }
    public int SubjectId { get; init; }
    public required User User { get; init; }
    public required Subjects Subjects { get; init; }
    public required string Question { get; init; }
    public required string Image { get; init; }
}