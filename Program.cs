using System;

using System;
using Grpc.Core;
using Helloworld;

namespace grpc_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
            // using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            // Investigate: how come CalculatorClient?
            var client = new Calculator.CalculatorClient(channel);

            var reply = client.SquareRoot(
                              new Number { value = 16.0 });
            Console.WriteLine("SquareRoot: " + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
