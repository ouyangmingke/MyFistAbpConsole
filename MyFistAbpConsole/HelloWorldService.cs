using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

using Volo.Abp.DependencyInjection;//依赖注入

namespace MyFistAbpConsole
{
    /// <summary>
    /// 服务类     需要把服务注册到容器中
    /// 继承ITransientDependency接口（瞬态的 生命周期） 其中一种方法
    /// </summary>
    public class HelloWorldService : ITransientDependency
    {
        private readonly MyOptions _options;
        public HelloWorldService(IOptions<MyOptions> options)
        {
            _options = options.Value;
        }
        public void DoIt()
        {
            var v1 = _options.Value1;
            var v2 = _options.Value2;
            Console.WriteLine(v1 + v2);
        }

        public string Name = "Hello Word";
        public void SayHello()
        {
            Console.WriteLine(Name);
        }

    }
}
