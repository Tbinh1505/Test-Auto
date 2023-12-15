namespace GUI.Views.View_User
{
    partial class FtinhTrangChuyenBay
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            date_Start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lb_ErrorNum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorTo1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorFrom1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_Search = new Guna.UI2.WinForms.Guna2Button();
            txt_CodeFlight = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(35, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(251, 21);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "NHẬP THÔNG TIN CHUYẾN BAY";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(78, 60);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(216, 17);
            guna2HtmlLabel5.TabIndex = 11;
            guna2HtmlLabel5.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_exclamation_mark_30;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(35, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 95, 110);
            guna2Button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(182, 83);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "HÀNH TRÌNH";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = SystemColors.Control;
            guna2Button2.BorderRadius = 3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(360, 83);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 13;
            guna2Button2.Text = "SỐ HIỆU CHUYẾN BAY";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(48, 138);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(24, 17);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "Từ *";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(406, 136);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(34, 17);
            guna2HtmlLabel3.TabIndex = 15;
            guna2HtmlLabel3.Text = "Đến *";
            // 
            // cbb_From
            // 
            cbb_From.BackColor = Color.Transparent;
            cbb_From.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_From.DropDownHeight = 150;
            cbb_From.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_From.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_From.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_From.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_From.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_From.IntegralHeight = false;
            cbb_From.ItemHeight = 30;
            cbb_From.Location = new Point(48, 161);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new Size(314, 36);
            cbb_From.TabIndex = 16;
            // 
            // cbb_To
            // 
            cbb_To.BackColor = Color.Transparent;
            cbb_To.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_To.DropDownHeight = 150;
            cbb_To.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_To.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_To.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_To.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_To.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_To.IntegralHeight = false;
            cbb_To.ItemHeight = 30;
            cbb_To.Location = new Point(406, 161);
            cbb_To.Name = "cbb_To";
            cbb_To.Size = new Size(314, 36);
            cbb_To.TabIndex = 17;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(48, 232);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(97, 17);
            guna2HtmlLabel4.TabIndex = 18;
            guna2HtmlLabel4.Text = "Ngày khởi hành *";
            // 
            // date_Start
            // 
            date_Start.Checked = true;
            date_Start.Cursor = Cursors.Hand;
            date_Start.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_Start.Format = DateTimePickerFormat.Custom;
            date_Start.Location = new Point(48, 255);
            date_Start.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_Start.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_Start.Name = "date_Start";
            date_Start.ShowUpDown = true;
            date_Start.Size = new Size(314, 34);
            date_Start.TabIndex = 19;
            date_Start.Value = new DateTime(2023, 7, 21, 22, 43, 43, 189);
            // 
            // lb_ErrorNum
            // 
            lb_ErrorNum.BackColor = Color.Transparent;
            lb_ErrorNum.Location = new Point(48, 204);
            lb_ErrorNum.Name = "lb_ErrorNum";
            lb_ErrorNum.Size = new Size(71, 17);
            lb_ErrorNum.TabIndex = 20;
            lb_ErrorNum.Text = "THÔNG BÁO";
            // 
            // lb_ErrorTo1
            // 
            lb_ErrorTo1.BackColor = Color.Transparent;
            lb_ErrorTo1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorTo1.Location = new Point(406, 203);
            lb_ErrorTo1.Name = "lb_ErrorTo1";
            lb_ErrorTo1.Size = new Size(73, 17);
            lb_ErrorTo1.TabIndex = 21;
            lb_ErrorTo1.Text = "THÔNG BÁO";
            // 
            // lb_ErrorDate
            // 
            lb_ErrorDate.BackColor = Color.Transparent;
            lb_ErrorDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorDate.Location = new Point(48, 295);
            lb_ErrorDate.Name = "lb_ErrorDate";
            lb_ErrorDate.Size = new Size(73, 17);
            lb_ErrorDate.TabIndex = 22;
            lb_ErrorDate.Text = "THÔNG BÁO";
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel9.Location = new Point(210, 190);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(114, 17);
            guna2HtmlLabel9.TabIndex = 24;
            guna2HtmlLabel9.Text = "Số hiệu chuyến bay*";
            // 
            // lb_ErrorFrom1
            // 
            lb_ErrorFrom1.BackColor = Color.Transparent;
            lb_ErrorFrom1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorFrom1.Location = new Point(48, 203);
            lb_ErrorFrom1.Name = "lb_ErrorFrom1";
            lb_ErrorFrom1.Size = new Size(73, 17);
            lb_ErrorFrom1.TabIndex = 25;
            lb_ErrorFrom1.Text = "THÔNG BÁO";
            // 
            // btn_Search
            // 
            btn_Search.BorderColor = Color.FromArgb(123, 90, 4);
            btn_Search.BorderRadius = 10;
            btn_Search.BorderThickness = 1;
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Search.FillColor = Color.Empty;
            btn_Search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.FromArgb(123, 90, 4);
            btn_Search.Location = new Point(496, 346);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(180, 45);
            btn_Search.TabIndex = 26;
            btn_Search.Text = "TÌM KIẾM";
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_CodeFlight
            // 
            txt_CodeFlight.Location = new Point(210, 216);
            txt_CodeFlight.Multiline = true;
            txt_CodeFlight.Name = "txt_CodeFlight";
            txt_CodeFlight.Size = new Size(314, 36);
            txt_CodeFlight.TabIndex = 27;
            // 
            // FtinhTrangChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(txt_CodeFlight);
            Controls.Add(btn_Search);
            Controls.Add(lb_ErrorFrom1);
            Controls.Add(guna2HtmlLabel9);
            Controls.Add(lb_ErrorDate);
            Controls.Add(lb_ErrorTo1);
            Controls.Add(lb_ErrorNum);
            Controls.Add(date_Start);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(cbb_To);
            Controls.Add(cbb_From);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(pictureBox1);
            Controls.Add(guna2HtmlLabel1);
            Name = "FtinhTrangChuyenBay";
            Text = "FtinhTrangChuyenBay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorTo1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorFrom1;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_From;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_To;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_Start;
        public Guna.UI2.WinForms.Guna2Button btn_Search;
        public TextBox txt_CodeFlight;
    }
}