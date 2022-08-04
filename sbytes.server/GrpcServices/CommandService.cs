namespace sbytes.server.GrpcServices;

using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;
using sbytes.server.Domain.Commands;
using sbytes.shared;
using sbytes.shared.Helpers.Rpc.Server;

public class CommandService : CommandsGrpc.CommandsGrpcBase
{
    private readonly MessageOrchestrator _messageOrchestrator;
    private readonly ILogger<CommandService> _logger;

    public CommandService(MessageOrchestrator messageOrchestrator, ILogger<CommandService> logger)
    {
        _messageOrchestrator = messageOrchestrator;
        _logger = logger;
    }

    public override async Task<CreateTicketResponse> CreateTicket(CreateTicketRequest request, ServerCallContext context)
    {
        return await _messageOrchestrator.Process<CreateTicketCommand, CreateTicketResponse>(request, context);
    }

    public override async Task<GetTicketResponse> ReadTicket(GetTicketRequest request, ServerCallContext context)
    {
        return await _messageOrchestrator.Process<GetTicketCommand, GetTicketResponse>(request, context);
    }

    public override async Task<UpdateTicketResponse> UpdateTicket(UpdateTicketRequest request, ServerCallContext context)
    {
        return await _messageOrchestrator.Process<UpdateTicketCommand, UpdateTicketResponse>(request, context);
    }
}