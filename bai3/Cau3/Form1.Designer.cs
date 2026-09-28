namespace Cau3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            lstKetQua = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Điểm văn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 9);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Điểm toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(611, 9);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 11;
            label5.Text = "Điểm anh";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(24, 82);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu ";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(139, 82);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(60, 32);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(125, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(191, 32);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(322, 32);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(125, 27);
            txtToan.TabIndex = 2;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(453, 32);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(125, 27);
            txtVan.TabIndex = 3;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(584, 32);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(125, 27);
            txtAnh.TabIndex = 4;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(35, 149);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(709, 244);
            lstKetQua.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLuu;
        private Button btnXoaTrang;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private ListBox lstKetQua;
        private ErrorProvider errorProvider1;
    }
}
