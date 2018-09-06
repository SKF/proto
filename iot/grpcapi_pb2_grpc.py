# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
import grpc

import grpcapi_pb2 as grpcapi__pb2


class IoTStub(object):
  # missing associated documentation comment in .proto file
  pass

  def __init__(self, channel):
    """Constructor.

    Args:
      channel: A grpc.Channel.
    """
    self.DeepPing = channel.unary_unary(
        '/iotgrpcapi.IoT/DeepPing',
        request_serializer=grpcapi__pb2.PrimitiveVoid.SerializeToString,
        response_deserializer=grpcapi__pb2.PrimitiveString.FromString,
        )
    self.CreateTask = channel.unary_unary(
        '/iotgrpcapi.IoT/CreateTask',
        request_serializer=grpcapi__pb2.InitialTaskDescription.SerializeToString,
        response_deserializer=grpcapi__pb2.PrimitiveString.FromString,
        )
    self.GetAllTasks = channel.unary_unary(
        '/iotgrpcapi.IoT/GetAllTasks',
        request_serializer=grpcapi__pb2.PrimitiveString.SerializeToString,
        response_deserializer=grpcapi__pb2.TaskDescriptions.FromString,
        )
    self.GetUncompletedTasks = channel.unary_unary(
        '/iotgrpcapi.IoT/GetUncompletedTasks',
        request_serializer=grpcapi__pb2.PrimitiveString.SerializeToString,
        response_deserializer=grpcapi__pb2.TaskDescriptions.FromString,
        )
    self.SetTaskCompleted = channel.unary_unary(
        '/iotgrpcapi.IoT/SetTaskCompleted',
        request_serializer=grpcapi__pb2.TaskUser.SerializeToString,
        response_deserializer=grpcapi__pb2.PrimitiveVoid.FromString,
        )
    self.DeleteTask = channel.unary_unary(
        '/iotgrpcapi.IoT/DeleteTask',
        request_serializer=grpcapi__pb2.TaskUser.SerializeToString,
        response_deserializer=grpcapi__pb2.PrimitiveVoid.FromString,
        )
    self.GetUncompletedTasksByHierarchy = channel.unary_unary(
        '/iotgrpcapi.IoT/GetUncompletedTasksByHierarchy',
        request_serializer=grpcapi__pb2.PrimitiveString.SerializeToString,
        response_deserializer=grpcapi__pb2.TaskDescriptions.FromString,
        )
    self.SetTaskStatus = channel.unary_unary(
        '/iotgrpcapi.IoT/SetTaskStatus',
        request_serializer=grpcapi__pb2.SetTaskStatusInput.SerializeToString,
        response_deserializer=grpcapi__pb2.PrimitiveVoid.FromString,
        )
    self.GetTaskStream = channel.unary_stream(
        '/iotgrpcapi.IoT/GetTaskStream',
        request_serializer=grpcapi__pb2.GetTaskStreamInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetTaskStreamOutput.FromString,
        )
    self.GetTasksByStatus = channel.unary_unary(
        '/iotgrpcapi.IoT/GetTasksByStatus',
        request_serializer=grpcapi__pb2.GetTasksByStatusInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetTasksByStatusOutput.FromString,
        )
    self.GetTaskByUUID = channel.unary_unary(
        '/iotgrpcapi.IoT/GetTaskByUUID',
        request_serializer=grpcapi__pb2.GetTaskByUUIDInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetTaskByUUIDOutput.FromString,
        )
    self.GetTaskByLongId = channel.unary_unary(
        '/iotgrpcapi.IoT/GetTaskByLongId',
        request_serializer=grpcapi__pb2.GetTaskByLongIdInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetTaskByLongIdOutput.FromString,
        )
    self.IngestNodeData = channel.unary_unary(
        '/iotgrpcapi.IoT/IngestNodeData',
        request_serializer=grpcapi__pb2.IngestNodeDataInput.SerializeToString,
        response_deserializer=grpcapi__pb2.IngestNodeDataOutput.FromString,
        )
    self.IngestNodeDataStream = channel.stream_unary(
        '/iotgrpcapi.IoT/IngestNodeDataStream',
        request_serializer=grpcapi__pb2.IngestNodeDataStreamInput.SerializeToString,
        response_deserializer=grpcapi__pb2.IngestNodeDataStreamOutput.FromString,
        )
    self.GetLatestNodeData = channel.unary_unary(
        '/iotgrpcapi.IoT/GetLatestNodeData',
        request_serializer=grpcapi__pb2.GetLatestNodeDataInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetLatestNodeDataOutput.FromString,
        )
    self.GetNodeData = channel.unary_unary(
        '/iotgrpcapi.IoT/GetNodeData',
        request_serializer=grpcapi__pb2.GetNodeDataInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetNodeDataOutput.FromString,
        )
    self.GetNodeDataStream = channel.unary_stream(
        '/iotgrpcapi.IoT/GetNodeDataStream',
        request_serializer=grpcapi__pb2.GetNodeDataStreamInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetNodeDataStreamOutput.FromString,
        )
    self.GetMedia = channel.unary_unary(
        '/iotgrpcapi.IoT/GetMedia',
        request_serializer=grpcapi__pb2.GetMediaInput.SerializeToString,
        response_deserializer=grpcapi__pb2.GetMediaOutput.FromString,
        )


