using System.Net.Mime;
using System;

using Microsoft.Extensions.DependencyInjection;//依赖注入
using Volo.Abp;

namespace MyFistAbpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbpApplicationFactory 用于创建应用程序并加载所有以AppModule作为启动模块的模块. Initialize()方法启动应用程序.
            var application = AbpApplicationFactory.Create<MyFirstAbpConsoleAppModule>();
            application.Initialize();

            // ServiceProvider 引用应用程序使用的根服务提供者。在初始化应用程序之前不能使用它。
            // GetService/GetRequiredService  必须using Microsoft.Extensions.DependencyInjection;
            // 最好使用GetRequiredService  因为如果出错 报错更快 https://www.cnblogs.com/yilezhu/p/11107648.html 
            var helloWoldService = application.ServiceProvider.GetRequiredService<HelloWorldService>();
            helloWoldService.SayHello();

        }
    }
}
