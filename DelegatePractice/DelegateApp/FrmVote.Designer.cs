namespace DelegateApp
{
    partial class FrmVote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVote));
            this.btnVote3 = new System.Windows.Forms.Button();
            this.btnVote2 = new System.Windows.Forms.Button();
            this.btnVote1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVote3
            // 
            this.btnVote3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(124)))), ((int)(((byte)(212)))));
            this.btnVote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVote3.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVote3.ForeColor = System.Drawing.Color.White;
            this.btnVote3.Location = new System.Drawing.Point(212, 33);
            this.btnVote3.Name = "btnVote3";
            this.btnVote3.Size = new System.Drawing.Size(75, 84);
            this.btnVote3.TabIndex = 4;
            this.btnVote3.Tag = "3";
            this.btnVote3.Text = "3";
            this.btnVote3.UseVisualStyleBackColor = false;
            // 
            // btnVote2
            // 
            this.btnVote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(124)))), ((int)(((byte)(212)))));
            this.btnVote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVote2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVote2.ForeColor = System.Drawing.Color.White;
            this.btnVote2.Location = new System.Drawing.Point(116, 33);
            this.btnVote2.Name = "btnVote2";
            this.btnVote2.Size = new System.Drawing.Size(75, 84);
            this.btnVote2.TabIndex = 5;
            this.btnVote2.Tag = "2";
            this.btnVote2.Text = "2";
            this.btnVote2.UseVisualStyleBackColor = false;
            // 
            // btnVote1
            // 
            this.btnVote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(124)))), ((int)(((byte)(212)))));
            this.btnVote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVote1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVote1.ForeColor = System.Drawing.Color.White;
            this.btnVote1.Location = new System.Drawing.Point(24, 33);
            this.btnVote1.Name = "btnVote1";
            this.btnVote1.Size = new System.Drawing.Size(75, 84);
            this.btnVote1.TabIndex = 6;
            this.btnVote1.Tag = "1";
            this.btnVote1.Text = "1";
            this.btnVote1.UseVisualStyleBackColor = false;
            
            // 
            // FrmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 151);
            this.Controls.Add(this.btnVote3);
            this.Controls.Add(this.btnVote2);
            this.Controls.Add(this.btnVote1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "投票器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVote3;
        private System.Windows.Forms.Button btnVote2;
        private System.Windows.Forms.Button btnVote1;
    }
}