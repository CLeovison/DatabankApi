namespace DatabankApi.Contracts.Request.QuestionRequest;


public class RegisterQuestionRequest
{
    public int QuestionId { get; init; }
    public required string Question { get; init; }
    public required string AnswerA { get; init; }
    public required string AnswerB { get; init; }
    public required string AnswerC { get; init; }
    public required string AnswerD { get; init; }
    public required string AnswerKey { get; init; }
}