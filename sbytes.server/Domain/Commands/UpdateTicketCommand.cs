namespace sbytes.server.Domain.Commands;

using MediatR;
using sbytes.shared;
using sbytes.shared.Entities;

public struct UpdateTicketCommand : IRequest, IRequest<UpdateTicketResponse>
{
    public TicketEntity TicketEntity { get; set; }
}