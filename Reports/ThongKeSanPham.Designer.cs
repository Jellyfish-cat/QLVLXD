namespace WinFormsApp1.Reports
{
    partial class ThongKeSanPham
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
            label3 = new Label();
            cboHangSanXuat = new ComboBox();
            cboSanPham = new ComboBox();
            CboDanhMuc = new ComboBox();
            btnLoc = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Hãng Sản Xuất";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(350, 31);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Sản Phẩm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(643, 31);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "Danh Mục";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Anchor = AnchorStyles.Top;
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(136, 28);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(196, 28);
            cboHangSanXuat.TabIndex = 1;
            cboHangSanXuat.SelectedIndexChanged += cboHangSanXuat_SelectedIndexChanged;
            // 
            // cboSanPham
            // 
            cboSanPham.Anchor = AnchorStyles.Top;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(430, 28);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(196, 28);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // CboDanhMuc
            // 
            CboDanhMuc.Anchor = AnchorStyles.Top;
            CboDanhMuc.FormattingEnabled = true;
            CboDanhMuc.Location = new Point(737, 28);
            CboDanhMuc.Name = "CboDanhMuc";
            CboDanhMuc.Size = new Size(196, 28);
            CboDanhMuc.TabIndex = 1;
            CboDanhMuc.SelectedIndexChanged += CboDanhMuc_SelectedIndexChanged;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Top;
            btnLoc.Location = new Point(953, 20);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(78, 43);
            btnLoc.TabIndex = 2;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.Location = new Point(1037, 20);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(78, 43);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // ThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLoc);
            Controls.Add(CboDanhMuc);
            Controls.Add(cboSanPham);
            Controls.Add(cboHangSanXuat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Sản Phẩm";
            WindowState = FormWindowState.Maximized;
            Load += ThongKeSanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboHangSanXuat;
        private ComboBox cboSanPham;
        private ComboBox CboDanhMuc;
        private Button btnLoc;
        private Button btnHuy;
    }
}