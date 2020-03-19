using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for(int x=0;x<10;x++)
            {
                intList.Add(x);
            }
            
            Console.WriteLine("调用ForEach()打印链表元素");
            intList.ForEach(Console.Write);
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int sum = 0;
            Console.WriteLine("");
            Console.WriteLine("调用ForEach()求最大值");
            intList.ForEach((int s )=> { if (max < s) max = s; });
            Console.WriteLine(max);

            Console.WriteLine("调用ForEach()求最小值");
            intList.ForEach((int s) => { if (min > s) min = s; });
            Console.WriteLine(min);

            Console.WriteLine("调用ForEach()求和");
            intList.ForEach((int s) => { sum += s; });
            Console.WriteLine(sum);


            Console.ReadKey();
            
        }

    }
}
