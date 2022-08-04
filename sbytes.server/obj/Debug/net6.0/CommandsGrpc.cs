// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: commands.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace sbytes.shared {
  public static partial class CommandsGrpc
  {
    static readonly string __ServiceName = "commands.CommandsGrpc";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sbytes.shared.CreateTicketRequest> __Marshaller_commands_CreateTicketRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sbytes.shared.CreateTicketRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sbytes.shared.CreateTicketResponse> __Marshaller_commands_CreateTicketResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sbytes.shared.CreateTicketResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sbytes.shared.GetTicketRequest> __Marshaller_commands_GetTicketRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sbytes.shared.GetTicketRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sbytes.shared.GetTicketResponse> __Marshaller_commands_GetTicketResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sbytes.shared.GetTicketResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sbytes.shared.UpdateTicketRequest> __Marshaller_commands_UpdateTicketRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sbytes.shared.UpdateTicketRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sbytes.shared.UpdateTicketResponse> __Marshaller_commands_UpdateTicketResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sbytes.shared.UpdateTicketResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::sbytes.shared.CreateTicketRequest, global::sbytes.shared.CreateTicketResponse> __Method_CreateTicket = new grpc::Method<global::sbytes.shared.CreateTicketRequest, global::sbytes.shared.CreateTicketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateTicket",
        __Marshaller_commands_CreateTicketRequest,
        __Marshaller_commands_CreateTicketResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::sbytes.shared.GetTicketRequest, global::sbytes.shared.GetTicketResponse> __Method_ReadTicket = new grpc::Method<global::sbytes.shared.GetTicketRequest, global::sbytes.shared.GetTicketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadTicket",
        __Marshaller_commands_GetTicketRequest,
        __Marshaller_commands_GetTicketResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::sbytes.shared.UpdateTicketRequest, global::sbytes.shared.UpdateTicketResponse> __Method_UpdateTicket = new grpc::Method<global::sbytes.shared.UpdateTicketRequest, global::sbytes.shared.UpdateTicketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateTicket",
        __Marshaller_commands_UpdateTicketRequest,
        __Marshaller_commands_UpdateTicketResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::sbytes.shared.CommandsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CommandsGrpc</summary>
    [grpc::BindServiceMethod(typeof(CommandsGrpc), "BindService")]
    public abstract partial class CommandsGrpcBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::sbytes.shared.CreateTicketResponse> CreateTicket(global::sbytes.shared.CreateTicketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::sbytes.shared.GetTicketResponse> ReadTicket(global::sbytes.shared.GetTicketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::sbytes.shared.UpdateTicketResponse> UpdateTicket(global::sbytes.shared.UpdateTicketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CommandsGrpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateTicket, serviceImpl.CreateTicket)
          .AddMethod(__Method_ReadTicket, serviceImpl.ReadTicket)
          .AddMethod(__Method_UpdateTicket, serviceImpl.UpdateTicket).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CommandsGrpcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateTicket, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::sbytes.shared.CreateTicketRequest, global::sbytes.shared.CreateTicketResponse>(serviceImpl.CreateTicket));
      serviceBinder.AddMethod(__Method_ReadTicket, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::sbytes.shared.GetTicketRequest, global::sbytes.shared.GetTicketResponse>(serviceImpl.ReadTicket));
      serviceBinder.AddMethod(__Method_UpdateTicket, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::sbytes.shared.UpdateTicketRequest, global::sbytes.shared.UpdateTicketResponse>(serviceImpl.UpdateTicket));
    }

  }
}
#endregion
