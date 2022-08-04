namespace sbytes.server.Domain.CommandHandlers;

using MediatR;
using sbytes.infrastructure.Repositories.Ticket.Repository;
using sbytes.server.Domain.Commands;

public class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand, Unit>
{
    private readonly ITicketRepository _ticketRepository;

    public UpdateTicketCommandHandler(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<Unit> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
    {
        if (Guid.TryParse(request.TicketEntity.Id, out Guid id))
        {
            await _ticketRepository.UpdateTicketAsync(request.TicketEntity);
            return Unit.Value;
        }
        
        throw new Exception("Invalid ticket id");
    }
}