namespace DuAn1.Views
{
    partial class FforGotPass
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FforGotPass));
            panel1 = new Panel();
            lb_ErrorPassNew = new Label();
            lb_errorCode = new Label();
            lb_errorPass = new Label();
            lb_errorEmail = new Label();
            time = new Panel();
            label3 = new Label();
            lb_Seconds = new Label();
            lb_Minutes = new Label();
            btn_sendCode = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            tbx_pass2 = new TextBox();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            txb_pass1 = new TextBox();
            label7 = new Label();
            tbx_ma = new TextBox();
            pictureBox4 = new PictureBox();
            tbx_email = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btn_success = new Button();
            label1 = new Label();
            countDown = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lb_ErrorPassNew);
            panel1.Controls.Add(lb_errorCode);
            panel1.Controls.Add(lb_errorPass);
            panel1.Controls.Add(lb_errorEmail);
            panel1.Controls.Add(time);
            panel1.Controls.Add(btn_sendCode);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(tbx_pass2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(txb_pass1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbx_ma);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(tbx_email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_success);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(555, 131);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 509);
            panel1.TabIndex = 3;
            // 
            // lb_ErrorPassNew
            // 
            lb_ErrorPassNew.AutoSize = true;
            lb_ErrorPassNew.Location = new Point(131, 324);
            lb_ErrorPassNew.Name = "lb_ErrorPassNew";
            lb_ErrorPassNew.Size = new Size(38, 15);
            lb_ErrorPassNew.TabIndex = 41;
            lb_ErrorPassNew.Text = "label5";
            lb_ErrorPassNew.Visible = false;
            // 
            // lb_errorCode
            // 
            lb_errorCode.AutoSize = true;
            lb_errorCode.Location = new Point(129, 246);
            lb_errorCode.Name = "lb_errorCode";
            lb_errorCode.Size = new Size(38, 15);
            lb_errorCode.TabIndex = 40;
            lb_errorCode.Text = "label9";
            lb_errorCode.Visible = false;
            // 
            // lb_errorPass
            // 
            lb_errorPass.AutoSize = true;
            lb_errorPass.Location = new Point(129, 403);
            lb_errorPass.Name = "lb_errorPass";
            lb_errorPass.Size = new Size(38, 15);
            lb_errorPass.TabIndex = 39;
            lb_errorPass.Text = "label6";
            lb_errorPass.Visible = false;
            // 
            // lb_errorEmail
            // 
            lb_errorEmail.AutoSize = true;
            lb_errorEmail.Location = new Point(129, 162);
            lb_errorEmail.Name = "lb_errorEmail";
            lb_errorEmail.Size = new Size(38, 15);
            lb_errorEmail.TabIndex = 38;
            lb_errorEmail.Text = "label5";
            lb_errorEmail.Visible = false;
            // 
            // time
            // 
            time.Controls.Add(label3);
            time.Controls.Add(lb_Seconds);
            time.Controls.Add(lb_Minutes);
            time.Location = new Point(253, 215);
            time.Name = "time";
            time.Size = new Size(87, 31);
            time.TabIndex = 4;
            time.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 8);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // lb_Seconds
            // 
            lb_Seconds.AutoSize = true;
            lb_Seconds.Location = new Point(44, 9);
            lb_Seconds.Name = "lb_Seconds";
            lb_Seconds.Size = new Size(19, 15);
            lb_Seconds.TabIndex = 1;
            lb_Seconds.Text = "00";
            // 
            // lb_Minutes
            // 
            lb_Minutes.AutoSize = true;
            lb_Minutes.Location = new Point(3, 9);
            lb_Minutes.Name = "lb_Minutes";
            lb_Minutes.Size = new Size(19, 15);
            lb_Minutes.TabIndex = 0;
            lb_Minutes.Text = "00";
            // 
            // btn_sendCode
            // 
            btn_sendCode.BackColor = Color.White;
            btn_sendCode.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sendCode.ForeColor = Color.RoyalBlue;
            btn_sendCode.Location = new Point(253, 215);
            btn_sendCode.Margin = new Padding(3, 2, 3, 2);
            btn_sendCode.Name = "btn_sendCode";
            btn_sendCode.Size = new Size(79, 31);
            btn_sendCode.TabIndex = 36;
            btn_sendCode.Text = "Gửi mã";
            btn_sendCode.UseVisualStyleBackColor = false;
            btn_sendCode.Click += btn_sendCode_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = GUI.Properties.Resources.icons8_name_50;
            pictureBox2.Image = GUI.Properties.Resources.icons8_password_64;
            pictureBox2.Location = new Point(129, 187);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(174, 192);
            label2.Name = "label2";
            label2.Size = new Size(30, 18);
            label2.TabIndex = 34;
            label2.Text = "Mã";
            // 
            // pictureBox8
            // 
            pictureBox8.ErrorImage = GUI.Properties.Resources.icons8_name_50;
            pictureBox8.Image = GUI.Properties.Resources.icons8_password_50;
            pictureBox8.Location = new Point(129, 346);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 28);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 29;
            pictureBox8.TabStop = false;
            // 
            // tbx_pass2
            // 
            tbx_pass2.Location = new Point(129, 378);
            tbx_pass2.Margin = new Padding(3, 2, 3, 2);
            tbx_pass2.Name = "tbx_pass2";
            tbx_pass2.Size = new Size(200, 23);
            tbx_pass2.TabIndex = 28;
            tbx_pass2.UseSystemPasswordChar = true;
            tbx_pass2.TextChanged += tbx_pass2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(174, 351);
            label8.Name = "label8";
            label8.Size = new Size(132, 18);
            label8.TabIndex = 27;
            label8.Text = "Nhập lại mật khẩu";
            // 
            // pictureBox7
            // 
            pictureBox7.ErrorImage = GUI.Properties.Resources.icons8_name_50;
            pictureBox7.Image = GUI.Properties.Resources.icons8_password_50;
            pictureBox7.Location = new Point(129, 266);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // txb_pass1
            // 
            txb_pass1.Location = new Point(129, 298);
            txb_pass1.Margin = new Padding(3, 2, 3, 2);
            txb_pass1.Name = "txb_pass1";
            txb_pass1.Size = new Size(203, 23);
            txb_pass1.TabIndex = 25;
            txb_pass1.UseSystemPasswordChar = true;
            txb_pass1.TextChanged += txb_pass1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(171, 271);
            label7.Name = "label7";
            label7.Size = new Size(103, 18);
            label7.TabIndex = 24;
            label7.Text = "Mật khẩu mới";
            // 
            // tbx_ma
            // 
            tbx_ma.Location = new Point(129, 219);
            tbx_ma.Margin = new Padding(3, 2, 3, 2);
            tbx_ma.Name = "tbx_ma";
            tbx_ma.Size = new Size(118, 23);
            tbx_ma.TabIndex = 16;
            tbx_ma.TextChanged += tbx_ma_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = GUI.Properties.Resources.icons8_name_50;
            pictureBox4.Image = GUI.Properties.Resources.icons8_email_50;
            pictureBox4.Location = new Point(129, 105);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(129, 137);
            tbx_email.Margin = new Padding(3, 2, 3, 2);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(200, 23);
            tbx_email.TabIndex = 13;
            tbx_email.TextChanged += tbx_email_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(174, 110);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 12;
            label4.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GUI.Properties.Resources.icons8_airline_50;
            pictureBox1.Location = new Point(313, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_success
            // 
            btn_success.BackColor = Color.White;
            btn_success.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_success.ForeColor = Color.RoyalBlue;
            btn_success.Location = new Point(171, 423);
            btn_success.Margin = new Padding(3, 2, 3, 2);
            btn_success.Name = "btn_success";
            btn_success.Size = new Size(116, 30);
            btn_success.TabIndex = 8;
            btn_success.Text = "Xác nhận";
            btn_success.UseVisualStyleBackColor = false;
            btn_success.Click += btn_success_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(126, 36);
            label1.Name = "label1";
            label1.Size = new Size(181, 24);
            label1.TabIndex = 0;
            label1.Text = "QUÊN MẬT KHẨU";
            // 
            // countDown
            // 
            countDown.Tick += countDown_Tick;
            // 
            // FforGotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GUI.Properties.Resources.Rectangle_2;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FforGotPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            FormClosing += FforGotPass_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            time.ResumeLayout(false);
            time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox8;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel time;
        private Label label3;
        private Label lb_Seconds;
        private Label lb_Minutes;
        private System.Windows.Forms.Timer countDown;
        private Label lb_errorEmail;
        private Label lb_errorCode;
        private Label lb_errorPass;
        private Label lb_ErrorPassNew;
        public TextBox tbx_pass2;
        public TextBox txb_pass1;
        public TextBox tbx_ma;
        public TextBox tbx_email;
        public Button btn_success;
        public Button btn_sendCode;
    }
}