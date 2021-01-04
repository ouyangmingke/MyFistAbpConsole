ABP的基础结构就在这里了

### 加载模块

> **AbpApplicationFactory.Create**  加载 Abp_Module 启动模块.
>
> ```c#
> var application = AbpApplicationFactory.Create<Abp_Module>();
> ```
>
> #### ConfigureServices（）模块中的方法 配置服务
>
> 向容器中添加依赖

### 初始化模块

> Initialize()方法启动应用程序.
>
> ```c#
> application.Initialize();
> ```
>
> 

### 获取依赖

> ```c#
> var helloWoldService = application.ServiceProvider.GetRequiredService<HelloWorldService>();
> ```
>
> 

#### [【ASP.NET Core】依赖注入高级玩法——如何注入多个服务实现类](https://www.cnblogs.com/tcjiaan/p/8732848.html)