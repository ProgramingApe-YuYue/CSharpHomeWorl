using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Form
    {
        public Clock clock = new Clock();
        public Form()
        {
            clock.OnClock += Clock_Tick;
            
        }
        void Clock_Tick(object sender)
        {
            while(true)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                if (int.Parse(DateTime.Now.Second.ToString()) == 0)
                {
                    Console.WriteLine("整点!");
                }

            }
            
        }
        
    }
}
