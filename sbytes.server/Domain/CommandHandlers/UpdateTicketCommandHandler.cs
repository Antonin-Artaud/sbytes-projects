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

    public Task<Unit> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}