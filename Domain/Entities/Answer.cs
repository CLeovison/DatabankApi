namespace DatabankApi.Domain.Entities;


public class Answer
{
    
    public int AnswerId { get; init; }
    public required string AnswerA { get; init; }
    public required string AnswerB { get; init; }
    public required string AnswerC { get; init; }
    public required string AnswerD { get; init; }
    public required string AnswerKey { get; init; }
}