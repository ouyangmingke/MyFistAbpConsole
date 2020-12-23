using System;

using Microsoft.Extensions.Options;
using MyFistAbpConsole.dependent;

namespace MyFistAbpConsole.Service
{
    public class AfcService
    {
        //依赖项 当前的依赖是 Model实体
        private readonly MyOptions _options;

        //获取依赖的开放方法
        public AfcService(IOptions<MyOptions> options)
        {
            _options = options.Value;
        }

        //得到当前依赖内容
        public void DoIt()
        {
            var v1 = _options.Value1;
            var v2 = _options.Value2;
            Console.WriteLine("AfcService当前依赖内容：" + v1 + v2);
        }

    }
}
