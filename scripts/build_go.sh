set -e
mkdir -p build/go
PROTOC=build/protoc/bin/protoc
PLUGIN=build/bin/protoc-gen-go

mkdir -p build/go/common;
$PROTOC \
  --go_out plugins=grpc:build/go/ \
  --plugin $PLUGIN \
  common/common.proto;
mv build/go/github.com/SKF/proto/common/* build/go/common;
rm -rf build/go/github.com;

for SERVICE in $SERVICES; do
  mkdir -p build/go/$SERVICE;
  $PROTOC \
    --go_out plugins=grpc:build/go/ \
    --plugin $PLUGIN \
    $SERVICE/*.proto;
done
