using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderService
    {
        public static List<Order> OrderList=new List<Order>();
        //public List<OrderItem> OrderItemList;
        public static Order buildOrder(string customerName, string adress, int id)
        {
            Order newOrder = new Order(customerName, adress, id);
            OrderList.Add(newOrder);
            return newOrder;
        }

        public static void addGoods(Order order, int goodsID, int num,double price)
        {
            order.Item.AddGoods(goodsID, num,price);
            Console.WriteLine(order.CustomerName+"以单价"+price+"元加入货号为"+goodsID+"的商品"+num+"件，"+"订单号为："+order.OrderID);
        }
        //查询订单号为id的订单
        public static void searchOrder(int id)
        {
            Console.WriteLine("\r\n查询订单号为" + id + "的订单");
            var find = from n in OrderList
                       where n.OrderID == id
                       orderby n.Item.PriceSum
                       select n;
            foreach(var x in find)
            {
                Console.WriteLine(x);
            }
        }
        //查询客户姓名为name的订单
        public static void searchOrder(string name)
        {
            Console.WriteLine("\r\n查询" + name + "的订单");
            var find = from n in OrderList
                       where n.CustomerName == name
                       orderby n.Item.PriceSum
                       select n;
            foreach (var x in find)
            {
                Console.WriteLine(x);
            }
        }
        //查询订单号为id的订单
        public static void searchOrderItem(int id)
        {
            Console.WriteLine("\r\n查询订单号为" + id + "的订单明细");
            var find = from n in OrderList
                       where n.OrderID == id
                       orderby n.Item.PriceSum
                       select n;
                       
            
            foreach (var x in find)
            {
                Console.WriteLine(x.Item);
            }
        }
    }
}
