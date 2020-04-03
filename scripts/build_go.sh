set -e
mkdir -p build/go
PROTOC=build/protoc/bin/protoc
PLUGIN=build/bin/protoc-gen-go
MAJOR_VERSION=$(echo ${TRAVIS_TAG} | awk -F. '{ print $1 }')

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

pushd build/go
go mod init github.com/SKF/proto/${MAJOR_VERSION}
find . -type f -name \*.go -exec sed -i -e "s,github.com/SKF/proto,github.com/SKF/proto/${MAJOR_VERSION},g" {} \;
go mod tidy
popd
