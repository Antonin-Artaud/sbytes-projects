namespace sbytes.server.Domain.CommandHandlers;

using MediatR;
using sbytes.infrastructure.Repositories.Ticket.Repository;
using sbytes.server.Domain.Commands;
using sbytes.shared;
using sbytes.shared.Entities;

public class GetTicketCommandHandler : IRequestHandler<GetTicketCommand, GetTicketResponse>
{
    private readonly ITicketRepository _ticketRepository;
    
    public GetTicketCommandHandler(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }
    
    public async Task<GetTicketResponse> Handle(GetTicketCommand request, CancellationToken cancellationToken)
    {
        if (Guid.TryParse(request.Id, out Guid _))
        {
            return new GetTicketResponse();
        }
        
        TicketEntity? ticketEntity = await _ticketRepository.GetTicketByIdAsync(request.Id);
        
        if (ticketEntity is null)
        {
            return new GetTicketResponse();
        }
        
        return new GetTicketResponse()
        {
            Ticket = new TicketEntityProto()
            {
                Id = ticketEntity.Value.Id,
                Credentials = { ticketEntity.Value.Credentials }
            }
        };
    }
}