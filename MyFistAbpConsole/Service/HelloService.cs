using System;
using System.Threading.Channels;

using Microsoft.Extensions.Options;

using MyFistAbpConsole.Abstract;
using MyFistAbpConsole.dependent;
using MyFistAbpConsole.Interface;

namespace MyFistAbpConsole.Service
{
    public class HelloService : TFDI, IHello
    {
        private readonly HelloDep _hello;
        public HelloService(IOptions<HelloDep> hello)
        {
            TF = "HelloService——依赖已经注入";
            _hello = hello.Value;
        }


        public void Writer()
        {
            Console.WriteLine("Hello——1" + _hello.Hello);
        }
    }
}
