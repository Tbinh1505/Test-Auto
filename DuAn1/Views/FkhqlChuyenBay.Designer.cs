namespace GUI.Views
{
    partial class FkhqlChuyenBay
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
            label1 = new Label();
            label2 = new Label();
            dgv_InforCus = new DataGridView();
            txt_Name = new TextBox();
            txt_Gender = new TextBox();
            txt_Address = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_PhoneNumber = new TextBox();
            txt_SeatCode = new TextBox();
            label5 = new Label();
            txt_FlightCode = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_InforCus).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 24);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Giới tính";
            // 
            // dgv_InforCus
            // 
            dgv_InforCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InforCus.Location = new Point(12, 197);
            dgv_InforCus.Name = "dgv_InforCus";
            dgv_InforCus.RowTemplate.Height = 25;
            dgv_InforCus.Size = new Size(825, 282);
            dgv_InforCus.TabIndex = 3;
            dgv_InforCus.CellClick += dgv_InforCus_CellClick;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(38, 42);
            txt_Name.Multiline = true;
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(160, 34);
            txt_Name.TabIndex = 4;
            // 
            // txt_Gender
            // 
            txt_Gender.Location = new Point(289, 42);
            txt_Gender.Multiline = true;
            txt_Gender.Name = "txt_Gender";
            txt_Gender.Size = new Size(160, 34);
            txt_Gender.TabIndex = 5;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(578, 42);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(160, 55);
            txt_Address.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 24);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 100);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại";
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Location = new Point(38, 118);
            txt_PhoneNumber.Multiline = true;
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(160, 34);
            txt_PhoneNumber.TabIndex = 4;
            // 
            // txt_SeatCode
            // 
            txt_SeatCode.Location = new Point(289, 118);
            txt_SeatCode.Multiline = true;
            txt_SeatCode.Name = "txt_SeatCode";
            txt_SeatCode.Size = new Size(160, 34);
            txt_SeatCode.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 100);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Ghế ngồi";
            // 
            // txt_FlightCode
            // 
            txt_FlightCode.Location = new Point(578, 118);
            txt_FlightCode.Multiline = true;
            txt_FlightCode.Name = "txt_FlightCode";
            txt_FlightCode.Size = new Size(160, 34);
            txt_FlightCode.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 100);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Mã chuyến bay";
            // 
            // FkhqlChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 491);
            Controls.Add(txt_FlightCode);
            Controls.Add(label6);
            Controls.Add(txt_SeatCode);
            Controls.Add(label5);
            Controls.Add(txt_Address);
            Controls.Add(label4);
            Controls.Add(txt_Gender);
            Controls.Add(txt_PhoneNumber);
            Controls.Add(txt_Name);
            Controls.Add(dgv_InforCus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FkhqlChuyenBay";
            Text = "Thông tin khách hàng của chuyến bay";
            ((System.ComponentModel.ISupportInitialize)dgv_InforCus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        public DataGridView dgv_InforCus;
        public TextBox txt_Name;
        public TextBox txt_Gender;
        public TextBox txt_Address;
        public TextBox txt_PhoneNumber;
        public TextBox txt_SeatCode;
        public TextBox txt_FlightCode;
    }
}