namespace DuAn1.Views
{
    partial class FquanLyDoanhThu
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
            dgv_Revenue = new DataGridView();
            groupBox2 = new GroupBox();
            date_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            date_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btn_Export = new Guna.UI2.WinForms.Guna2Button();
            btn_fill = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Revenue).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_Revenue);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1031, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgv_Revenue
            // 
            dgv_Revenue.AllowUserToAddRows = false;
            dgv_Revenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Revenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Revenue.Location = new Point(6, 22);
            dgv_Revenue.Name = "dgv_Revenue";
            dgv_Revenue.RowTemplate.Height = 25;
            dgv_Revenue.Size = new Size(1019, 366);
            dgv_Revenue.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(date_To);
            groupBox2.Controls.Add(date_From);
            groupBox2.Controls.Add(btn_Export);
            groupBox2.Controls.Add(btn_fill);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1025, 59);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // date_To
            // 
            date_To.Checked = true;
            date_To.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_To.Format = DateTimePickerFormat.Short;
            date_To.Location = new Point(424, 17);
            date_To.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_To.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_To.Name = "date_To";
            date_To.ShowUpDown = true;
            date_To.Size = new Size(200, 36);
            date_To.TabIndex = 41;
            date_To.Value = new DateTime(2023, 7, 22, 21, 54, 15, 137);
            date_To.ValueChanged += date_To_ValueChanged;
            // 
            // date_From
            // 
            date_From.Checked = true;
            date_From.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_From.Format = DateTimePickerFormat.Short;
            date_From.Location = new Point(100, 17);
            date_From.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_From.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_From.Name = "date_From";
            date_From.ShowUpDown = true;
            date_From.Size = new Size(200, 36);
            date_From.TabIndex = 40;
            date_From.Value = new DateTime(2023, 7, 22, 21, 54, 15, 137);
            // 
            // btn_Export
            // 
            btn_Export.BorderRadius = 2;
            btn_Export.DisabledState.BorderColor = Color.DarkGray;
            btn_Export.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Export.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Export.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Export.FillColor = Color.DarkCyan;
            btn_Export.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Export.ForeColor = Color.White;
            btn_Export.Location = new Point(927, 17);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(92, 36);
            btn_Export.TabIndex = 39;
            btn_Export.Text = "Xuất";
            btn_Export.Click += btn_Export_Click;
            // 
            // btn_fill
            // 
            btn_fill.BorderRadius = 2;
            btn_fill.DisabledState.BorderColor = Color.DarkGray;
            btn_fill.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_fill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_fill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_fill.FillColor = Color.DarkCyan;
            btn_fill.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fill.ForeColor = Color.White;
            btn_fill.Location = new Point(668, 17);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(92, 36);
            btn_fill.TabIndex = 38;
            btn_fill.Text = "Lọc";
            btn_fill.Click += btn_fill_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(344, 26);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 4;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 18);
            label1.TabIndex = 3;
            label1.Text = "Từ ngày";
            // 
            // FquanLyDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FquanLyDoanhThu";
            Text = "FquanLyDoanhThu";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Revenue).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgv_Revenue;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        public Guna.UI2.WinForms.Guna2Button btn_fill;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_From;
        public Guna.UI2.WinForms.Guna2Button btn_Export;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_To;
    }
}