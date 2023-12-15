namespace GUI.Views.View_User
{
    partial class FthanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FthanhToan));
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            btn_acp = new Guna.UI2.WinForms.Guna2Button();
            btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(153, 285);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Tôi đã thanh toán";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_acp
            // 
            btn_acp.BorderRadius = 10;
            btn_acp.DisabledState.BorderColor = Color.DarkGray;
            btn_acp.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_acp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_acp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_acp.FillColor = Color.DarkCyan;
            btn_acp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_acp.ForeColor = Color.White;
            btn_acp.Location = new Point(153, 328);
            btn_acp.Name = "btn_acp";
            btn_acp.Size = new Size(180, 45);
            btn_acp.TabIndex = 2;
            btn_acp.Text = "Xác nhận";
            btn_acp.Click += btn_acp_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BorderRadius = 10;
            btn_cancel.DisabledState.BorderColor = Color.DarkGray;
            btn_cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_cancel.FillColor = Color.DarkCyan;
            btn_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(153, 393);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(180, 45);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Hủy";
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 250);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FthanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(label1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_acp);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Name = "FthanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        public CheckBox checkBox1;
        public Guna.UI2.WinForms.Guna2Button btn_acp;
        public Guna.UI2.WinForms.Guna2Button btn_cancel;
    }
}