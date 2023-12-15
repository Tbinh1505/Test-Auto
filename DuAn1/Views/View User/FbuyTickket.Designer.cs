namespace GUI.Views.View_User
{
    partial class FbuyTickket
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
            btn_OneWay = new Guna.UI2.WinForms.Guna2Button();
            btn_TwoWay = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            date_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_Discount = new TextBox();
            lb_ErrorTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_Search = new Guna.UI2.WinForms.Guna2Button();
            date_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox2 = new PictureBox();
            btn_discount = new Guna.UI2.WinForms.Guna2Button();
            lb_dateFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_dateTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_OneWay
            // 
            btn_OneWay.BorderRadius = 10;
            btn_OneWay.DisabledState.BorderColor = Color.DarkGray;
            btn_OneWay.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_OneWay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_OneWay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_OneWay.FillColor = Color.DarkCyan;
            btn_OneWay.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OneWay.ForeColor = Color.Black;
            btn_OneWay.Location = new Point(10, 9);
            btn_OneWay.Margin = new Padding(3, 2, 3, 2);
            btn_OneWay.Name = "btn_OneWay";
            btn_OneWay.Size = new Size(158, 47);
            btn_OneWay.TabIndex = 0;
            btn_OneWay.Text = "MỘT CHIỀU";
            btn_OneWay.Click += btn_oneWay_Click;
            // 
            // btn_TwoWay
            // 
            btn_TwoWay.BorderRadius = 10;
            btn_TwoWay.DisabledState.BorderColor = Color.DarkGray;
            btn_TwoWay.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_TwoWay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_TwoWay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_TwoWay.FillColor = Color.White;
            btn_TwoWay.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TwoWay.ForeColor = Color.Black;
            btn_TwoWay.Location = new Point(163, 9);
            btn_TwoWay.Margin = new Padding(3, 2, 3, 2);
            btn_TwoWay.Name = "btn_TwoWay";
            btn_TwoWay.Size = new Size(158, 47);
            btn_TwoWay.TabIndex = 1;
            btn_TwoWay.Text = "KHỨ HỒI";
            btn_TwoWay.Click += btn_TwoWay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_left_and_right_arrows_30;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(340, 138);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 36);
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // date_To
            // 
            date_To.Checked = true;
            date_To.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_To.Format = DateTimePickerFormat.Short;
            date_To.Location = new Point(407, 240);
            date_To.Margin = new Padding(3, 2, 3, 2);
            date_To.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_To.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_To.Name = "date_To";
            date_To.ShowUpDown = true;
            date_To.Size = new Size(276, 36);
            date_To.TabIndex = 63;
            date_To.Value = new DateTime(2023, 7, 21, 22, 1, 45, 674);
            // 
            // guna2HtmlLabel8
            // 
            guna2HtmlLabel8.BackColor = Color.Transparent;
            guna2HtmlLabel8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel8.Location = new Point(407, 217);
            guna2HtmlLabel8.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            guna2HtmlLabel8.Size = new Size(59, 20);
            guna2HtmlLabel8.TabIndex = 62;
            guna2HtmlLabel8.Text = "Ngày về";
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(58, 381);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(276, 23);
            txt_Discount.TabIndex = 61;
            // 
            // lb_ErrorTo
            // 
            lb_ErrorTo.BackColor = Color.Transparent;
            lb_ErrorTo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorTo.Location = new Point(407, 183);
            lb_ErrorTo.Name = "lb_ErrorTo";
            lb_ErrorTo.Size = new Size(106, 20);
            lb_ErrorTo.TabIndex = 59;
            lb_ErrorTo.Text = "không để trống";
            // 
            // lb_ErrorFrom
            // 
            lb_ErrorFrom.BackColor = Color.Transparent;
            lb_ErrorFrom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorFrom.Location = new Point(58, 183);
            lb_ErrorFrom.Name = "lb_ErrorFrom";
            lb_ErrorFrom.Size = new Size(106, 20);
            lb_ErrorFrom.TabIndex = 58;
            lb_ErrorFrom.Text = "không để trống";
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
            btn_Search.Location = new Point(503, 359);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(180, 45);
            btn_Search.TabIndex = 50;
            btn_Search.Text = "TÌM KIẾM";
            btn_Search.Click += btn_Search_Click;
            // 
            // date_From
            // 
            date_From.Checked = true;
            date_From.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_From.Format = DateTimePickerFormat.Short;
            date_From.Location = new Point(58, 240);
            date_From.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_From.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_From.Name = "date_From";
            date_From.ShowUpDown = true;
            date_From.Size = new Size(276, 36);
            date_From.TabIndex = 57;
            date_From.Value = new DateTime(2023, 7, 2, 22, 1, 45, 0);
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(58, 217);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(56, 20);
            guna2HtmlLabel5.TabIndex = 56;
            guna2HtmlLabel5.Text = "Ngày đi";
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
            cbb_To.Location = new Point(407, 138);
            cbb_To.Name = "cbb_To";
            cbb_To.Size = new Size(276, 36);
            cbb_To.TabIndex = 51;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(407, 115);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(42, 20);
            guna2HtmlLabel2.TabIndex = 49;
            guna2HtmlLabel2.Text = "Đến *";
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
            cbb_From.Location = new Point(58, 138);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new Size(276, 36);
            cbb_From.TabIndex = 48;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(58, 115);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(33, 20);
            guna2HtmlLabel1.TabIndex = 47;
            guna2HtmlLabel1.Text = "Từ *";
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel9.Location = new Point(58, 83);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(273, 20);
            guna2HtmlLabel9.TabIndex = 66;
            guna2HtmlLabel9.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_exclamation_mark_30;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(15, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // btn_discount
            // 
            btn_discount.BorderColor = Color.FromArgb(0, 95, 110);
            btn_discount.BorderRadius = 10;
            btn_discount.BorderThickness = 1;
            btn_discount.DisabledState.BorderColor = Color.DarkGray;
            btn_discount.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_discount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_discount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_discount.FillColor = Color.Empty;
            btn_discount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_discount.ForeColor = Color.FromArgb(0, 95, 110);
            btn_discount.Image = Properties.Resources.icons8_gift_box_401;
            btn_discount.Location = new Point(58, 368);
            btn_discount.Name = "btn_discount";
            btn_discount.Size = new Size(157, 36);
            btn_discount.TabIndex = 67;
            btn_discount.Text = "MÃ KHUYẾN MÃI";
            btn_discount.Click += btn_Discount_Click;
            // 
            // lb_dateFrom
            // 
            lb_dateFrom.BackColor = Color.Transparent;
            lb_dateFrom.Location = new Point(58, 282);
            lb_dateFrom.Name = "lb_dateFrom";
            lb_dateFrom.Size = new Size(58, 17);
            lb_dateFrom.TabIndex = 68;
            lb_dateFrom.Text = "thông báo";
            // 
            // lb_dateTo
            // 
            lb_dateTo.BackColor = Color.Transparent;
            lb_dateTo.Location = new Point(407, 282);
            lb_dateTo.Name = "lb_dateTo";
            lb_dateTo.Size = new Size(58, 17);
            lb_dateTo.TabIndex = 69;
            lb_dateTo.Text = "thông báo";
            // 
            // FbuyTickket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 429);
            Controls.Add(lb_dateTo);
            Controls.Add(lb_dateFrom);
            Controls.Add(btn_discount);
            Controls.Add(guna2HtmlLabel9);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(date_To);
            Controls.Add(guna2HtmlLabel8);
            Controls.Add(txt_Discount);
            Controls.Add(lb_ErrorTo);
            Controls.Add(lb_ErrorFrom);
            Controls.Add(btn_Search);
            Controls.Add(date_From);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(cbb_To);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(cbb_From);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btn_TwoWay);
            Controls.Add(btn_OneWay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FbuyTickket";
            Text = "Chọn loại vé";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private TextBox txt_Discount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btn_discount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_dateFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_dateTo;
        public Guna.UI2.WinForms.Guna2Button btn_OneWay;
        public Guna.UI2.WinForms.Guna2Button btn_TwoWay;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_To;
        public Guna.UI2.WinForms.Guna2Button btn_Search;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_From;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_To;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_From;
    }
}