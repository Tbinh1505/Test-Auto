namespace GUI.Views
{
    partial class FthongTinKh
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
            txt_Email = new TextBox();
            txt_seat = new TextBox();
            txt_address = new TextBox();
            txt_phonenumber = new TextBox();
            txt_gender = new TextBox();
            txt_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_CodeFlight = new TextBox();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(78, 127);
            txt_Email.Multiline = true;
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(163, 35);
            txt_Email.TabIndex = 1;
            txt_Email.Text = "Ho ten";
            // 
            // txt_seat
            // 
            txt_seat.Location = new Point(424, 48);
            txt_seat.Multiline = true;
            txt_seat.Name = "txt_seat";
            txt_seat.Size = new Size(163, 35);
            txt_seat.TabIndex = 2;
            txt_seat.Text = "Ghe ngoi";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(78, 202);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(163, 83);
            txt_address.TabIndex = 3;
            txt_address.Text = "dia chi";
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.Location = new Point(424, 202);
            txt_phonenumber.Multiline = true;
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(163, 35);
            txt_phonenumber.TabIndex = 4;
            txt_phonenumber.Text = "sdt";
            // 
            // txt_gender
            // 
            txt_gender.Location = new Point(424, 127);
            txt_gender.Multiline = true;
            txt_gender.Name = "txt_gender";
            txt_gender.Size = new Size(163, 35);
            txt_gender.TabIndex = 5;
            txt_gender.Text = "gioi tinh";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(78, 48);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(163, 35);
            txt_name.TabIndex = 6;
            txt_name.Text = "Ho ten";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 109);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Ghế ngồi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 109);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 184);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 184);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 30);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "Họ tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 250);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 14;
            label7.Text = "Mã chuyến bay";
            // 
            // txt_CodeFlight
            // 
            txt_CodeFlight.Location = new Point(421, 268);
            txt_CodeFlight.Multiline = true;
            txt_CodeFlight.Name = "txt_CodeFlight";
            txt_CodeFlight.Size = new Size(163, 35);
            txt_CodeFlight.TabIndex = 13;
            txt_CodeFlight.Text = "Ma chuyen bay";
            // 
            // FthongTinKh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 350);
            Controls.Add(label7);
            Controls.Add(txt_CodeFlight);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(txt_gender);
            Controls.Add(txt_phonenumber);
            Controls.Add(txt_address);
            Controls.Add(txt_seat);
            Controls.Add(txt_Email);
            Name = "FthongTinKh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin khách hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txt_Email;
        public TextBox txt_seat;
        public TextBox txt_address;
        public TextBox txt_phonenumber;
        public TextBox txt_gender;
        public TextBox txt_name;
        public TextBox txt_CodeFlight;
    }
}