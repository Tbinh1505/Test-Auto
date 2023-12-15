namespace GUI.Views.View_User
{
    partial class FTinhTrangChuyenBayHanhTrinhChild
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1052, 72);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(926, 32);
            label3.Name = "label3";
            label3.Size = new Size(78, 14);
            label3.TabIndex = 2;
            label3.Text = "TÌNH TRẠNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(633, 32);
            label2.Name = "label2";
            label2.Size = new Size(72, 14);
            label2.TabIndex = 1;
            label2.Text = "ĐIỂM DỪNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(201, 19);
            label1.TabIndex = 0;
            label1.Text = "THỜI GIAN KHỞI HÀNH";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(15, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1069, 516);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // FTinhTrangChuyenBayHanhTrinhChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 621);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Name = "FTinhTrangChuyenBayHanhTrinhChild";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tình trạng chuyến bay theo hành trình";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}