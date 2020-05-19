using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
namespace OrderApp
{
    public partial class Form1 : Form
    {
        public int KeyWord { get; set; }
        public Form1()
        {
            InitializeComponent();
            
            //创建一个订单
            Order Yu = OrderService.buildOrder("余跃", "湖北省", 100);
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
            

            orderBindingSource.DataSource = OrderService.OrderList;
            //OrderView.Rows[1].Selected = true;
            ID.DataBindings.Add("Text", this, "KeyWord");



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BuildOrder_Click(object sender, EventArgs e)
        {
            Form2 OrderForm = new Form2(orderBindingSource);
            
            if (OrderForm.ShowDialog() == DialogResult.Yes)
            {
                this.Refresh();
            }
           // OrderForm.ShowDialog();
        }

        private void AddGoods_Click(object sender, EventArgs e)
        {
            Form3 GoodsForm = new Form3(goodsBindingSource, od);
            if (GoodsForm.ShowDialog() == DialogResult.Yes)
            {
                this.Refresh();
            }
        }
        private Order od;
        private void OrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            goodsBindingSource.DataSource = OrderService.OrderList[e.RowIndex].Item.GoodsList;
            goodsBindingSource.ResetBindings(false);
            
            this.od = OrderService.OrderList[e.RowIndex];


        }
        

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KeyWord.ToString() == null || KeyWord.ToString() == "")
            {
                orderBindingSource.DataSource = OrderService.OrderList;
            }
            else
            {
                orderBindingSource.DataSource = OrderService.OrderList.Where(s => s.OrderID == KeyWord);
                goodsBindingSource.DataSource = OrderService.OrderList.Where(s => s.OrderID == KeyWord).First().Item.GoodsList;
            }
        }
    }
}
