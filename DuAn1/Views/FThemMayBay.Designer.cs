namespace GUI.Views
{
    partial class FThemMayBay
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
            dgv_dataPlane = new DataGridView();
            btn_add = new Guna.UI2.WinForms.Guna2Button();
            btn_update = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            txt_PlaneCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_NamePlane = new TextBox();
            cmb_totalSeats = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_dataPlane).BeginInit();
            SuspendLayout();
            // 
            // dgv_dataPlane
            // 
            dgv_dataPlane.AllowUserToAddRows = false;
            dgv_dataPlane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dataPlane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dataPlane.Location = new Point(12, 113);
            dgv_dataPlane.Name = "dgv_dataPlane";
            dgv_dataPlane.RowTemplate.Height = 25;
            dgv_dataPlane.Size = new Size(1031, 358);
            dgv_dataPlane.TabIndex = 0;
            dgv_dataPlane.CellClick += dgv_dataPlane_CellClick;
            // 
            // btn_add
            // 
            btn_add.BorderRadius = 10;
            btn_add.DisabledState.BorderColor = Color.DarkGray;
            btn_add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_add.FillColor = Color.DarkCyan;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(756, 33);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(126, 45);
            btn_add.TabIndex = 1;
            btn_add.Text = "Thêm";
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BorderRadius = 10;
            btn_update.DisabledState.BorderColor = Color.DarkGray;
            btn_update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_update.FillColor = Color.DarkCyan;
            btn_update.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(917, 33);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(126, 45);
            btn_update.TabIndex = 2;
            btn_update.Text = "Sửa";
            btn_update.Click += btn_update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã máy bay";
            // 
            // txt_PlaneCode
            // 
            txt_PlaneCode.Location = new Point(94, 42);
            txt_PlaneCode.Multiline = true;
            txt_PlaneCode.Name = "txt_PlaneCode";
            txt_PlaneCode.Size = new Size(161, 36);
            txt_PlaneCode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Tên máy bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 24);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Số ghế";
            // 
            // txt_NamePlane
            // 
            txt_NamePlane.Location = new Point(479, 42);
            txt_NamePlane.Multiline = true;
            txt_NamePlane.Name = "txt_NamePlane";
            txt_NamePlane.Size = new Size(161, 36);
            txt_NamePlane.TabIndex = 11;
            // 
            // cmb_totalSeats
            // 
            cmb_totalSeats.BackColor = Color.Transparent;
            cmb_totalSeats.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_totalSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_totalSeats.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_totalSeats.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_totalSeats.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_totalSeats.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_totalSeats.ItemHeight = 30;
            cmb_totalSeats.Location = new Point(290, 42);
            cmb_totalSeats.Name = "cmb_totalSeats";
            cmb_totalSeats.Size = new Size(161, 36);
            cmb_totalSeats.TabIndex = 12;
            // 
            // FThemMayBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(cmb_totalSeats);
            Controls.Add(txt_NamePlane);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_PlaneCode);
            Controls.Add(label1);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dgv_dataPlane);
            Name = "FThemMayBay";
            Text = "FThemMayBay";
            ((System.ComponentModel.ISupportInitialize)dgv_dataPlane).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_dataPlane;
        private Label label1;
        private Label label2;
        private Label label3;
        public Guna.UI2.WinForms.Guna2Button btn_add;
        public Guna.UI2.WinForms.Guna2Button btn_update;
        public TextBox txt_PlaneCode;
        public TextBox txt_NamePlane;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_totalSeats;
    }
}