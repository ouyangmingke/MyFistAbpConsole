using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace MyFistAbpConsole
{
    /// <summary>
    /// 服务类     需要把服务注册到容器中
    /// 继承ITransientDependency接口（瞬态的 生命周期） 其中一种方法
    /// </summary>
    class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
