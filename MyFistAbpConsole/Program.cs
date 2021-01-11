using System.Net.Mime;
using System;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyFistAbpConsole.Interface;
using MyFistAbpConsole.Module;
using MyFistAbpConsole.Service; //依赖注入
using Volo.Abp;

namespace MyFistAbpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbpApplicationFactory.Create 加载 Abp_Module 启动模块.块. Initialize()方法初始化.
            var application = AbpApplicationFactory.Create<Abp_Module>();
            application.Initialize();

            // ServiceProvider 引用应用程序使用的根服务提供者。在初始化应用程序之前不能使用它。
            // GetService/GetRequiredService  必须using Microsoft.Extensions.DependencyInjection;
            // 注入依赖 这里感觉更像是 通过反射获取服务
            // 这个服务是通过继承依赖接口来实现将服务放到容器中  当前服务是继承了 ITransientDependency
            // 获取服务时,会进行依赖注入
            // 最好使用GetRequiredService  因为如果出错 报错更快 https://www.cnblogs.com/yilezhu/p/11107648.html 
            var helloWoldService = application.ServiceProvider.GetRequiredService<HelloWorldService>();
            helloWoldService.DoIt();
            HelloWorldService.TFWrite();

            var helloService1 = application.ServiceProvider.GetRequiredService<HelloService>();
            helloService1.Writer();
            HelloService.TFWrite();
            var helloService2 = application.ServiceProvider.GetRequiredService<Hello2Service>();
            helloService2.Writer();
            //使用Fac
            var Afcapplication = AbpApplicationFactory.Create<Afc_Module>(options =>
            {
                options.UseAutofac();
            });
            Afcapplication.Initialize();

            var AfcService = Afcapplication.ServiceProvider.GetRequiredService<AfcService>();

            AfcService.DoIt();

        }

    }
}
