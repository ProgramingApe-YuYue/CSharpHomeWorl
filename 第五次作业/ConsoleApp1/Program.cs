using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个订单
            Order Yu=OrderService.buildOrder("余跃", "湖北省", 100);
            //添加商品
            OrderService.addGoods(Yu, 4399, 3, 50);
            OrderService.addGoods(Yu, 1321, 1, 199);
            OrderService.addGoods(Yu, 4346, 10, 10);
            Order Xin = OrderService.buildOrder("辛洋", "内蒙古自治区", 101);
            OrderService.addGoods(Xin, 1321, 1, 200);
            OrderService.addGoods(Xin, 1412, 2, 5);
            Order Yang = OrderService.buildOrder("杨海", "贵州省", 102);
            OrderService.addGoods(Yang, 4399, 10, 50);
            OrderService.addGoods(Yang, 4511, 1, 68);
            Order Zhang = OrderService.buildOrder("张天丰", "山西省", 103);
            OrderService.addGoods(Zhang, 3241, 1, 99);
            OrderService.searchOrder(102);
            OrderService.searchOrderItem(101);
            OrderService.searchOrder("辛洋");






            Console.ReadKey();


        }
    }
}
