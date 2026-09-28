namespace bai4
{
    public partial class FormDanhBa : Form
    {
        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Không làm gì, form sẽ tự đóng
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        int _indexDangSua = -1;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                return; // Bỏ qua nếu dữ liệu rỗng
            }

            string thongTin = $"{txtTen.Text} - {txtSDT.Text}";

            if (_indexDangSua == -1)
            {
                // Thêm mới
                lstLienHe.Items.Add(thongTin);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật
                lstLienHe.Items[_indexDangSua] = thongTin;
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _indexDangSua = -1; // Trả lại trạng thái thêm mới
            }

            txtTen.Clear();
            txtSDT.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên liên hệ để đưa vào câu hỏi xác nhận
            string selectedItem = lstLienHe.SelectedItem.ToString();
            string ten = selectedItem.Split('-')[0].Trim();

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa liên hệ {ten}? Thao tác này không thể hoàn tác!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex != -1)
            {
                string selectedItem = lstLienHe.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                if (parts.Length == 2)
                {
                    txtTen.Text = parts[0].Trim();
                    txtSDT.Text = parts[1].Trim();
                    _indexDangSua = lstLienHe.SelectedIndex;
                }
            }
        }
    }
}
