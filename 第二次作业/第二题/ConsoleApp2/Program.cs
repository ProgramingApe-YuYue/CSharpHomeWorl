using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public int Max(int[] a, int n)
        {
            int max=a[0];
            for(int i=1;i<n;i++)
            {
                if(max<=a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static public int Min(int[] a, int n)
        {
            int min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (min >= a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        static public int Sum(int[] a,int n)
        {
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                sum += a[i];
            }
            return sum;
        }
        static public double Average(int [] a,int n)
        {
            return (double)Sum(a, n) / n;
        }

        static void Main(string[] args)
        {

            int[] arrayList = new int[6] { 1,2,3,4,5,6};
            Console.WriteLine("最大值：" + Max(arrayList, arrayList.GetLength(0)));
            Console.WriteLine("最小值：" + Min(arrayList, arrayList.GetLength(0)));
            Console.WriteLine("求和：" + Sum(arrayList, arrayList.GetLength(0)));
            Console.WriteLine("求平均值：" + Average(arrayList, arrayList.GetLength(0)));
            Console.Write("按任意键关闭");
            Console.ReadKey();
        }
    }
}
