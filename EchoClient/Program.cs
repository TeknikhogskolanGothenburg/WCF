using System;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoService1.EchoServiceClient proxy = new EchoService1.EchoServiceClient();
            var msg = proxy.GetData(7);
            Console.WriteLine(msg);
        }
    }
}
