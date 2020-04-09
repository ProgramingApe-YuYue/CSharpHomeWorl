using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            int deepth = (int)deepthNum.Value;
            
            
            th1 = (double)rightAngle.Value * Math.PI / 180;
            th2 = (double)leftAngle.Value * Math.PI / 180;
            per1 = (double)rightRate.Value / 100;
            per2 = (double)leftRate.Value / 100;

            drawCayleyTree(deepth, 200, 310, (int)Leng.Value, -Math.PI / 2);
        }
        private Graphics graphics;
        
        public double th1 { set; get; }
        public double th2 { set; get; }
        public double per1 { set; get; }
        public double per2 { set; get; }
        
        /*
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        */

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        Pen pen { set; get; }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            try
            {
                graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
            }
            catch(ArgumentNullException e)
            {
                
                result.Text = "颜色"+e.Message;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.penColor.ShowDialog()==DialogResult.OK)
            {
                this.pen = new Pen(penColor.Color);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
