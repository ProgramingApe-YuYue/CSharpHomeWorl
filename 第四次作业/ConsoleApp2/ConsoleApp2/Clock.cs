using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //声明一个委托，定义事件处理函数的格式
    public delegate void ClockHandler(object sender);
    class Clock
    {
        //定义事件，相当于创建一个委托实例
        public event ClockHandler OnClock;

        public void onClock()
        {

            Console.WriteLine($"时钟启动");
            //打开闹钟
            OnClock(this);
        }

    }
}
