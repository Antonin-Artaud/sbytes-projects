namespace sbytes_shared.Entities;

using System.Text.Json;
using Google.Protobuf.Collections;
using sbytes_shared.Entities.Commons;
using StackExchange.Redis;

public struct TicketEntity : IEntity
{
    public string Id { get; set; }
    public MapField<string, string> Credentials { get; set; }
    public RedisValue ToJson() => JsonSerializer.Serialize(this);
    public static TicketEntity FromJson(RedisValue json) => JsonSerializer.Deserialize<TicketEntity>(json!);
}