# proto
gRPC protocol buffer message types (proto files) for accessing Enlight

ps: docker is your friend: docker run -it --rm -v ${PWD}:/root/ golang:1.8 sh -c "apt-get install -y autoconf automake libtool curl make g++ unzip; git clone https://github.com/protocolbuffers/protobuf.git; cd protobuf; git submodule update --init --recursive; ./autogen.sh; ./configure; make; make install; ldconfig; go get -u github.com/golang/protobuf/protoc-gen-go; sh"
ex protoc --go_out=plugins=grpc:. iot/grpcapi.proto

## Services
- HM: Hierarchy management
- IAM: Identity and Access Management
- IoT: Internet of Things
- PAS: Point Alarm Status
- Reports: Fault details

## Travis generated source
Travis is setup to automatically (re)generate sources for:

- Go [branch](https://github.com/SKF/proto/tree/go1)
- C# / .NET [branch](https://github.com/SKF/proto/tree/csharp)
- Python [branch](https://github.com/SKF/proto/tree/python)
