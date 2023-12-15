namespace DuAn1.Views
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_addPlane = new Button();
            btn_qlykh = new Button();
            btn_qlyflight = new Button();
            btn_qlyve = new Button();
            btn_dthu = new Button();
            btn_qlynv = new Button();
            pn_chil = new Panel();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            hệThốngToolStripMenuItem1 = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem1 = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1277, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_addPlane);
            panel1.Controls.Add(btn_qlykh);
            panel1.Controls.Add(btn_qlyflight);
            panel1.Controls.Add(btn_qlyve);
            panel1.Controls.Add(btn_dthu);
            panel1.Controls.Add(btn_qlynv);
            panel1.Location = new Point(3, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 522);
            panel1.TabIndex = 1;
            // 
            // btn_addPlane
            // 
            btn_addPlane.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addPlane.Location = new Point(2, 377);
            btn_addPlane.Name = "btn_addPlane";
            btn_addPlane.Size = new Size(193, 48);
            btn_addPlane.TabIndex = 8;
            btn_addPlane.Text = "Thêm máy bay";
            btn_addPlane.UseVisualStyleBackColor = true;
            btn_addPlane.Click += btn_addPlane_Click;
            // 
            // btn_qlykh
            // 
            btn_qlykh.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_qlykh.Location = new Point(1, 293);
            btn_qlykh.Name = "btn_qlykh";
            btn_qlykh.Size = new Size(194, 48);
            btn_qlykh.TabIndex = 7;
            btn_qlykh.Text = "Quản lý khách hàng";
            btn_qlykh.UseVisualStyleBackColor = true;
            btn_qlykh.Click += btn_qlykh_Click;
            // 
            // btn_qlyflight
            // 
            btn_qlyflight.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_qlyflight.Location = new Point(1, 200);
            btn_qlyflight.Name = "btn_qlyflight";
            btn_qlyflight.Size = new Size(194, 48);
            btn_qlyflight.TabIndex = 6;
            btn_qlyflight.Text = "Quản lý chuyến bay";
            btn_qlyflight.UseVisualStyleBackColor = true;
            btn_qlyflight.Click += btn_qlyflight_Click;
            // 
            // btn_qlyve
            // 
            btn_qlyve.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_qlyve.Location = new Point(2, 108);
            btn_qlyve.Name = "btn_qlyve";
            btn_qlyve.Size = new Size(194, 48);
            btn_qlyve.TabIndex = 5;
            btn_qlyve.Text = "Quản lý vé";
            btn_qlyve.UseVisualStyleBackColor = true;
            btn_qlyve.Click += btn_qlyve_Click;
            // 
            // btn_dthu
            // 
            btn_dthu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dthu.Location = new Point(1, 465);
            btn_dthu.Name = "btn_dthu";
            btn_dthu.Size = new Size(194, 48);
            btn_dthu.TabIndex = 1;
            btn_dthu.Text = "Quản lý doanh thu";
            btn_dthu.UseVisualStyleBackColor = true;
            btn_dthu.Click += btn_dthu_Click;
            // 
            // btn_qlynv
            // 
            btn_qlynv.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_qlynv.ForeColor = SystemColors.ControlText;
            btn_qlynv.Location = new Point(2, 19);
            btn_qlynv.Name = "btn_qlynv";
            btn_qlynv.Size = new Size(194, 48);
            btn_qlynv.TabIndex = 0;
            btn_qlynv.Text = "Quản lý nhân viên";
            btn_qlynv.UseVisualStyleBackColor = true;
            btn_qlynv.Click += btn_qlynv_Click;
            // 
            // pn_chil
            // 
            pn_chil.Location = new Point(209, 186);
            pn_chil.Name = "pn_chil";
            pn_chil.Size = new Size(1071, 522);
            pn_chil.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1284, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(145, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(145, 22);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1284, 26);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem1
            // 
            hệThốngToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem1, đăngXuấtToolStripMenuItem1 });
            hệThốngToolStripMenuItem1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            hệThốngToolStripMenuItem1.Size = new Size(82, 22);
            hệThốngToolStripMenuItem1.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            đổiMậtKhẩuToolStripMenuItem1.Size = new Size(180, 22);
            đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem1.Click += đổiMậtKhẩuToolStripMenuItem1_Click;
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            đăngXuấtToolStripMenuItem1.Size = new Size(180, 22);
            đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem1.Click += đăngXuấtToolStripMenuItem1_Click_1;
            // 
            // fStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 712);
            Controls.Add(pn_chil);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip2;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao diện các chức năng";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel pn_chil;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private MenuStrip menuStrip2;
        public Button btn_dthu;
        public Button btn_qlynv;
        public Button btn_qlykh;
        public Button btn_qlyflight;
        public Button btn_qlyve;
        public Button btn_addPlane;
        public ToolStripMenuItem hệThốngToolStripMenuItem1;
        public ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
        public ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}