ABP的基础结构就在这里了

### 加载模块

> **AbpApplicationFactory(**) 用于创建应用程序并加载所有以AppModule作为启动模块的模块.
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

### 依赖注入 DI

> ```
>  var helloWoldService = application.ServiceProvider.GetRequiredService<HelloWorldService>();
> ```
>
> 

