namespace DatabankApi.Entities;


public class Topic
{
    public int TopicId { get; init; }
    public Guid UserId { get; init; }
    public int QuestionId { get; init; }
    public int SubjectsId { get; init; }
    public required User User { get; init; }
    public required Questions Questions { get; init; }
    public required Subjects Subjects { get; init; }
    public required string TopicCode { get; init; }
    public int FirstValue { get; init; }
    public int SecondValue { get; init; }
    public required string Description { get; init; }
    public int HoursPerTopic { get; init; }
}