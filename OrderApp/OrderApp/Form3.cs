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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private BindingSource bds;
        private Order od;
        public Form3(BindingSource bds,Order od)
        {
            InitializeComponent();
            this.bds = bds;
            this.od = od;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GoodsID.Text != "" && Num.Text != "" && Price.Text != "")
            {
                OrderService.addGoods(od, int.Parse(GoodsID.Text), int.Parse(Num.Text), int.Parse(Price.Text));
                bds.ResetBindings(false);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Msg.Text = "输入不得为空！";
            }
                


            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
