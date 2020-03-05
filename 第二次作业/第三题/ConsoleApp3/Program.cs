using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayList = new int[99];
            for(int i=0;i<arrayList.Length;i++)
            {
                arrayList[i] = i + 2;
            }//创建一个包含2-100的整数数组

            for(int i=0;i< arrayList.Length; i++)
            {
                for(int n=2;n<=10;n++)
                {
                    if(arrayList[i] % n == 0 && arrayList[i] / n > 1)
                    {
                        arrayList[i] = 0;
                    }
                }
                
            }//删除数组中i的倍数

            for (int i=0;i<arrayList.Length;i++)
            {
                if(arrayList[i]!=0)
                {
                    Console.Write(arrayList[i] + " ");
                }
            }//输出数组

            Console.Write("按任意键关闭");
            Console.ReadKey();
        }
    }
}
