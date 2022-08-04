namespace sbytes.server;

using System.Reflection;
using MediatR;
using sbytes.infrastructure.Repositories.Ticket;
using sbytes.infrastructure.Repositories.Ticket.Repository;
using sbytes.infrastructure.Services;
using sbytes.server.GrpcServices;
using sbytes.shared.Helpers.Rpc.Server;

internal static class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddGrpc();
        builder.Services.AddSingleton<MessageOrchestrator>();
        builder.Services.AddSingleton<RedisService>();
        builder.Services.AddSingleton<ITicketRepository, TicketRepository>();
        builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
        WebApplication app = builder.Build();
        
        app.MapGrpcService<CommandService>();
        app.MapGet("/", handler: delegate()
        {
            return "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909";
        });

        app.Run();
    }
}