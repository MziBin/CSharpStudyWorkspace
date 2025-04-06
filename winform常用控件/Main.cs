using System;
using System.Windows.Forms;

namespace winform常用控件
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listviewDemo listViewDemo = new listviewDemo();
            listViewDemo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewExample dataGridViewExample = new DataGridViewExample();
            dataGridViewExample.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToolStripExample toolStripExample = new ToolStripExample();
            toolStripExample.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToolStripContainerExample toolStripContainerExample = new ToolStripContainerExample();
            toolStripContainerExample.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuStripStatusStripExample menuStripStatusStripExample = new MenuStripStatusStripExample();
            menuStripStatusStripExample.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ToolTipExample toolTipExample = new ToolTipExample();
            toolTipExample.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PropertyGridExample propertyGridExample = new PropertyGridExample();
            propertyGridExample.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RadioButtonExample radioButtonExample = new RadioButtonExample();
            radioButtonExample.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckedListBoxExample checkedListBoxExample = new CheckedListBoxExample();
            checkedListBoxExample.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            demo demo = new demo();
            demo.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CheckBoxExample checkBoxExample = new CheckBoxExample();
            checkBoxExample.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WinFormsAllControlsExample winFormsAllControlsExample = new WinFormsAllControlsExample();
            winFormsAllControlsExample.Show();
        }
    }
}
