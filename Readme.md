ABP的基础结构就在这里了

### 加载模块

> **AbpApplicationFactory.Create**  加载 Abp_Module 启动模块.
>
> ```c#
> var application = AbpApplicationFactory.Create<Abp_Module>();
> ```
>
> 

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

