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
            Console.WriteLine("输入一个数以求其所有质数因子");
            int inPut;
            inPut = Convert.ToInt32(Console.ReadLine());
            int prime = 2;
            while(inPut!=1)
            {
                if(inPut%prime==0)
                {
                    inPut /= prime;
                    Console.Write(prime + " ");
                }
                else
                {
                    prime++;
                }
            }
            Console.WriteLine("按任意键关闭");
            Console.ReadKey();
        }
    }
}
