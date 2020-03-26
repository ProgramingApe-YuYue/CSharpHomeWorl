using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Goods
    {
        public Goods(int goodsID,int num,double price)
        {
            this.Next = null;
            this.GoodsID = goodsID;
            this.Num = num;
            this.Price = price;
        }
        
        public double Price { get; set; }
        public Goods Next { get; set; }
        public int Num { set; get; }
        public int GoodsID { set; get; }
        public override string ToString()
        {
            return "货号："+GoodsID+"单价："+Price+"数量："+Num+"\r\n";
        }
    }
    class OrderItem
    {
        //订单明细中有一个链表，储存所有的货物信息
        private Goods head;
        private Goods tail;
        public Goods Head
        {
            get => head;
        }
        public double PriceSum { get; set; }
        public void AddGoods(int goodsID, int num,double price)
        {
            
            Goods newGoods = new Goods(goodsID, num,price);
            if (tail == null)
                head = tail = newGoods;
            else
            {
                tail.Next = newGoods;
                tail = newGoods;
            }
            this.PriceSum += num * price;
        }

        public OrderItem(int id)
        {
            this.OrderID = id;
        }
        public int OrderID { get; }

        //重写Equals()方法
        public override bool Equals(object obj)
        {
            OrderItem other = (OrderItem)obj;
            if(other==null)
            {
                return false;
            }else 
            {
                return this.OrderID == other.OrderID;
            }
            
        }
        //重写ToString()方法
        public override string ToString()
        {
            string a =  "订单号：" + OrderID+ "\r\n货物列表：\r\n";
            for(Goods goods=this.Head;goods!=null;goods=goods.Next)
            {
                a += goods;
            }
            a += "总价：" + PriceSum+"\r\n";
            return a;
        }
        public override int GetHashCode()
        {
            return OrderID;
        }
    }
}
