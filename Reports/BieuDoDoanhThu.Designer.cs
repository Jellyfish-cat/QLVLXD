namespace WinFormsApp1.Reports
{
    partial class BieuDoDoanhThu
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
            radngay = new RadioButton();
            radthang = new RadioButton();
            radNam = new RadioButton();
            SuspendLayout();
            // 
            // radngay
            // 
            radngay.Anchor = AnchorStyles.Top;
            radngay.AutoSize = true;
            radngay.Location = new Point(271, 24);
            radngay.Name = "radngay";
            radngay.Size = new Size(65, 24);
            radngay.TabIndex = 0;
            radngay.Text = "Ngày";
            radngay.UseVisualStyleBackColor = true;
            radngay.CheckedChanged += radngay_CheckedChanged;
            // 
            // radthang
            // 
            radthang.Anchor = AnchorStyles.Top;
            radthang.AutoSize = true;
            radthang.Location = new Point(366, 24);
            radthang.Name = "radthang";
            radthang.Size = new Size(71, 24);
            radthang.TabIndex = 0;
            radthang.Text = "Tháng";
            radthang.UseVisualStyleBackColor = true;
            radthang.CheckedChanged += radthang_CheckedChanged;
            // 
            // radNam
            // 
            radNam.Anchor = AnchorStyles.Top;
            radNam.AutoSize = true;
            radNam.Location = new Point(467, 24);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 0;
            radNam.Text = "Năm";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += radNam_CheckedChanged;
            // 
            // BieuDoDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radNam);
            Controls.Add(radthang);
            Controls.Add(radngay);
            Name = "BieuDoDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BieuDoDoanhThu";
            WindowState = FormWindowState.Maximized;
            Load += BieuDoDoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radngay;
        private RadioButton radthang;
        private RadioButton radNam;
    }
}