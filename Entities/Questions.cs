namespace DatabankApi.Entities;

public class Questions
{
    public int QuestionId { get; init; }
    public required User UserId { get; init; }
    public required string Question { get; init; }

    public required string Image { get; init; }
}