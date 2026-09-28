using System.Globalization;

namespace Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangKyEnterChuyenField();   // bước 2
            DangKySelectAll();          // bước 3
        }

        // ===== BƯỚC 2: Enter chuyển ô =====
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyPress += TextBox_KeyPress_Enter;
                }
            }
        }

        private void TextBox_KeyPress_Enter(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;   // chặn tiếng bíp

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl((Control)sender!, true, true, true, true);
                }
            }
        }

        // ===== BƯỚC 3: Enter (nhận focus) -> SelectAll =====
        private void DangKySelectAll()
        {
            txtToan.Enter += TextBox_Enter_SelectAll;
            txtVan.Enter += TextBox_Enter_SelectAll;
            txtAnh.Enter += TextBox_Enter_SelectAll;
        }

        private void TextBox_Enter_SelectAll(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender!;
            BeginInvoke(new Action(() => txt.SelectAll()));
        }

        // ===== BƯỚC 4: Lưu / Xóa trắng =====
        private bool DocDiem(TextBox txt, string tenMon, out decimal diem)
        {
            string s = txt.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(s, NumberStyles.AllowDecimalPoint,
                                  CultureInfo.InvariantCulture, out diem)
                || diem < 0m || diem > 10m)
            {
                errorProvider1.SetError(txt, "Điểm " + tenMon + " phải là số từ 0.0 đến 10.0!");
                return false;
            }

            errorProvider1.SetError(txt, "");
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            decimal toan, van, anh;

            bool okToan = DocDiem(txtToan, "Toán", out toan);
            bool okVan = DocDiem(txtVan, "Văn", out van);
            bool okAnh = DocDiem(txtAnh, "Anh", out anh);

            if (!(okToan && okVan && okAnh))
            {
                return;
            }

            lstKetQua.Items.Add(txtMaHS.Text.Trim() + " | " + txtHoTen.Text.Trim() +
                                " | T:" + toan + " V:" + van + " A:" + anh);

            XoaTrangForm();
            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            txtMaHS.Focus();
        }

        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
        }
    }
}