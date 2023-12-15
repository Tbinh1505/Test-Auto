namespace GUI.Views.View_User
{
    partial class FBuyTicketChild
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            groupBox6 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkCyan;
            guna2Button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(616, 22);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(217, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "PHỔ THÔNG";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Goldenrod;
            guna2Button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(836, 22);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(217, 45);
            guna2Button2.TabIndex = 4;
            guna2Button2.Text = "THƯƠNG GIA";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(guna2Button2);
            groupBox6.Controls.Add(guna2Button1);
            groupBox6.Location = new Point(21, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1064, 90);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 45);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "GIỜ KẾT THÚC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 45);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 5;
            label1.Text = "GIỜ KHỞI HÀNH";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(21, 108);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1088, 470);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // FBuyTicketChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 590);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox6);
            Name = "FBuyTicketChild";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt vé";
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label1;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}