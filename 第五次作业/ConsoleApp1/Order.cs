using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {//订单类中包括用户姓名、配送地址、订单以及订单明细等数据类型
        
        public Order(string customerName,string adress,int id)
        {
            this.CustomerName = customerName;
            this.Adress = adress;
            this.OrderID = id;
            this.Item = new OrderItem(id);
            
            Console.WriteLine("\r\n有用户下单!");
            Console.WriteLine(this);
        }
        
        public string CustomerName { get; set; }
        public string Adress { get; set; }
        public int OrderID { get;  }
        public OrderItem Item;
        //重写ToString()方法
        public override string ToString()
        {
            string a = "客户姓名：" + CustomerName + "\r\n配送地址：" + Adress + "\r\n订单号：" + OrderID;
            return a;
        }
        //重写Equals()方法
        public override bool Equals(Object obj)
        {//实际运用中订单号应当是可以唯一标识一个订单的，但这里还判断了用户姓名
            Order other = (Order)obj;
            if (other == null)
                return false;
            else
                return this.OrderID == other.OrderID && this.CustomerName == other.CustomerName;
            
        }
        public override int GetHashCode()
        {
            return OrderID;
        }

    }
}
