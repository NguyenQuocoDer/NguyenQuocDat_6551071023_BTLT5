using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyGhiChu
{
    public partial class FormGhiChu : Form
    {
        private bool isModified = false;

        private Color mauNenGoc = Color.White;
        public FormGhiChu()
        {
            InitializeComponent();


        }
        // Yêu cầu 2.1
        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick(); // Kích hoạt sự kiện Click của nút Lưu
                e.SuppressKeyPress = true;  // Tắt tiếng "bíp" mặc định của Windows
            }
            else if (e.Control && e.KeyCode == Keys.Escape)
            {
                if (isModified)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu ghi chú trước khi đóng không?", "Xác nhận",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        btnLuuGhiChu.PerformClick(); // Kích hoạt sự kiện Click của nút Lưu
                        this.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
        }

        // Yêu cầu 2.2
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào
            }
        }


        // Yêu cầu 2.3
        private void lblTieuDeForm_Click(object sender, EventArgs e)
        {

        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = mauNenGoc;

        }

        // Yêu cầu 2.5
        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            this.Text = txtTieuDe.Text; // Đổi tiêu đề cửa sổ con thành nội dung tiêu đề vừa nhập
            MessageBox.Show("Đã lưu ghi chú thành công!");
            isModified = false;
        }

        // yếu cầu 3.1
        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if(txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được vượt quá 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }
    }

}
