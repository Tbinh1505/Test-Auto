namespace GUI.Views.View_User
{
    partial class FtaikhoanNh
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Name = new TextBox();
            txt_BankNumber = new TextBox();
            btn_Add = new Guna.UI2.WinForms.Guna2Button();
            cbb_BankName = new ComboBox();
            label4 = new Label();
            lb_ErrorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 27);
            label1.Name = "label1";
            label1.Size = new Size(301, 23);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN TÀI KHOẢN NGÂN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 121);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 224);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Số tài khoản";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(148, 121);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(191, 23);
            txt_Name.TabIndex = 3;
            txt_Name.TextChanged += txt_Name_TextChanged;
            // 
            // txt_BankNumber
            // 
            txt_BankNumber.Location = new Point(148, 216);
            txt_BankNumber.Name = "txt_BankNumber";
            txt_BankNumber.Size = new Size(191, 23);
            txt_BankNumber.TabIndex = 4;
            txt_BankNumber.TextChanged += txt_BankNumber_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.BorderRadius = 10;
            btn_Add.DisabledState.BorderColor = Color.DarkGray;
            btn_Add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Add.FillColor = Color.DarkCyan;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(247, 262);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(92, 39);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "Thêm";
            btn_Add.Click += btn_Add_Click;
            // 
            // cbb_BankName
            // 
            cbb_BankName.FormattingEnabled = true;
            cbb_BankName.Location = new Point(148, 167);
            cbb_BankName.Name = "cbb_BankName";
            cbb_BankName.Size = new Size(191, 23);
            cbb_BankName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 175);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 7;
            label4.Text = "Tên ngân hàng";
            // 
            // lb_ErrorName
            // 
            lb_ErrorName.BackColor = Color.Transparent;
            lb_ErrorName.Location = new Point(148, 144);
            lb_ErrorName.Name = "lb_ErrorName";
            lb_ErrorName.Size = new Size(97, 17);
            lb_ErrorName.TabIndex = 8;
            lb_ErrorName.Text = "guna2HtmlLabel1";
            // 
            // FtaikhoanNh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 329);
            Controls.Add(lb_ErrorName);
            Controls.Add(label4);
            Controls.Add(cbb_BankName);
            Controls.Add(btn_Add);
            Controls.Add(txt_BankNumber);
            Controls.Add(txt_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FtaikhoanNh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin tài khoản ngân hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorName;
        public TextBox txt_Name;
        public TextBox txt_BankNumber;
        public Guna.UI2.WinForms.Guna2Button btn_Add;
        public ComboBox cbb_BankName;
    }
}