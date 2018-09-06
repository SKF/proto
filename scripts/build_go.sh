mkdir -p build/go
PROTOC=build/protoc/bin/protoc
PLUGIN=build/bin/protoc-gen-go

for SERVICE in $SERVICES; do
  mkdir -p build/go/$SERVICE;
  $PROTOC \
    --go_out=plugins=grpc:build/go/ \
    --plugin $PLUGIN $SERVICE/*.proto;
done