namespace sbytes_infrastructure.Repositories.Ticket;

using sbytes_infrastructure.Repositories.Ticket.Repository;
using sbytes_infrastructure.Services;
using sbytes_shared.Entities;
using StackExchange.Redis;

public class TicketRepository : ITicketRepository
{
    private readonly RedisService _redisService;

    public TicketRepository(RedisService redisService)
    {
        _redisService = redisService;
    }

    public async Task<bool> CreateTicketAsync(TicketEntity ticket)
    {
        return await _redisService.GetDatabase().StringSetAsync(ticket.Id, ticket.ToJson(), TimeSpan.FromMinutes(3));
    }

    public async Task<TicketEntity?> GetTicketByIdAsync(string id)
    {
        if (!Guid.TryParse(id, out Guid _))
        {
            return null;
        }
        
        RedisValue value = await _redisService.GetDatabase().StringGetAsync(id);

        return value.HasValue ? TicketEntity.FromJson(value) : null;
    }

    public async Task<bool> UpdateTicketAsync(TicketEntity ticket)
    {
        if (!Guid.TryParse(ticket.Id, out Guid _))
        {
            return await Task.FromResult(false);
        }

        return await _redisService.GetDatabase().StringSetAsync(ticket.Id, ticket.ToJson(), when: When.Exists);
    }

    // Only for testing purposes
    public async Task<bool> DeleteTicketAsync(string id)
    {
        if (!Guid.TryParse(id, out Guid _))
        {
            return await Task.FromResult(false);
        }
        
        return await _redisService.GetDatabase().KeyDeleteAsync(id);
    }
}