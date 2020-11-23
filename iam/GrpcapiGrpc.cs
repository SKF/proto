// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: iam/grpcapi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SKF.Enlight.API.IAM {
  public static partial class IAM
  {
    static readonly string __ServiceName = "grpcapi.IAM";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.Void> __Marshaller_common_Void = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.Common.Void.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.PrimitiveString> __Marshaller_common_PrimitiveString = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.Common.PrimitiveString.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.CheckAuthenticationInput> __Marshaller_grpcapi_CheckAuthenticationInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.CheckAuthenticationInput.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.UserClaims> __Marshaller_grpcapi_UserClaims = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.UserClaims.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput> __Marshaller_grpcapi_CheckAuthenticationByEndpointInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput> __Marshaller_grpcapi_GetHierarchyRelationsInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput> __Marshaller_grpcapi_GetHierarchyRelationsOutput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.GetEventRecordsInput> __Marshaller_grpcapi_GetEventRecordsInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.GetEventRecordsInput.Parser));
    static readonly grpc::Marshaller<global::SKF.Enlight.API.IAM.GetEventRecordsOutput> __Marshaller_grpcapi_GetEventRecordsOutput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SKF.Enlight.API.IAM.GetEventRecordsOutput.Parser));

    static readonly grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Common.PrimitiveString> __Method_DeepPing = new grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Common.PrimitiveString>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeepPing",
        __Marshaller_common_Void,
        __Marshaller_common_PrimitiveString);

    static readonly grpc::Method<global::SKF.Enlight.API.IAM.CheckAuthenticationInput, global::SKF.Enlight.API.IAM.UserClaims> __Method_CheckAuthentication = new grpc::Method<global::SKF.Enlight.API.IAM.CheckAuthenticationInput, global::SKF.Enlight.API.IAM.UserClaims>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckAuthentication",
        __Marshaller_grpcapi_CheckAuthenticationInput,
        __Marshaller_grpcapi_UserClaims);

    static readonly grpc::Method<global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput, global::SKF.Enlight.API.IAM.UserClaims> __Method_CheckAuthenticationByEndpoint = new grpc::Method<global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput, global::SKF.Enlight.API.IAM.UserClaims>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckAuthenticationByEndpoint",
        __Marshaller_grpcapi_CheckAuthenticationByEndpointInput,
        __Marshaller_grpcapi_UserClaims);

    static readonly grpc::Method<global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput, global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput> __Method_GetHierarchyRelations = new grpc::Method<global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput, global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetHierarchyRelations",
        __Marshaller_grpcapi_GetHierarchyRelationsInput,
        __Marshaller_grpcapi_GetHierarchyRelationsOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.IAM.GetEventRecordsInput, global::SKF.Enlight.API.IAM.GetEventRecordsOutput> __Method_GetEventRecords = new grpc::Method<global::SKF.Enlight.API.IAM.GetEventRecordsInput, global::SKF.Enlight.API.IAM.GetEventRecordsOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetEventRecords",
        __Marshaller_grpcapi_GetEventRecordsInput,
        __Marshaller_grpcapi_GetEventRecordsOutput);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of IAM</summary>
    [grpc::BindServiceMethod(typeof(IAM), "BindService")]
    public abstract partial class IAMBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Common.PrimitiveString> DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.IAM.UserClaims> CheckAuthentication(global::SKF.Enlight.API.IAM.CheckAuthenticationInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.IAM.UserClaims> CheckAuthenticationByEndpoint(global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput> GetHierarchyRelations(global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.IAM.GetEventRecordsOutput> GetEventRecords(global::SKF.Enlight.API.IAM.GetEventRecordsInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for IAM</summary>
    public partial class IAMClient : grpc::ClientBase<IAMClient>
    {
      /// <summary>Creates a new client for IAM</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IAMClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IAM that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IAMClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IAMClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IAMClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SKF.Enlight.API.Common.PrimitiveString DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Common.PrimitiveString DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual global::SKF.Enlight.API.IAM.UserClaims CheckAuthentication(global::SKF.Enlight.API.IAM.CheckAuthenticationInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAuthentication(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.IAM.UserClaims CheckAuthentication(global::SKF.Enlight.API.IAM.CheckAuthenticationInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckAuthentication, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.UserClaims> CheckAuthenticationAsync(global::SKF.Enlight.API.IAM.CheckAuthenticationInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAuthenticationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.UserClaims> CheckAuthenticationAsync(global::SKF.Enlight.API.IAM.CheckAuthenticationInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckAuthentication, null, options, request);
      }
      public virtual global::SKF.Enlight.API.IAM.UserClaims CheckAuthenticationByEndpoint(global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAuthenticationByEndpoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.IAM.UserClaims CheckAuthenticationByEndpoint(global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckAuthenticationByEndpoint, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.UserClaims> CheckAuthenticationByEndpointAsync(global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAuthenticationByEndpointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.UserClaims> CheckAuthenticationByEndpointAsync(global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckAuthenticationByEndpoint, null, options, request);
      }
      public virtual global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput GetHierarchyRelations(global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHierarchyRelations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput GetHierarchyRelations(global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetHierarchyRelations, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput> GetHierarchyRelationsAsync(global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHierarchyRelationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput> GetHierarchyRelationsAsync(global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetHierarchyRelations, null, options, request);
      }
      public virtual global::SKF.Enlight.API.IAM.GetEventRecordsOutput GetEventRecords(global::SKF.Enlight.API.IAM.GetEventRecordsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEventRecords(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.IAM.GetEventRecordsOutput GetEventRecords(global::SKF.Enlight.API.IAM.GetEventRecordsInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetEventRecords, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.GetEventRecordsOutput> GetEventRecordsAsync(global::SKF.Enlight.API.IAM.GetEventRecordsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEventRecordsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.IAM.GetEventRecordsOutput> GetEventRecordsAsync(global::SKF.Enlight.API.IAM.GetEventRecordsInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetEventRecords, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IAMClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IAMClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(IAMBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeepPing, serviceImpl.DeepPing)
          .AddMethod(__Method_CheckAuthentication, serviceImpl.CheckAuthentication)
          .AddMethod(__Method_CheckAuthenticationByEndpoint, serviceImpl.CheckAuthenticationByEndpoint)
          .AddMethod(__Method_GetHierarchyRelations, serviceImpl.GetHierarchyRelations)
          .AddMethod(__Method_GetEventRecords, serviceImpl.GetEventRecords).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, IAMBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeepPing, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Common.PrimitiveString>(serviceImpl.DeepPing));
      serviceBinder.AddMethod(__Method_CheckAuthentication, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.IAM.CheckAuthenticationInput, global::SKF.Enlight.API.IAM.UserClaims>(serviceImpl.CheckAuthentication));
      serviceBinder.AddMethod(__Method_CheckAuthenticationByEndpoint, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.IAM.CheckAuthenticationByEndpointInput, global::SKF.Enlight.API.IAM.UserClaims>(serviceImpl.CheckAuthenticationByEndpoint));
      serviceBinder.AddMethod(__Method_GetHierarchyRelations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput, global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput>(serviceImpl.GetHierarchyRelations));
      serviceBinder.AddMethod(__Method_GetEventRecords, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.IAM.GetEventRecordsInput, global::SKF.Enlight.API.IAM.GetEventRecordsOutput>(serviceImpl.GetEventRecords));
    }

  }
}
#endregion
