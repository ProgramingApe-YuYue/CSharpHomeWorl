﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//使用事件机制，模拟实现一个闹钟功能。
//闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//在闹钟走时时或者响铃时，在控制台显示提示信息。
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.clock.onClock();
        }
    }
}
