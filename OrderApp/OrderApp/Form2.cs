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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //这个构造函数可以用来实现在Form2中修改Form1中的值
        private BindingSource bds;
        //private Form1 f1;
        public Form2(BindingSource bds)
        {
            InitializeComponent();
            this.bds = bds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(OrderID.Text!=null&& CustomerName.Text!=null&& Adress.Text!=null)
            {

                Order newOrder = OrderService.buildOrder (CustomerName.Text, Adress.Text, int.Parse(OrderID.Text));
                
                bds.ResetBindings(false);
                
                
                
            }
            
            
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
