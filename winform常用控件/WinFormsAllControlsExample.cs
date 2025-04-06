using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace winform常用控件
{


    public partial class WinFormsAllControlsExample : Form
    {
        private Button button;
        private TextBox textBox;
        private Label label;
        private ComboBox comboBox;
        private CheckBox checkBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox listBox;
        private DataGridView dataGridView;
        private ProgressBar progressBar;
        private MenuStrip menuStrip;
        private StatusStrip statusStrip;
        private ToolStrip toolStrip;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;

        public WinFormsAllControlsExample()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // 按钮
            button = new Button();
            button.Text = "点击我";
            button.Location = new Point(50, 20);
            button.Click += Button_Click;
            this.Controls.Add(button);

            // 文本框
            textBox = new TextBox();
            textBox.Location = new Point(20, 60);
            this.Controls.Add(textBox);

            // 标签
            label = new Label();
            label.Text = "这是一个标签";
            label.Location = new Point(20, 100);
            this.Controls.Add(label);

            // 下拉框
            comboBox = new ComboBox();
            comboBox.Items.Add("选项1");
            comboBox.Items.Add("选项2");
            comboBox.Items.Add("选项3");
            comboBox.Location = new Point(90, 140);
            this.Controls.Add(comboBox);

            // 复选框
            checkBox = new CheckBox();
            checkBox.Text = "选中我";
            checkBox.Location = new Point(20, 180);
            this.Controls.Add(checkBox);

            // 单选框
            radioButton1 = new RadioButton();
            radioButton1.Text = "单选1";
            radioButton1.Location = new Point(20, 220);
            this.Controls.Add(radioButton1);

            radioButton2 = new RadioButton();
            radioButton2.Text = "单选2";
            radioButton2.Location = new Point(120, 220);
            this.Controls.Add(radioButton2);

            // 列表框
            listBox = new ListBox();
            listBox.Items.Add("列表项1");
            listBox.Items.Add("列表项2");
            listBox.Items.Add("列表项3");
            listBox.Location = new Point(150, 260);
            this.Controls.Add(listBox);

            // 数据网格视图
            dataGridView = new DataGridView();
            dataGridView.Location = new Point(20, 320);
            dataGridView.Size = new Size(400, 200);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("列1", typeof(string));
            dataTable.Columns.Add("列2", typeof(int));
            dataTable.Rows.Add("数据1", 1);
            dataTable.Rows.Add("数据2", 2);
            dataGridView.DataSource = dataTable;
            this.Controls.Add(dataGridView);

            // 进度条
            progressBar = new ProgressBar();
            progressBar.Location = new Point(20, 540);
            progressBar.Size = new Size(400, 20);
            progressBar.Value = 50;
            this.Controls.Add(progressBar);

            // 菜单条
            menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("文件");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("退出");
            exitMenuItem.Click += ExitMenuItem_Click;
            fileMenuItem.DropDownItems.Add(exitMenuItem);
            menuStrip.Items.Add(fileMenuItem);
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;

            // 状态条
            statusStrip = new StatusStrip();
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel();
            statusLabel.Text = "就绪";
            statusStrip.Items.Add(statusLabel);
            this.Controls.Add(statusStrip);
            statusStrip.Dock = DockStyle.Bottom;

            // 工具条
            toolStrip = new ToolStrip();
            ToolStripButton toolStripButton = new ToolStripButton("工具按钮");
            toolStripButton.Click += ToolStripButton_Click;
            toolStrip.Items.Add(toolStripButton);
            this.Controls.Add(toolStrip);
            toolStrip.Dock = DockStyle.Top;

            // 颜色对话框
            colorDialog = new ColorDialog();

            // 字体对话框
            fontDialog = new FontDialog();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                label.ForeColor = colorDialog.Color;
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label.Font = fontDialog.Font;
            }
        }
    }
}