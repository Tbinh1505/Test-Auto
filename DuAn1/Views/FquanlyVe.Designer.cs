namespace DuAn1.Views
{
    partial class FquanlyVe
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
            btn_Search = new Guna.UI2.WinForms.Guna2Button();
            cbb_DiemDi = new Guna.UI2.WinForms.Guna2ComboBox();
            date_NgayVe = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cbb_DiemDen = new Guna.UI2.WinForms.Guna2ComboBox();
            date_NgayDi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dgv_data = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(cbb_DiemDi);
            groupBox1.Controls.Add(date_NgayVe);
            groupBox1.Controls.Add(cbb_DiemDen);
            groupBox1.Controls.Add(date_NgayDi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1031, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_Search
            // 
            btn_Search.BorderRadius = 10;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Search.FillColor = Color.DarkCyan;
            btn_Search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(894, 41);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(112, 33);
            btn_Search.TabIndex = 31;
            btn_Search.Text = "Tìm";
            btn_Search.Click += btn_Search_Click;
            // 
            // cbb_DiemDi
            // 
            cbb_DiemDi.BackColor = Color.Transparent;
            cbb_DiemDi.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_DiemDi.DropDownHeight = 150;
            cbb_DiemDi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DiemDi.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_DiemDi.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_DiemDi.IntegralHeight = false;
            cbb_DiemDi.ItemHeight = 30;
            cbb_DiemDi.Location = new Point(444, 39);
            cbb_DiemDi.Name = "cbb_DiemDi";
            cbb_DiemDi.Size = new Size(200, 36);
            cbb_DiemDi.TabIndex = 28;
            // 
            // date_NgayVe
            // 
            date_NgayVe.Checked = true;
            date_NgayVe.FillColor = Color.FromArgb(224, 224, 224);
            date_NgayVe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_NgayVe.Format = DateTimePickerFormat.Long;
            date_NgayVe.Location = new Point(223, 41);
            date_NgayVe.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_NgayVe.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_NgayVe.Name = "date_NgayVe";
            date_NgayVe.Size = new Size(200, 36);
            date_NgayVe.TabIndex = 30;
            date_NgayVe.Value = new DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // cbb_DiemDen
            // 
            cbb_DiemDen.BackColor = Color.Transparent;
            cbb_DiemDen.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_DiemDen.DropDownHeight = 150;
            cbb_DiemDen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DiemDen.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDen.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_DiemDen.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_DiemDen.IntegralHeight = false;
            cbb_DiemDen.ItemHeight = 30;
            cbb_DiemDen.Location = new Point(669, 41);
            cbb_DiemDen.Name = "cbb_DiemDen";
            cbb_DiemDen.Size = new Size(200, 36);
            cbb_DiemDen.TabIndex = 29;
            // 
            // date_NgayDi
            // 
            date_NgayDi.Checked = true;
            date_NgayDi.FillColor = Color.FromArgb(224, 224, 224);
            date_NgayDi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_NgayDi.Format = DateTimePickerFormat.Long;
            date_NgayDi.Location = new Point(6, 41);
            date_NgayDi.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_NgayDi.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_NgayDi.Name = "date_NgayDi";
            date_NgayDi.Size = new Size(200, 36);
            date_NgayDi.TabIndex = 23;
            date_NgayDi.Value = new DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(669, 18);
            label9.Name = "label9";
            label9.Size = new Size(76, 18);
            label9.TabIndex = 19;
            label9.Text = "Điểm đến";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(223, 18);
            label8.Name = "label8";
            label8.Size = new Size(64, 18);
            label8.TabIndex = 17;
            label8.Text = "Ngày về";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 18);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 15;
            label7.Text = "Ngày đi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(444, 18);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 11;
            label5.Text = "Điểm đi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_data);
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1031, 360);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgv_data
            // 
            dgv_data.AllowUserToAddRows = false;
            dgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(6, 13);
            dgv_data.Name = "dgv_data";
            dgv_data.RowTemplate.Height = 25;
            dgv_data.Size = new Size(1019, 341);
            dgv_data.TabIndex = 0;
            dgv_data.CellClick += dgv_data_CellClick;
            // 
            // FquanlyVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FquanlyVe";
            Text = "FquanlyVe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        public DataGridView dgv_data;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_NgayVe;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_DiemDen;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_DiemDi;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_NgayDi;
        public Guna.UI2.WinForms.Guna2Button btn_Search;
    }
}