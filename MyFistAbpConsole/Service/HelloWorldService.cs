using System;

using Microsoft.Extensions.Options;

using MyFistAbpConsole.Abstract;
using MyFistAbpConsole.dependent;

using Volo.Abp.DependencyInjection; //依赖注入

namespace MyFistAbpConsole.Service
{
    /// <summary>
    /// 服务类     需要把服务注册到容器中 通过继承来把服务放到容器中
    /// 继承 TFDI 抽象类
    /// 继承ITransientDependency接口（瞬态的 生命周期） 其中一种方法
    /// </summary>
    public class HelloWorldService : TFDI, ITransientDependency
    {
        //依赖项 当前的依赖是 Model实体
        private readonly MyOptions _options;
        //获取依赖的开放方法
        public HelloWorldService(IOptions<MyOptions> options)
        {
            TF = "HelloWorldService——依赖已经注入";
            _options = options.Value;
        }
        //得到当前依赖内容
        public void DoIt()
        {
            var v1 = _options.Value1;
            var v2 = _options.Value2;
            Console.WriteLine("HelloWorldService当前依赖内容：" + v1 + v2);
        }



    }
}
