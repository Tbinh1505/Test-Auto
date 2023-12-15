namespace GUI.Views.View_User
{
    partial class FthongTinNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FthongTinNguoiDung));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbx_email = new TextBox();
            tbx_hoTen = new TextBox();
            tbx_sdt = new TextBox();
            tbx_diaChi = new TextBox();
            date_bird = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btn_update = new Guna.UI2.WinForms.Guna2Button();
            btn_sua = new Guna.UI2.WinForms.Guna2Button();
            cbx_gt = new Guna.UI2.WinForms.Guna2ComboBox();
            llb_ErrorName = new Label();
            label2 = new Label();
            lb_ErrorPhone = new Label();
            lb_ErrorDate = new Label();
            lb_ErrorEmail = new Label();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(298, 29);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(210, 26);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(33, 96);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(43, 20);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Email";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(33, 194);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(95, 20);
            guna2HtmlLabel3.TabIndex = 2;
            guna2HtmlLabel3.Text = "Số điện thoại";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(610, 194);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(52, 20);
            guna2HtmlLabel4.TabIndex = 3;
            guna2HtmlLabel4.Text = "Địa chỉ";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(309, 194);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(71, 20);
            guna2HtmlLabel5.TabIndex = 4;
            guna2HtmlLabel5.Text = "Ngày sinh";
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel6.Location = new Point(610, 96);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(61, 20);
            guna2HtmlLabel6.TabIndex = 5;
            guna2HtmlLabel6.Text = "Giới tính";
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel7.Location = new Point(309, 96);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(68, 20);
            guna2HtmlLabel7.TabIndex = 6;
            guna2HtmlLabel7.Text = "Họ và tên";
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(33, 122);
            tbx_email.Multiline = true;
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(198, 36);
            tbx_email.TabIndex = 7;
            tbx_email.TextChanged += tbx_email_TextChanged;
            // 
            // tbx_hoTen
            // 
            tbx_hoTen.Location = new Point(309, 122);
            tbx_hoTen.Multiline = true;
            tbx_hoTen.Name = "tbx_hoTen";
            tbx_hoTen.Size = new Size(199, 36);
            tbx_hoTen.TabIndex = 8;
            tbx_hoTen.TextChanged += tbx_hoTen_TextChanged;
            // 
            // tbx_sdt
            // 
            tbx_sdt.Location = new Point(33, 220);
            tbx_sdt.Multiline = true;
            tbx_sdt.Name = "tbx_sdt";
            tbx_sdt.Size = new Size(198, 36);
            tbx_sdt.TabIndex = 10;
            tbx_sdt.TextChanged += tbx_sdt_TextChanged;
            // 
            // tbx_diaChi
            // 
            tbx_diaChi.Location = new Point(610, 220);
            tbx_diaChi.Multiline = true;
            tbx_diaChi.Name = "tbx_diaChi";
            tbx_diaChi.Size = new Size(187, 109);
            tbx_diaChi.TabIndex = 11;
            // 
            // date_bird
            // 
            date_bird.Checked = true;
            date_bird.FillColor = Color.FromArgb(224, 224, 224);
            date_bird.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_bird.Format = DateTimePickerFormat.Long;
            date_bird.Location = new Point(309, 220);
            date_bird.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_bird.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_bird.Name = "date_bird";
            date_bird.Size = new Size(199, 36);
            date_bird.TabIndex = 12;
            date_bird.Value = new DateTime(2023, 7, 24, 0, 4, 15, 406);
            date_bird.ValueChanged += date_bird_ValueChanged;
            // 
            // btn_update
            // 
            btn_update.BorderRadius = 10;
            btn_update.DisabledState.BorderColor = Color.DarkGray;
            btn_update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_update.FillColor = Color.DarkCyan;
            btn_update.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(309, 284);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(165, 45);
            btn_update.TabIndex = 13;
            btn_update.Text = "Cập nhật";
            btn_update.Click += btn_update_Click;
            // 
            // btn_sua
            // 
            btn_sua.BorderRadius = 10;
            btn_sua.DisabledState.BorderColor = Color.DarkGray;
            btn_sua.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_sua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_sua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_sua.FillColor = Color.DarkCyan;
            btn_sua.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.White;
            btn_sua.Location = new Point(33, 284);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(159, 45);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Sửa";
            btn_sua.Click += btn_sua_Click;
            // 
            // cbx_gt
            // 
            cbx_gt.BackColor = Color.Transparent;
            cbx_gt.DrawMode = DrawMode.OwnerDrawFixed;
            cbx_gt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_gt.FocusedColor = Color.FromArgb(94, 148, 255);
            cbx_gt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbx_gt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_gt.ForeColor = Color.FromArgb(68, 88, 112);
            cbx_gt.ItemHeight = 30;
            cbx_gt.Location = new Point(610, 122);
            cbx_gt.Name = "cbx_gt";
            cbx_gt.Size = new Size(187, 36);
            cbx_gt.TabIndex = 15;
            // 
            // llb_ErrorName
            // 
            llb_ErrorName.AutoSize = true;
            llb_ErrorName.Location = new Point(309, 161);
            llb_ErrorName.Name = "llb_ErrorName";
            llb_ErrorName.Size = new Size(38, 15);
            llb_ErrorName.TabIndex = 16;
            llb_ErrorName.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 161);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 17;
            // 
            // lb_ErrorPhone
            // 
            lb_ErrorPhone.AutoSize = true;
            lb_ErrorPhone.Location = new Point(33, 259);
            lb_ErrorPhone.Name = "lb_ErrorPhone";
            lb_ErrorPhone.Size = new Size(38, 15);
            lb_ErrorPhone.TabIndex = 18;
            lb_ErrorPhone.Text = "label3";
            // 
            // lb_ErrorDate
            // 
            lb_ErrorDate.AutoSize = true;
            lb_ErrorDate.Location = new Point(309, 259);
            lb_ErrorDate.Name = "lb_ErrorDate";
            lb_ErrorDate.Size = new Size(38, 15);
            lb_ErrorDate.TabIndex = 19;
            lb_ErrorDate.Text = "label4";
            // 
            // lb_ErrorEmail
            // 
            lb_ErrorEmail.AutoSize = true;
            lb_ErrorEmail.Location = new Point(33, 161);
            lb_ErrorEmail.Name = "lb_ErrorEmail";
            lb_ErrorEmail.Size = new Size(38, 15);
            lb_ErrorEmail.TabIndex = 20;
            lb_ErrorEmail.Text = "label5";
            // 
            // FthongTinNguoiDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 390);
            Controls.Add(lb_ErrorEmail);
            Controls.Add(lb_ErrorDate);
            Controls.Add(lb_ErrorPhone);
            Controls.Add(label2);
            Controls.Add(llb_ErrorName);
            Controls.Add(cbx_gt);
            Controls.Add(btn_sua);
            Controls.Add(btn_update);
            Controls.Add(date_bird);
            Controls.Add(tbx_diaChi);
            Controls.Add(tbx_sdt);
            Controls.Add(tbx_hoTen);
            Controls.Add(tbx_email);
            Controls.Add(guna2HtmlLabel7);
            Controls.Add(guna2HtmlLabel6);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FthongTinNguoiDung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin cá nhân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Label llb_ErrorName;
        private Label label2;
        private Label lb_ErrorPhone;
        private Label lb_ErrorDate;
        private Label lb_ErrorEmail;
        public TextBox tbx_email;
        public TextBox tbx_hoTen;
        public TextBox tbx_sdt;
        public TextBox tbx_diaChi;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_bird;
        public Guna.UI2.WinForms.Guna2Button btn_update;
        public Guna.UI2.WinForms.Guna2Button btn_sua;
        public Guna.UI2.WinForms.Guna2ComboBox cbx_gt;
    }
}