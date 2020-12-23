using System;
using System.Threading.Channels;

using Microsoft.Extensions.Options;

using MyFistAbpConsole.dependent;
using MyFistAbpConsole.Interface;

namespace MyFistAbpConsole.Service
{
    public class HelloService : IHello
    {
        private readonly HelloDep _hello;

        public HelloService(IOptions<HelloDep> hello)
        {
            _hello = hello.Value;
        }

        public void Writer()
        {
            Console.WriteLine("Hello——1" + _hello.Hello);
        }
    }
}
