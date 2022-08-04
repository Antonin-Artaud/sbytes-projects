namespace sbytes_infrastructure.Services;

using StackExchange.Redis;

public class RedisService
{
    private readonly ConnectionMultiplexer _connection;

    public RedisService()
    {
        _connection = ConnectionMultiplexer.Connect("localhost");
    }

    public IDatabase GetDatabase() => _connection.GetDatabase();
}
