using System;
using System.Collections.Generic;
using System.Text;

namespace MyFistAbpConsole.Abstract
{
    /// <summary>
    /// 用于判断服务依赖是否注入
    /// </summary>
    public abstract class TFDI
    {
        public static string TF = "还没有注入";

        /// <summary>
        /// 输出TF  查看TF是否被修改
        /// </summary>
        public static  void TFWrite()
        {
            Console.WriteLine(TF);
        }
    }
}
