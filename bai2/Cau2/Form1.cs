using System.ComponentModel;
using System.Globalization;

namespace Cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtHoTen.Validating += txtHoTen_Validating;
            txtCCCD.Validating += txtCCCD_Validating;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoTreEm.Validating += txtSoTreEm_Validating;

            txtHoTen.Validated += txtHoTen_Validated;
            txtCCCD.Validated += txtHoTen_Validated;
            txtNgayNhan.Validated += txtHoTen_Validated;
            txtNgayTra.Validated += txtHoTen_Validated;
            txtSoNguoiLon.Validated += txtHoTen_Validated;
            txtSoTreEm.Validated += txtHoTen_Validated;
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            bool toanSo = true;
            foreach (char c in cccd)
            {
                if (!char.IsDigit(c))
                {
                    toanSo = false;
                    break;
                }
            }

            if (cccd.Length != 12 || !toanSo)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "CCCD phải gồm đúng 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            if (!DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải đúng định dạng dd/MM/yyyy!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải từ hôm nay trở đi!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayTra;
            if (!DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTra))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải đúng định dạng dd/MM/yyyy!");
                txtNgayTra.BackColor = Color.MistyRose;
                return;
            }

            DateTime ngayNhan;
            bool nhanHopLe = DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhan);

            if (!nhanHopLe || ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải lớn hơn ngày nhận!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Honeydew;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Ép kiểm tra lại toàn bộ ô trước khi đặt phòng
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy",
                                    CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy",
                                    CultureInfo.InvariantCulture);

            int soDem = (ngayTra - ngayNhan).Days;
            int soNguoiLon = int.Parse(txtSoNguoiLon.Text.Trim());
            int soTreEm = int.Parse(txtSoTreEm.Text.Trim());

            string thongBao = "Đặt phòng thành công!\n\n" +
                              "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
                              "Số đêm: " + soDem + "\n" +
                              "Số người lớn: " + soNguoiLon + "\n" +
                              "Số trẻ em: " + soTreEm;

            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
