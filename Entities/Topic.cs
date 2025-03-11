namespace DatabankApi.Entities;


public class Topic
{
    public int TopicId { get; init; }
    public required User UserId { get; init; }
    public required Questions QuestionId { get; init; }
    public required string TopicCode { get; init; }
    public int FirstValue { get; init; }
    public int SecondValue { get; init; }
    public required string Description { get; init; }
    public int HoursPerTopic { get; init; }
}