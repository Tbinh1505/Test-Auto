namespace DuAn1.Views
{
    partial class FQuanLyChuyenBay
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
            groupBox1 = new GroupBox();
            txb_codeflight = new TextBox();
            label3 = new Label();
            cmb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            label12 = new Label();
            label14 = new Label();
            timeEnd_minute = new Guna.UI2.WinForms.Guna2NumericUpDown();
            timeEnd_hour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label11 = new Label();
            timeStart_minute = new Guna.UI2.WinForms.Guna2NumericUpDown();
            timeStart_hour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label10 = new Label();
            label2 = new Label();
            cmb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            nbr_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btn_Update = new Guna.UI2.WinForms.Guna2Button();
            btn_Add = new Guna.UI2.WinForms.Guna2Button();
            txb_Search = new TextBox();
            label9 = new Label();
            dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cmb_PlaneType = new Guna.UI2.WinForms.Guna2ComboBox();
            cmb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            dgv_chuyenbay = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeEnd_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd_hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chuyenbay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_codeflight);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmb_status);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(timeEnd_minute);
            groupBox1.Controls.Add(timeEnd_hour);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(timeStart_minute);
            groupBox1.Controls.Add(timeStart_hour);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmb_To);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nbr_Price);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(txb_Search);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTo);
            groupBox1.Controls.Add(DateFrom);
            groupBox1.Controls.Add(cmb_PlaneType);
            groupBox1.Controls.Add(cmb_From);
            groupBox1.Controls.Add(dgv_chuyenbay);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1030, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txb_codeflight
            // 
            txb_codeflight.Location = new Point(298, 35);
            txb_codeflight.Multiline = true;
            txb_codeflight.Name = "txb_codeflight";
            txb_codeflight.Size = new Size(214, 31);
            txb_codeflight.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(298, 17);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 50;
            label3.Text = "Mã chuyến bay";
            // 
            // cmb_status
            // 
            cmb_status.BackColor = Color.Transparent;
            cmb_status.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_status.DropDownHeight = 175;
            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_status.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_status.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_status.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_status.IntegralHeight = false;
            cmb_status.ItemHeight = 30;
            cmb_status.Location = new Point(568, 154);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(211, 36);
            cmb_status.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(568, 135);
            label12.Name = "label12";
            label12.Size = new Size(76, 18);
            label12.TabIndex = 48;
            label12.Text = "Trạng thái";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(718, 30);
            label14.Name = "label14";
            label14.Size = new Size(16, 25);
            label14.TabIndex = 47;
            label14.Text = ":";
            // 
            // timeEnd_minute
            // 
            timeEnd_minute.BackColor = Color.Transparent;
            timeEnd_minute.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeEnd_minute.Location = new Point(740, 34);
            timeEnd_minute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            timeEnd_minute.Name = "timeEnd_minute";
            timeEnd_minute.Size = new Size(41, 25);
            timeEnd_minute.TabIndex = 45;
            // 
            // timeEnd_hour
            // 
            timeEnd_hour.BackColor = Color.Transparent;
            timeEnd_hour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeEnd_hour.Location = new Point(678, 34);
            timeEnd_hour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            timeEnd_hour.Name = "timeEnd_hour";
            timeEnd_hour.Size = new Size(41, 25);
            timeEnd_hour.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(609, 30);
            label11.Name = "label11";
            label11.Size = new Size(16, 25);
            label11.TabIndex = 42;
            label11.Text = ":";
            // 
            // timeStart_minute
            // 
            timeStart_minute.BackColor = Color.Transparent;
            timeStart_minute.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeStart_minute.Location = new Point(624, 34);
            timeStart_minute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            timeStart_minute.Name = "timeStart_minute";
            timeStart_minute.Size = new Size(41, 25);
            timeStart_minute.TabIndex = 37;
            // 
            // timeStart_hour
            // 
            timeStart_hour.BackColor = Color.Transparent;
            timeStart_hour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeStart_hour.Location = new Point(571, 34);
            timeStart_hour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            timeStart_hour.Name = "timeStart_hour";
            timeStart_hour.Size = new Size(41, 25);
            timeStart_hour.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(678, 12);
            label10.Name = "label10";
            label10.Size = new Size(64, 18);
            label10.TabIndex = 35;
            label10.Text = "Kết thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(570, 13);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 33;
            label2.Text = "Khởi hành";
            // 
            // cmb_To
            // 
            cmb_To.BackColor = Color.Transparent;
            cmb_To.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_To.DropDownHeight = 175;
            cmb_To.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_To.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_To.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_To.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_To.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_To.IntegralHeight = false;
            cmb_To.ItemHeight = 30;
            cmb_To.Location = new Point(300, 95);
            cmb_To.Margin = new Padding(3, 2, 3, 2);
            cmb_To.Name = "cmb_To";
            cmb_To.Size = new Size(212, 36);
            cmb_To.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(298, 78);
            label5.Name = "label5";
            label5.Size = new Size(76, 18);
            label5.TabIndex = 31;
            label5.Text = "Điểm đến";
            // 
            // nbr_Price
            // 
            nbr_Price.BackColor = Color.Transparent;
            nbr_Price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nbr_Price.Increment = new decimal(new int[] { 1000000, 0, 0, 0 });
            nbr_Price.Location = new Point(569, 96);
            nbr_Price.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            nbr_Price.Name = "nbr_Price";
            nbr_Price.Size = new Size(210, 36);
            nbr_Price.TabIndex = 30;
            nbr_Price.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // btn_Update
            // 
            btn_Update.BorderRadius = 10;
            btn_Update.DisabledState.BorderColor = Color.DarkGray;
            btn_Update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Update.FillColor = Color.DarkCyan;
            btn_Update.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(912, 78);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(112, 48);
            btn_Update.TabIndex = 29;
            btn_Update.Text = "Cập nhật trạng thái";
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.BorderRadius = 10;
            btn_Add.DisabledState.BorderColor = Color.DarkGray;
            btn_Add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Add.FillColor = Color.DarkCyan;
            btn_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(794, 78);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(112, 47);
            btn_Add.TabIndex = 28;
            btn_Add.Text = "Thêm";
            btn_Add.Click += btn_Add_Click;
            // 
            // txb_Search
            // 
            txb_Search.Location = new Point(798, 153);
            txb_Search.Margin = new Padding(3, 2, 3, 2);
            txb_Search.Multiline = true;
            txb_Search.Name = "txb_Search";
            txb_Search.Size = new Size(223, 37);
            txb_Search.TabIndex = 27;
            txb_Search.TextChanged += txb_Search_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(798, 133);
            label9.Name = "label9";
            label9.Size = new Size(71, 18);
            label9.TabIndex = 26;
            label9.Text = "Tìm kiếm";
            // 
            // dateTo
            // 
            dateTo.Checked = true;
            dateTo.FillColor = Color.FromArgb(224, 224, 224);
            dateTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTo.Format = DateTimePickerFormat.Short;
            dateTo.Location = new Point(300, 155);
            dateTo.Margin = new Padding(3, 2, 3, 2);
            dateTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTo.Name = "dateTo";
            dateTo.ShowUpDown = true;
            dateTo.Size = new Size(212, 36);
            dateTo.TabIndex = 24;
            dateTo.Value = new DateTime(2023, 7, 22, 22, 13, 14, 18);
            // 
            // DateFrom
            // 
            DateFrom.Checked = true;
            DateFrom.FillColor = Color.FromArgb(224, 224, 224);
            DateFrom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DateFrom.Format = DateTimePickerFormat.Short;
            DateFrom.Location = new Point(23, 156);
            DateFrom.Margin = new Padding(3, 2, 3, 2);
            DateFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateFrom.Name = "DateFrom";
            DateFrom.ShowUpDown = true;
            DateFrom.Size = new Size(212, 36);
            DateFrom.TabIndex = 23;
            DateFrom.Value = new DateTime(2023, 7, 22, 22, 13, 14, 18);
            // 
            // cmb_PlaneType
            // 
            cmb_PlaneType.BackColor = Color.Transparent;
            cmb_PlaneType.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_PlaneType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PlaneType.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_PlaneType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_PlaneType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_PlaneType.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_PlaneType.ItemHeight = 30;
            cmb_PlaneType.Location = new Point(26, 31);
            cmb_PlaneType.Margin = new Padding(3, 2, 3, 2);
            cmb_PlaneType.Name = "cmb_PlaneType";
            cmb_PlaneType.Size = new Size(211, 36);
            cmb_PlaneType.TabIndex = 21;
            // 
            // cmb_From
            // 
            cmb_From.BackColor = Color.Transparent;
            cmb_From.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_From.DropDownHeight = 175;
            cmb_From.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_From.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_From.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_From.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_From.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_From.IntegralHeight = false;
            cmb_From.ItemHeight = 30;
            cmb_From.Location = new Point(24, 96);
            cmb_From.Margin = new Padding(3, 2, 3, 2);
            cmb_From.Name = "cmb_From";
            cmb_From.Size = new Size(211, 36);
            cmb_From.TabIndex = 19;
            // 
            // dgv_chuyenbay
            // 
            dgv_chuyenbay.AllowUserToAddRows = false;
            dgv_chuyenbay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chuyenbay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chuyenbay.Location = new Point(4, 195);
            dgv_chuyenbay.Margin = new Padding(3, 2, 3, 2);
            dgv_chuyenbay.Name = "dgv_chuyenbay";
            dgv_chuyenbay.RowHeadersWidth = 51;
            dgv_chuyenbay.RowTemplate.Height = 25;
            dgv_chuyenbay.Size = new Size(1020, 262);
            dgv_chuyenbay.TabIndex = 0;
            dgv_chuyenbay.CellClick += dgv_chuyenbay_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(569, 75);
            label8.Name = "label8";
            label8.Size = new Size(62, 18);
            label8.TabIndex = 18;
            label8.Text = "Giá tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(298, 133);
            label7.Name = "label7";
            label7.Size = new Size(64, 18);
            label7.TabIndex = 15;
            label7.Text = "Ngày về";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 135);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 13;
            label6.Text = "Ngày đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 78);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 9;
            label4.Text = "Điểm đi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 1;
            label1.Text = "Loại máy bay";
            // 
            // FQuanLyChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 481);
            Controls.Add(groupBox1);
            Name = "FQuanLyChuyenBay";
            Text = "FQuanLyChuyenBay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeEnd_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd_hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chuyenbay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Label label9;
        private Label label5;
        private Label label10;
        private Label label2;
        private Label label14;
        private Label label11;
        private Label label12;
        private Label label3;
        public DataGridView dgv_chuyenbay;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_From;
        public Guna.UI2.WinForms.Guna2Button btn_Update;
        public Guna.UI2.WinForms.Guna2Button btn_Add;
        public Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        public Guna.UI2.WinForms.Guna2DateTimePicker DateFrom;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_PlaneType;
        public TextBox txb_Search;
        public Guna.UI2.WinForms.Guna2NumericUpDown nbr_Price;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_To;
        public Guna.UI2.WinForms.Guna2NumericUpDown timeStart_hour;
        public Guna.UI2.WinForms.Guna2NumericUpDown timeEnd_minute;
        public Guna.UI2.WinForms.Guna2NumericUpDown timeEnd_hour;
        public Guna.UI2.WinForms.Guna2NumericUpDown timeStart_minute;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        public TextBox txb_codeflight;
    }
}