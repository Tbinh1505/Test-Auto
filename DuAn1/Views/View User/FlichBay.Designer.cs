namespace GUI.Views.View_User
{
    partial class FlichBay
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
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            date_nkh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btn_Search = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(28, 24);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(251, 21);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "NHẬP THÔNG TIN CHUYẾN BAY";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(49, 125);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(33, 20);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Từ *";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(360, 125);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(42, 20);
            guna2HtmlLabel3.TabIndex = 2;
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
            cbb_From.Location = new Point(49, 148);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new Size(238, 36);
            cbb_From.TabIndex = 3;
            cbb_From.SelectedIndexChanged += cbb_From_SelectedIndexChanged;
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
            cbb_To.Location = new Point(360, 148);
            cbb_To.Name = "cbb_To";
            cbb_To.Size = new Size(238, 36);
            cbb_To.TabIndex = 4;
            cbb_To.SelectedIndexChanged += cbb_To_SelectedIndexChanged;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(49, 226);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(121, 20);
            guna2HtmlLabel4.TabIndex = 5;
            guna2HtmlLabel4.Text = "Ngày khởi hành *";
            // 
            // date_nkh
            // 
            date_nkh.Checked = true;
            date_nkh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_nkh.Format = DateTimePickerFormat.Short;
            date_nkh.Location = new Point(49, 264);
            date_nkh.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_nkh.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_nkh.Name = "date_nkh";
            date_nkh.ShowUpDown = true;
            date_nkh.Size = new Size(238, 36);
            date_nkh.TabIndex = 6;
            date_nkh.Value = new DateTime(2023, 7, 21, 22, 25, 38, 738);
            date_nkh.ValueChanged += date_nkh_ValueChanged;
            // 
            // btn_Search
            // 
            btn_Search.BorderColor = Color.FromArgb(123, 90, 4);
            btn_Search.BorderRadius = 10;
            btn_Search.BorderThickness = 1;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Search.FillColor = Color.Empty;
            btn_Search.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.FromArgb(123, 90, 4);
            btn_Search.Location = new Point(48, 339);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(180, 45);
            btn_Search.TabIndex = 7;
            btn_Search.Text = "TÌM KIẾM";
            btn_Search.Click += btn_Search_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_exclamation_mark_30;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(36, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(79, 67);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(273, 20);
            guna2HtmlLabel5.TabIndex = 9;
            guna2HtmlLabel5.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // lb_ErrorTo
            // 
            lb_ErrorTo.BackColor = Color.Transparent;
            lb_ErrorTo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorTo.Location = new Point(360, 190);
            lb_ErrorTo.Name = "lb_ErrorTo";
            lb_ErrorTo.Size = new Size(92, 20);
            lb_ErrorTo.TabIndex = 11;
            lb_ErrorTo.Text = "thông báo lỗi";
            // 
            // lb_ErrorFrom
            // 
            lb_ErrorFrom.BackColor = Color.Transparent;
            lb_ErrorFrom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorFrom.Location = new Point(49, 190);
            lb_ErrorFrom.Name = "lb_ErrorFrom";
            lb_ErrorFrom.Size = new Size(92, 20);
            lb_ErrorFrom.TabIndex = 10;
            lb_ErrorFrom.Text = "thông báo lỗi";
            // 
            // lb_ErrorDate
            // 
            lb_ErrorDate.BackColor = Color.Transparent;
            lb_ErrorDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorDate.Location = new Point(49, 306);
            lb_ErrorDate.Name = "lb_ErrorDate";
            lb_ErrorDate.Size = new Size(92, 20);
            lb_ErrorDate.TabIndex = 12;
            lb_ErrorDate.Text = "thông báo lỗi";
            // 
            // FlichBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 429);
            Controls.Add(lb_ErrorDate);
            Controls.Add(lb_ErrorTo);
            Controls.Add(lb_ErrorFrom);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Search);
            Controls.Add(date_nkh);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(cbb_To);
            Controls.Add(cbb_From);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Name = "FlichBay";
            Text = "Lịch bay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorDate;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_From;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_To;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_nkh;
        public Guna.UI2.WinForms.Guna2Button btn_Search;
    }
}