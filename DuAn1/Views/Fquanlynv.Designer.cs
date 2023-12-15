namespace DuAn1
{
    partial class Fquanlynv
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
            btn_Them = new Guna.UI2.WinForms.Guna2Button();
            btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            lb_ErrorEmail = new Label();
            lb_ErrorPhone = new Label();
            lb_ErrorName = new Label();
            rbtn_off = new RadioButton();
            rbtn_onl = new RadioButton();
            label6 = new Label();
            txt_timkiem = new TextBox();
            label5 = new Label();
            txt_Pass = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_Email = new TextBox();
            txt_Sdt = new TextBox();
            label2 = new Label();
            txt_Ten = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            dgrid_NhanVien = new DataGridView();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_NhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(btn_Them);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(lb_ErrorEmail);
            groupBox1.Controls.Add(lb_ErrorPhone);
            groupBox1.Controls.Add(lb_ErrorName);
            groupBox1.Controls.Add(rbtn_off);
            groupBox1.Controls.Add(rbtn_onl);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_timkiem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_Pass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(txt_Sdt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 251);
            groupBox1.TabIndex = 1;
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
            btn_Search.Location = new Point(538, 217);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(130, 29);
            btn_Search.TabIndex = 23;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Them
            // 
            btn_Them.BorderRadius = 10;
            btn_Them.DisabledState.BorderColor = Color.DarkGray;
            btn_Them.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Them.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Them.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Them.FillColor = Color.DarkCyan;
            btn_Them.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.ForeColor = Color.White;
            btn_Them.Location = new Point(538, 150);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(130, 45);
            btn_Them.TabIndex = 22;
            btn_Them.Text = "Thêm";
            btn_Them.Click += button1_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.BorderRadius = 10;
            btn_Sua.DisabledState.BorderColor = Color.DarkGray;
            btn_Sua.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Sua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Sua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Sua.FillColor = Color.DarkCyan;
            btn_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sua.ForeColor = Color.White;
            btn_Sua.Location = new Point(374, 150);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(130, 45);
            btn_Sua.TabIndex = 21;
            btn_Sua.Text = "Cập nhật trạng thái";
            btn_Sua.Click += btn_Sua_Click;
            // 
            // lb_ErrorEmail
            // 
            lb_ErrorEmail.AutoSize = true;
            lb_ErrorEmail.Location = new Point(118, 131);
            lb_ErrorEmail.Name = "lb_ErrorEmail";
            lb_ErrorEmail.Size = new Size(38, 15);
            lb_ErrorEmail.TabIndex = 20;
            lb_ErrorEmail.Text = "label9";
            // 
            // lb_ErrorPhone
            // 
            lb_ErrorPhone.AutoSize = true;
            lb_ErrorPhone.Location = new Point(480, 62);
            lb_ErrorPhone.Name = "lb_ErrorPhone";
            lb_ErrorPhone.Size = new Size(38, 15);
            lb_ErrorPhone.TabIndex = 19;
            lb_ErrorPhone.Text = "label8";
            // 
            // lb_ErrorName
            // 
            lb_ErrorName.AutoSize = true;
            lb_ErrorName.Location = new Point(118, 62);
            lb_ErrorName.Name = "lb_ErrorName";
            lb_ErrorName.Size = new Size(38, 15);
            lb_ErrorName.TabIndex = 18;
            lb_ErrorName.Text = "label7";
            // 
            // rbtn_off
            // 
            rbtn_off.AutoSize = true;
            rbtn_off.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_off.Location = new Point(244, 164);
            rbtn_off.Margin = new Padding(3, 2, 3, 2);
            rbtn_off.Name = "rbtn_off";
            rbtn_off.Size = new Size(90, 22);
            rbtn_off.TabIndex = 17;
            rbtn_off.TabStop = true;
            rbtn_off.Text = "Nghỉ việc";
            rbtn_off.UseVisualStyleBackColor = true;
            // 
            // rbtn_onl
            // 
            rbtn_onl.AutoSize = true;
            rbtn_onl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_onl.Location = new Point(116, 163);
            rbtn_onl.Margin = new Padding(3, 2, 3, 2);
            rbtn_onl.Name = "rbtn_onl";
            rbtn_onl.Size = new Size(93, 22);
            rbtn_onl.TabIndex = 16;
            rbtn_onl.TabStop = true;
            rbtn_onl.Text = "Đang làm";
            rbtn_onl.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 225);
            label6.Name = "label6";
            label6.Size = new Size(71, 18);
            label6.TabIndex = 14;
            label6.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.AccessibleDescription = "";
            txt_timkiem.Location = new Point(116, 222);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(416, 23);
            txt_timkiem.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 166);
            label5.Name = "label5";
            label5.Size = new Size(76, 18);
            label5.TabIndex = 11;
            label5.Text = "Trạng thái";
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(480, 105);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(176, 23);
            txt_Pass.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(374, 105);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 105);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(116, 105);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(201, 23);
            txt_Email.TabIndex = 7;
            txt_Email.Click += txt_Email_TextChanged;
            txt_Email.TextChanged += txt_Email_TextChanged;
            // 
            // txt_Sdt
            // 
            txt_Sdt.Location = new Point(480, 33);
            txt_Sdt.Name = "txt_Sdt";
            txt_Sdt.Size = new Size(176, 23);
            txt_Sdt.TabIndex = 6;
            txt_Sdt.Click += txt_Sdt_TextChanged;
            txt_Sdt.TextChanged += txt_Sdt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(374, 41);
            label2.Name = "label2";
            label2.Size = new Size(100, 18);
            label2.TabIndex = 5;
            label2.Text = "Số điện thoại";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(116, 33);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(201, 23);
            txt_Ten.TabIndex = 4;
            txt_Ten.Click += txt_Ten_TextChanged;
            txt_Ten.TextChanged += txt_Ten_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 38);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 3;
            label1.Text = "Tên nhân viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgrid_NhanVien);
            groupBox4.Location = new Point(12, 260);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1031, 221);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // dgrid_NhanVien
            // 
            dgrid_NhanVien.AllowUserToAddRows = false;
            dgrid_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_NhanVien.Location = new Point(0, 22);
            dgrid_NhanVien.Name = "dgrid_NhanVien";
            dgrid_NhanVien.RowHeadersWidth = 51;
            dgrid_NhanVien.RowTemplate.Height = 25;
            dgrid_NhanVien.Size = new Size(1041, 189);
            dgrid_NhanVien.TabIndex = 0;
            dgrid_NhanVien.CellClick += dgrid_NhanVien_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = GUI.Properties.Resources.Rectangle_2;
            pictureBox1.Location = new Point(693, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 242);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Fquanlynv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "Fquanlynv";
            Text = "Fquanlynv";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_NhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private DataGridView dgrid_NhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lb_ErrorEmail;
        private Label lb_ErrorPhone;
        private Label lb_ErrorName;
        private Label label4;
        public TextBox txt_Email;
        public TextBox txt_Sdt;
        public TextBox txt_Ten;
        public TextBox txt_timkiem;
        public RadioButton rbtn_off;
        public RadioButton rbtn_onl;
        public TextBox txt_Pass;
        public Guna.UI2.WinForms.Guna2Button btn_Search;
        public Guna.UI2.WinForms.Guna2Button btn_Them;
        public Guna.UI2.WinForms.Guna2Button btn_Sua;
    }
}