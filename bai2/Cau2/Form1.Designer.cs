namespace Cau2
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
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayTra = new TextBox();
            txtNgayNhan = new TextBox();
            txtSoTreEm = new TextBox();
            txtSoNguoiLon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(248, 66);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(300, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(248, 122);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(300, 27);
            txtCCCD.TabIndex = 1;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(248, 247);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(300, 27);
            txtNgayTra.TabIndex = 3;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(248, 191);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(300, 27);
            txtNgayNhan.TabIndex = 2;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(248, 363);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(300, 27);
            txtSoTreEm.TabIndex = 5;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(248, 307);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(300, 27);
            txtSoNguoiLon.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 99);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 168);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 8;
            label3.Text = "Ngày nhận đặt phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 224);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 284);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 10;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 340);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 11;
            label6.Text = "Số trẻ em";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = SystemColors.ActiveCaption;
            btnDatPhong.Location = new Point(248, 423);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(300, 33);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(btnDatPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Đăng ký phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayTra;
        private TextBox txtNgayNhan;
        private TextBox txtSoTreEm;
        private TextBox txtSoNguoiLon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
