﻿using Autofac.Extensions.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

using MyFistAbpConsole.dependent;
using MyFistAbpConsole.Service;

using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyFistAbpConsole.Module
{
    /// <summary>
    /// 把Autofac模块添加到当前模块中来
    ///  
    /// </summary>
    [DependsOn(typeof(AbpAutofacModule))]
    public class Afc_Module : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            context.Services.AddAutofac();

            // 可以这样理解  这里才是手动注入服务   并配置服务的生命周期 
            // AddSingleton：单个实例，这是寿命最长的，与天同寿。整个应用程序中仅用一个实例。

            // AddTransient：这个是最短命的，可能是天天晚上加班熬夜，死得很快。此种情况下，服务类的实例是用的时候创建，用完后直接销毁。

            // AddScoped：这个比较难理解。它的生命周期在单个请求内，包括客户端与服务器之间随后产生的子请求，反正只要请求的会话结束了，就会清理。
            context.Services.AddTransient<AfcService>();


            // 这个位置 Configure 虽然也可以注入但是更多的是 用来修改配置内容
            // 比容当前 有个配置类 MyOptions 在这里对它进行赋值 修改 等 
            // 然后可以在当前项目中使用  MyOptions 中的配置
            context.Services.Configure<MyOptions>((options) =>
            {
                options.Value1 = "Afc_Module创建";
                options.Value2 = "手动";
            });
        }

    }
}
