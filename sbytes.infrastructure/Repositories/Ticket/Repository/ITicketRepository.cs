namespace sbytes_infrastructure.Repositories.Ticket.Repository;

using sbytes_shared.Entities;

public interface ITicketRepository
{
    Task<bool> CreateTicketAsync(TicketEntity ticket);
    Task<TicketEntity?> GetTicketByIdAsync(string id);
    Task<bool> UpdateTicketAsync(TicketEntity ticket);
    
    //Only for testing purposes
    Task<bool> DeleteTicketAsync(string id);
}