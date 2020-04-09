namespace DrawTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deepthNum = new System.Windows.Forms.NumericUpDown();
            this.Leng = new System.Windows.Forms.NumericUpDown();
            this.rightRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leftRate = new System.Windows.Forms.NumericUpDown();
            this.rightAngle = new System.Windows.Forms.NumericUpDown();
            this.leftAngle = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Button();
            this.penColor = new System.Windows.Forms.ColorDialog();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deepthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "递归深度";
            // 
            // deepthNum
            // 
            this.deepthNum.Location = new System.Drawing.Point(133, 7);
            this.deepthNum.Name = "deepthNum";
            this.deepthNum.Size = new System.Drawing.Size(116, 25);
            this.deepthNum.TabIndex = 5;
            this.deepthNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Leng
            // 
            this.Leng.Location = new System.Drawing.Point(133, 60);
            this.Leng.Name = "Leng";
            this.Leng.Size = new System.Drawing.Size(116, 25);
            this.Leng.TabIndex = 6;
            this.Leng.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // rightRate
            // 
            this.rightRate.Location = new System.Drawing.Point(437, 7);
            this.rightRate.Name = "rightRate";
            this.rightRate.Size = new System.Drawing.Size(116, 25);
            this.rightRate.TabIndex = 7;
            this.rightRate.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "主干长度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(290, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "右分支长度比";
            // 
            // leftRate
            // 
            this.leftRate.Location = new System.Drawing.Point(437, 60);
            this.leftRate.Name = "leftRate";
            this.leftRate.Size = new System.Drawing.Size(116, 25);
            this.leftRate.TabIndex = 10;
            // 
            // rightAngle
            // 
            this.rightAngle.Location = new System.Drawing.Point(731, 7);
            this.rightAngle.Name = "rightAngle";
            this.rightAngle.Size = new System.Drawing.Size(116, 25);
            this.rightAngle.TabIndex = 11;
            // 
            // leftAngle
            // 
            this.leftAngle.Location = new System.Drawing.Point(731, 60);
            this.leftAngle.Name = "leftAngle";
            this.leftAngle.Size = new System.Drawing.Size(116, 25);
            this.leftAngle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(290, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "左分支长度比";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(606, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "右分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(606, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "左分支角度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // labelColor
            // 
            this.labelColor.Location = new System.Drawing.Point(895, 7);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(141, 32);
            this.labelColor.TabIndex = 18;
            this.labelColor.Text = "颜色设置";
            this.labelColor.UseVisualStyleBackColor = true;
            this.labelColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(812, 123);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 15);
            this.result.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leftAngle);
            this.Controls.Add(this.rightAngle);
            this.Controls.Add(this.leftRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightRate);
            this.Controls.Add(this.Leng);
            this.Controls.Add(this.deepthNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deepthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown deepthNum;
        private System.Windows.Forms.NumericUpDown Leng;
        private System.Windows.Forms.NumericUpDown rightRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown leftRate;
        private System.Windows.Forms.NumericUpDown rightAngle;
        private System.Windows.Forms.NumericUpDown leftAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button labelColor;
        private System.Windows.Forms.ColorDialog penColor;
        private System.Windows.Forms.Label result;
    }
}

