namespace DatabankApi.Contracts.Request.TopicRequest;


public class RegisterTopicRequest
{
    public Guid TopicId { get; init; }
    public required string Department { get; init; }
    public required string TopicCode { get; init; }
    public required string TopicDescription { get; init; }
    public int HoursPerTopic { get; init; }
    public int TopicValue1 { get; init; }
    public int TopicValue2 { get; init; }
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime UpdatedAt { get; init; }
    public DateTime CreatedAt { get; init; }
}