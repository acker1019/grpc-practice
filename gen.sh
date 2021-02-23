python -m grpc_tools.protoc -I. --python_out=. --grpc_python_out=. calculator.proto
protoc -I=. --csharp_out=. calculator.proto
dotnet add package Grpc.Net.Client Google.Protobuf Grpc.Tools Grpc.AspNetCore
