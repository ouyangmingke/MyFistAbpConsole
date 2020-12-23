
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
    public class Abp_Module : AbpModule
    {
        /// <summary>
        /// 重写 AbpModule 的 ConfigureServices 
        /// 会自动运行 实行依赖注入
        /// 不重写的话会给你默认的依赖项
        /// </summary>
        /// <param name="context"></param>
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            // 在此处注入依赖项   把服务放到容器中
            // 模块会在容器中寻找符合的依赖进行注入
            // 如果没有找到会自动的New一个进行注入
            //（context.Services. ）可以省略
            context.Services.Configure<MyOptions>((options) =>
            {
                options.Value1 = "Abp_Module创建";
                options.Value2 = "自动";
            });
        }


    }

}
