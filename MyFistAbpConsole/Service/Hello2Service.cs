/**
* 命名空间: MyFistAbpConsole.Service
*
* 功 能： N/A
* 类 名： Hello2Service
*
* Ver           变更日期                    创建人
* V1.0.0.0      2020/12/23 21:11:46         阳明柯   
*=====================================================================
*修改标记：
*修改时间：time
*修改人： username
*版本号： V1.0.0.0
*描述：  
*/
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Extensions.Options;

using MyFistAbpConsole.dependent;
using MyFistAbpConsole.Interface;

namespace MyFistAbpConsole.Service
{
    public class Hello2Service : IHello
    {
        private readonly HelloDep _hello;

        public Hello2Service(IOptions<HelloDep> hello)
        {
            _hello = hello.Value;
        }

        public void Writer()
        {
            Console.WriteLine("Hello——2" + _hello.Hello);
        }
    }
}
