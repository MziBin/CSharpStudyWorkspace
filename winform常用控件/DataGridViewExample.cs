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
    public partial class DataGridViewExample : Form
    {

        private DataGridView dataGridView;
        private DataGridView dataGridViewTop;

        public DataGridViewExample()
        {
            InitializeComponent();

            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Bottom;

            DataTable dataTable = new DataTable();
            //dataGridView.Columns.Add("姓名", "姓名");

            dataTable.Columns.Add("姓名",typeof(string));
            dataTable.Columns.Add("年龄", typeof(int));
            dataTable.Columns.Add("生日", typeof(int));

            dataTable.Rows.Add("王五", 30);
            dataTable.Rows.Add("赵六", 35);

            dataGridView.DataSource = dataTable;

            this.Controls.Add(dataGridView);


            dataGridViewTop = new DataGridView();
            dataGridViewTop.Dock = DockStyle.Top;

            dataGridViewTop.DataSource = dataTable;



            this.Controls.Add(dataGridViewTop);
        }
    }
}
