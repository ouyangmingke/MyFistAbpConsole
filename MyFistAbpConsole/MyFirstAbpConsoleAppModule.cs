
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyFistAbpConsole
{
    /// <summary>
    /// 自定义模块  : 需要继承自 抽象类 AbpModule
    /// </summary>
    public class MyFirstAbpConsoleAppModule : AbpModule
    {
        //重写 AbpModule 的 ConfigureServices
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Console.WriteLine("会运行吗");

            //在此处注入依赖项 （context.Services. ）可以省略
            context.Services.Configure<MyOptions>(options =>
            {
                options.Value1 = "这里是手动注入依赖";
                options.Value2 = true;
            });
        }
    }

}
