# proto
gRPC protocol buffer message types (proto files) for accessing Enlight

## Notes

PS: docker is your friend:
```sh
docker run -it --rm -v ${PWD}:/root/ golang:1.11 sh -c "apt-get update && \
    apt-get install -y autoconf automake libtool curl make g++ unzip \
    libprotobuf-dev protobuf-compiler && \
    go get -d -u github.com/golang/protobuf/protoc-gen-go && \
    git -C /go/src/github.com/golang/protobuf checkout v1.2.0 && \
    go install github.com/golang/protobuf/protoc-gen-go; cd /root; bash"
```
E.g `protoc --go_out=plugins=grpc:. iot/grpcapi.proto`

The Golang auto-generated sources are currently at package version 2, see [commit](https://github.com/SKF/proto/commit/6ed05b9c0b973b71590982ce0527938c63cae0d4)

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


