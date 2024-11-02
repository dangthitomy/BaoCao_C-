namespace baocao
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGoToManagement = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoToManagement
            // 
            this.btnGoToManagement.Location = new System.Drawing.Point(153, 108);
            this.btnGoToManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToManagement.Name = "btnGoToManagement";
            this.btnGoToManagement.Size = new System.Drawing.Size(216, 120);
            this.btnGoToManagement.TabIndex = 0;
            this.btnGoToManagement.Text = "Đi đến trang Quản Lý";
            this.btnGoToManagement.UseVisualStyleBackColor = true;
            this.btnGoToManagement.Click += new System.EventHandler(this.btnGoToManagement_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(107, 62);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(296, 25);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Chào mừng đến với hệ thống!";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 308);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnGoToManagement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnGoToManagement;
        private System.Windows.Forms.Label labelWelcome;
    }
}
