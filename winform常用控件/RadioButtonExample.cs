using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform常用控件
{
    public partial class RadioButtonExample : Form
    {
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton6;
        private Button button;

        public RadioButtonExample()
        {
            InitializeComponent();
            radioButton1 = new RadioButton();
            radioButton1.Text = "选项 1";
            radioButton1.Location = new System.Drawing.Point(20, 20);

            radioButton2 = new RadioButton();
            radioButton2.Text = "选项 2";
            radioButton2.Location = new System.Drawing.Point(20, 50);

            radioButton3 = new RadioButton();
            radioButton3.Text = "选项 3";
            radioButton3.Location = new System.Drawing.Point(20, 80);

            radioButton6 = new RadioButton();
            radioButton6.Text = "选项 6";
            radioButton6.Location = new System.Drawing.Point(20, 120);

            button = new Button();
            button.Text = "确定";
            button.Location = new System.Drawing.Point(20, 150);
            button.Click += Button_Click;

            this.Controls.Add(radioButton1);
            this.Controls.Add(radioButton2);
            this.Controls.Add(radioButton3);
            this.Controls.Add(radioButton6);
            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("你选择了选项 1");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("你选择了选项 2");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("你选择了选项 3");
            }
            else if (radioButton6.Checked)
            {
                MessageBox.Show("你选择了选项 6");
            }
            else
            {
                MessageBox.Show("没有选择任何选项");
            }
        }
    }
}