namespace sbytes.server.Domain.CommandHandlers;

using MediatR;
using sbytes.infrastructure.Repositories.Ticket.Repository;
using sbytes.server.Domain.Commands;
using sbytes.shared;
using sbytes.shared.Entities;

public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, CreateTicketResponse>
{
    private readonly ITicketRepository _ticketRepository;

    public CreateTicketCommandHandler(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<CreateTicketResponse> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
    {
        TicketEntity ticketEntity = new TicketEntity()
        {
            Id = Guid.NewGuid().ToString(),
            Credentials = { }
        };

        await _ticketRepository.AddTicketAsync(ticketEntity);
        
        return new CreateTicketResponse()
        {
            Ticket = new TicketEntityProto()
            {
                Id = ticketEntity.Id,
                Credentials =
                {
                    ticketEntity.Credentials
                }
            }
        };
    }
}