using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudyStudyWorkspace
{
    internal class TestMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestMain
            // 
            this.ClientSize = new System.Drawing.Size(1482, 738);
            this.Controls.Add(this.button1);
            this.Name = "TestMain";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
