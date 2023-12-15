namespace DuAn1.Views
{
    partial class QlykhachHang
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
            tb_status = new TextBox();
            btn_find = new Guna.UI2.WinForms.Guna2Button();
            tb_gender = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            tb_find = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tb_phone = new TextBox();
            label5 = new Label();
            rtb_addr = new RichTextBox();
            dtp_dob = new DateTimePicker();
            tb_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgv_kh = new DataGridView();
            tb_email = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_kh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tb_status);
            groupBox1.Controls.Add(btn_find);
            groupBox1.Controls.Add(tb_gender);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_find);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_phone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rtb_addr);
            groupBox1.Controls.Add(dtp_dob);
            groupBox1.Controls.Add(tb_name);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1031, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tb_status
            // 
            tb_status.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_status.Location = new Point(440, 122);
            tb_status.Name = "tb_status";
            tb_status.ReadOnly = true;
            tb_status.Size = new Size(179, 21);
            tb_status.TabIndex = 25;
            // 
            // btn_find
            // 
            btn_find.BorderRadius = 10;
            btn_find.DisabledState.BorderColor = Color.DarkGray;
            btn_find.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_find.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_find.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_find.FillColor = Color.DarkCyan;
            btn_find.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.ForeColor = Color.White;
            btn_find.Location = new Point(648, 171);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(76, 29);
            btn_find.TabIndex = 24;
            btn_find.Text = "Tìm";
            btn_find.Click += btn_find_Click;
            // 
            // tb_gender
            // 
            tb_gender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_gender.Location = new Point(440, 31);
            tb_gender.Name = "tb_gender";
            tb_gender.ReadOnly = true;
            tb_gender.Size = new Size(179, 21);
            tb_gender.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(776, 31);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(179, 21);
            textBox3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(648, 31);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 18;
            label6.Text = "Số vé đã đặt";
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_find.Location = new Point(440, 177);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(179, 21);
            tb_find.TabIndex = 7;
            tb_find.TextChanged += tb_find_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(326, 180);
            label8.Name = "label8";
            label8.Size = new Size(71, 18);
            label8.TabIndex = 16;
            label8.Text = "Tìm kiếm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(326, 125);
            label7.Name = "label7";
            label7.Size = new Size(76, 18);
            label7.TabIndex = 12;
            label7.Text = "Trạng thái";
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_phone.Location = new Point(440, 76);
            tb_phone.Name = "tb_phone";
            tb_phone.ReadOnly = true;
            tb_phone.Size = new Size(179, 21);
            tb_phone.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(326, 79);
            label5.Name = "label5";
            label5.Size = new Size(100, 18);
            label5.TabIndex = 8;
            label5.Text = "Số điện thoại";
            // 
            // rtb_addr
            // 
            rtb_addr.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_addr.Location = new Point(104, 126);
            rtb_addr.Name = "rtb_addr";
            rtb_addr.ReadOnly = true;
            rtb_addr.Size = new Size(210, 75);
            rtb_addr.TabIndex = 3;
            rtb_addr.Text = "";
            // 
            // dtp_dob
            // 
            dtp_dob.Enabled = false;
            dtp_dob.Location = new Point(104, 77);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(210, 23);
            dtp_dob.TabIndex = 2;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(104, 31);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(210, 21);
            tb_name.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(326, 31);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 79);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgv_kh);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1031, 247);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dtgv_kh
            // 
            dtgv_kh.AllowDrop = true;
            dtgv_kh.AllowUserToAddRows = false;
            dtgv_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_kh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_kh.Location = new Point(7, 14);
            dtgv_kh.Margin = new Padding(3, 4, 3, 4);
            dtgv_kh.Name = "dtgv_kh";
            dtgv_kh.ReadOnly = true;
            dtgv_kh.RowHeadersWidth = 51;
            dtgv_kh.RowTemplate.Height = 25;
            dtgv_kh.Size = new Size(1018, 226);
            dtgv_kh.TabIndex = 0;
            dtgv_kh.CellClick += dtgv_kh_CellClick;
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_email.Location = new Point(776, 80);
            tb_email.Name = "tb_email";
            tb_email.ReadOnly = true;
            tb_email.Size = new Size(179, 21);
            tb_email.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(662, 83);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 27;
            label9.Text = "Email";
            // 
            // QlykhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QlykhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += QlykhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_kh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgv_kh;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label6;
        public TextBox tb_find;
        public TextBox tb_phone;
        public RichTextBox rtb_addr;
        public DateTimePicker dtp_dob;
        public TextBox tb_name;
        public TextBox tb_gender;
        public TextBox textBox3;
        public Guna.UI2.WinForms.Guna2Button btn_find;
        public TextBox tb_status;
        public TextBox tb_email;
        public Label label9;
    }
}