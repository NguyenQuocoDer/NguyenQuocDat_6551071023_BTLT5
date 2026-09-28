namespace QuanLyGhiChu
{
    partial class FormGhiChu
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
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTieuDeForm = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(147, 65);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(364, 27);
            txtTieuDe.TabIndex = 0;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // txtNoiDung
            // 
            txtNoiDung.AcceptsReturn = true;
            txtNoiDung.Location = new Point(61, 135);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(476, 97);
            txtNoiDung.TabIndex = 1;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(61, 274);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(101, 28);
            cboMucDoUuTien.TabIndex = 2;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(417, 274);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(94, 29);
            btnLuuGhiChu.TabIndex = 3;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 65);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 112);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Nội dung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 251);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Độ ưu tiên";
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.BackColor = Color.FromArgb(192, 255, 255);
            lblTieuDeForm.Dock = DockStyle.Top;
            lblTieuDeForm.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDeForm.Location = new Point(0, 0);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(621, 39);
            lblTieuDeForm.TabIndex = 5;
            lblTieuDeForm.Text = "CHI TIẾT GHI CHÚ";
            lblTieuDeForm.TextAlign = ContentAlignment.TopCenter;
            lblTieuDeForm.Click += lblTieuDeForm_Click;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(621, 336);
            Controls.Add(lblTieuDeForm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTieuDeForm;
        private ErrorProvider errorProvider1;
    }
}