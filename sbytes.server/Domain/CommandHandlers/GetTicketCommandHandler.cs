namespace sbytes.server.Domain.CommandHandlers;

using MediatR;
using sbytes.infrastructure.Repositories.Ticket.Repository;
using sbytes.server.Domain.Commands;

public class GetTicketCommandHandler : IRequestHandler<GetTicketCommand, Unit>
{
    private readonly ITicketRepository _ticketRepository;
    
    public GetTicketCommandHandler(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }
    
    public Task<Unit> Handle(GetTicketCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}