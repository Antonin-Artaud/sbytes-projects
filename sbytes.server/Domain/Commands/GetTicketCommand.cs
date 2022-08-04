namespace sbytes.server.Domain.Commands;

using MediatR;
using sbytes.shared;
using sbytes.shared.Entities;

public struct GetTicketCommand : IRequest, IRequest<GetTicketResponse>
{
    public TicketEntity TicketEntity { get; set; }
}