class IoTServicer(object):
  # missing associated documentation comment in .proto file
  pass

  def DeepPing(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def CreateTask(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetAllTasks(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetUncompletedTasks(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def SetTaskCompleted(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def DeleteTask(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetUncompletedTasksByHierarchy(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def SetTaskStatus(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetTaskStream(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetTasksByStatus(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetTaskByUUID(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetTaskByLongId(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def IngestNodeData(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def IngestNodeDataStream(self, request_iterator, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetLatestNodeData(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetNodeData(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetNodeDataStream(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')

  def GetMedia(self, request, context):
    # missing associated documentation comment in .proto file
    pass
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')


def add_IoTServicer_to_server(servicer, server):
  rpc_method_handlers = {
      'DeepPing': grpc.unary_unary_rpc_method_handler(
          servicer.DeepPing,
          request_deserializer=grpcapi__pb2.PrimitiveVoid.FromString,
          response_serializer=grpcapi__pb2.PrimitiveString.SerializeToString,
      ),
      'CreateTask': grpc.unary_unary_rpc_method_handler(
          servicer.CreateTask,
          request_deserializer=grpcapi__pb2.InitialTaskDescription.FromString,
          response_serializer=grpcapi__pb2.PrimitiveString.SerializeToString,
      ),
      'GetAllTasks': grpc.unary_unary_rpc_method_handler(
          servicer.GetAllTasks,
          request_deserializer=grpcapi__pb2.PrimitiveString.FromString,
          response_serializer=grpcapi__pb2.TaskDescriptions.SerializeToString,
      ),
      'GetUncompletedTasks': grpc.unary_unary_rpc_method_handler(
          servicer.GetUncompletedTasks,
          request_deserializer=grpcapi__pb2.PrimitiveString.FromString,
          response_serializer=grpcapi__pb2.TaskDescriptions.SerializeToString,
      ),
      'SetTaskCompleted': grpc.unary_unary_rpc_method_handler(
          servicer.SetTaskCompleted,
          request_deserializer=grpcapi__pb2.TaskUser.FromString,
          response_serializer=grpcapi__pb2.PrimitiveVoid.SerializeToString,
      ),
      'DeleteTask': grpc.unary_unary_rpc_method_handler(
          servicer.DeleteTask,
          request_deserializer=grpcapi__pb2.TaskUser.FromString,
          response_serializer=grpcapi__pb2.PrimitiveVoid.SerializeToString,
      ),
      'GetUncompletedTasksByHierarchy': grpc.unary_unary_rpc_method_handler(
          servicer.GetUncompletedTasksByHierarchy,
          request_deserializer=grpcapi__pb2.PrimitiveString.FromString,
          response_serializer=grpcapi__pb2.TaskDescriptions.SerializeToString,
      ),
      'SetTaskStatus': grpc.unary_unary_rpc_method_handler(
          servicer.SetTaskStatus,
          request_deserializer=grpcapi__pb2.SetTaskStatusInput.FromString,
          response_serializer=grpcapi__pb2.PrimitiveVoid.SerializeToString,
      ),
      'GetTaskStream': grpc.unary_stream_rpc_method_handler(
          servicer.GetTaskStream,
          request_deserializer=grpcapi__pb2.GetTaskStreamInput.FromString,
          response_serializer=grpcapi__pb2.GetTaskStreamOutput.SerializeToString,
      ),
      'GetTasksByStatus': grpc.unary_unary_rpc_method_handler(
          servicer.GetTasksByStatus,
          request_deserializer=grpcapi__pb2.GetTasksByStatusInput.FromString,
          response_serializer=grpcapi__pb2.GetTasksByStatusOutput.SerializeToString,
      ),
      'GetTaskByUUID': grpc.unary_unary_rpc_method_handler(
          servicer.GetTaskByUUID,
          request_deserializer=grpcapi__pb2.GetTaskByUUIDInput.FromString,
          response_serializer=grpcapi__pb2.GetTaskByUUIDOutput.SerializeToString,
      ),
      'GetTaskByLongId': grpc.unary_unary_rpc_method_handler(
          servicer.GetTaskByLongId,
          request_deserializer=grpcapi__pb2.GetTaskByLongIdInput.FromString,
          response_serializer=grpcapi__pb2.GetTaskByLongIdOutput.SerializeToString,
      ),
      'IngestNodeData': grpc.unary_unary_rpc_method_handler(
          servicer.IngestNodeData,
          request_deserializer=grpcapi__pb2.IngestNodeDataInput.FromString,
          response_serializer=grpcapi__pb2.IngestNodeDataOutput.SerializeToString,
      ),
      'IngestNodeDataStream': grpc.stream_unary_rpc_method_handler(
          servicer.IngestNodeDataStream,
          request_deserializer=grpcapi__pb2.IngestNodeDataStreamInput.FromString,
          response_serializer=grpcapi__pb2.IngestNodeDataStreamOutput.SerializeToString,
      ),
      'GetLatestNodeData': grpc.unary_unary_rpc_method_handler(
          servicer.GetLatestNodeData,
          request_deserializer=grpcapi__pb2.GetLatestNodeDataInput.FromString,
          response_serializer=grpcapi__pb2.GetLatestNodeDataOutput.SerializeToString,
      ),
      'GetNodeData': grpc.unary_unary_rpc_method_handler(
          servicer.GetNodeData,
          request_deserializer=grpcapi__pb2.GetNodeDataInput.FromString,
          response_serializer=grpcapi__pb2.GetNodeDataOutput.SerializeToString,
      ),
      'GetNodeDataStream': grpc.unary_stream_rpc_method_handler(
          servicer.GetNodeDataStream,
          request_deserializer=grpcapi__pb2.GetNodeDataStreamInput.FromString,
          response_serializer=grpcapi__pb2.GetNodeDataStreamOutput.SerializeToString,
      ),
      'GetMedia': grpc.unary_unary_rpc_method_handler(
          servicer.GetMedia,
          request_deserializer=grpcapi__pb2.GetMediaInput.FromString,
          response_serializer=grpcapi__pb2.GetMediaOutput.SerializeToString,
      ),
  }
  generic_handler = grpc.method_handlers_generic_handler(
      'iotgrpcapi.IoT', rpc_method_handlers)
  server.add_generic_rpc_handlers((generic_handler,))