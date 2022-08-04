namespace sbytes.server.Domain.Commands;

using MediatR;
using sbytes.shared;

public struct GetTicketCommand : IRequest, IRequest<GetTicketResponse>
{
    public string Id { get; set; }
}