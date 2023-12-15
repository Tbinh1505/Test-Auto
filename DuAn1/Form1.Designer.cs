namespace DuAn1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            llb_forgot = new LinkLabel();
            cb_reme = new CheckBox();
            tb_pass = new TextBox();
            tb_user = new TextBox();
            label3 = new Label();
            label2 = new Label();
            llb_dki = new LinkLabel();
            label1 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(llb_forgot);
            panel1.Controls.Add(cb_reme);
            panel1.Controls.Add(tb_pass);
            panel1.Controls.Add(tb_user);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(llb_dki);
            panel1.Location = new Point(433, 56);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 393);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(109, 25);
            label5.Name = "label5";
            label5.Size = new Size(132, 24);
            label5.TabIndex = 12;
            label5.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = GUI.Properties.Resources.icons8_password_50;
            pictureBox3.Location = new Point(24, 166);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GUI.Properties.Resources.icons8_email_50;
            pictureBox2.Location = new Point(24, 90);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GUI.Properties.Resources.icons8_airline_50;
            pictureBox1.Location = new Point(247, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.RoyalBlue;
            btn_login.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(118, 302);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(116, 30);
            btn_login.TabIndex = 8;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // llb_forgot
            // 
            llb_forgot.AutoSize = true;
            llb_forgot.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            llb_forgot.Location = new Point(254, 256);
            llb_forgot.Name = "llb_forgot";
            llb_forgot.Size = new Size(85, 13);
            llb_forgot.TabIndex = 7;
            llb_forgot.TabStop = true;
            llb_forgot.Text = "Quên mật khẩu?";
            llb_forgot.LinkClicked += llb_forgot_LinkClicked;
            // 
            // cb_reme
            // 
            cb_reme.AutoSize = true;
            cb_reme.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cb_reme.Location = new Point(24, 253);
            cb_reme.Margin = new Padding(3, 2, 3, 2);
            cb_reme.Name = "cb_reme";
            cb_reme.Size = new Size(133, 20);
            cb_reme.TabIndex = 5;
            cb_reme.Text = "Ghi nhớ đăng nhập";
            cb_reme.UseVisualStyleBackColor = true;
            cb_reme.CheckedChanged += cb_reme_CheckedChanged;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass.Location = new Point(24, 207);
            tb_pass.Margin = new Padding(3, 2, 3, 2);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(308, 22);
            tb_pass.TabIndex = 4;
            tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            tb_user.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_user.Location = new Point(24, 130);
            tb_user.Margin = new Padding(3, 2, 3, 2);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(308, 22);
            tb_user.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(66, 167);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(66, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // llb_dki
            // 
            llb_dki.AutoSize = true;
            llb_dki.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            llb_dki.Location = new Point(203, 256);
            llb_dki.Name = "llb_dki";
            llb_dki.Size = new Size(47, 13);
            llb_dki.TabIndex = 6;
            llb_dki.TabStop = true;
            llb_dki.Text = "Đăng ký";
            llb_dki.LinkClicked += llb_dki_LinkClicked;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Image = GUI.Properties.Resources.Untitled_13;
            label1.Location = new Point(14, 179);
            label1.Name = "label1";
            label1.Size = new Size(379, 145);
            label1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(798, 9);
            label4.Name = "label4";
            label4.Size = new Size(445, 16);
            label4.TabIndex = 2;
            label4.Text = "Chào mừng bạn đến với hãng hàng không Quốc gia Việt Nam Airline";
            // 
            // Form1
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = GUI.Properties.Resources.design;
            ClientSize = new Size(802, 452);
            Controls.Add(label4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        public TextBox tb_pass;
        public TextBox tb_user;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        public Button btn_login;
        public LinkLabel llb_forgot;
        public LinkLabel llb_dki;
        public CheckBox cb_reme;
    }
    //<<<<<<< HEAD

}