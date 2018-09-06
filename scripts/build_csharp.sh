mkdir -p build/csharp
TOOLS=$(ls -d build/csharp_project/packages/grpc.tools/*/tools/linux_x64/)
PROTOC=$TOOLS/protoc
PLUGIN=$TOOLS/grpc_csharp_plugin

for SERVICE in $SERVICES; do
  mkdir -p build/csharp/$SERVICE;
  $PROTOC \
    --csharp_out build/csharp/$SERVICE \
    --grpc_out build/csharp/$SERVICE \
    --plugin protoc-gen-grpc=$PLUGIN \
    $SERVICE/*.proto;
done