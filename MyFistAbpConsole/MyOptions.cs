﻿/**
* 命名空间: MyFistAbpConsole
*
* 功 能： 选项类  当前的作用相当于 Model 实体
* 类 名： MyOptions
*
* Ver           变更日期                    创建人
* V1.0.0.0      2020/12/13 22:27:40         阳明柯   
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

namespace MyFistAbpConsole
{
    public class MyOptions
    {
        public MyOptions(string _value1, string _value2)
        {
            Value1 = _value1;
            Value2 = _value2;
        }

        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
