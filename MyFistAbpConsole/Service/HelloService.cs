using System;
using System.Threading.Channels;
using Microsoft.Extensions.Options;
using MyFistAbpConsole.Interface;

namespace MyFistAbpConsole.Service
{
    public class HelloService : IHello
    {
        private readonly HelloService _hello;

        public HelloService(IOptions<HelloService> hello)
        {
            _hello = hello.Value;
        }

        public void Writer()
        {
            Console.WriteLine(_hello._hello);
        }
    }
}
