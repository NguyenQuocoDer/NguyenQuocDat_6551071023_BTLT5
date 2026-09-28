namespace QuanLyGhiChu
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void CapNhatStatusStrip()
        {
            // this.MdiChildren.Length trả về tổng số cửa sổ con đang mở
            int soLuong = this.MdiChildren.Length;

            // Gán chuỗi hiển thị lên StatusLabel
            lblSoGhiChu.Text = $"Số ghi chú đang mở: {soLuong}";
        }

        private void mnuTepMoGhiChu_Click(object sender, EventArgs e)
        {
            // 1. Tạo instance mới của FormGhiChu
            FormGhiChu frm = new FormGhiChu();

            // 2. Gán Form chính làm Form cha
            frm.MdiParent = this;

            // 3. Đăng ký sự kiện FormClosed để tự động đếm lại khi người dùng đóng form con này
            frm.FormClosed += (s, args) => this.BeginInvoke(new Action(CapNhatStatusStrip));

            // 4. Hiển thị Form con (Bắt buộc dùng Show(), KHÔNG dùng ShowDialog())
            frm.Show();

            // 5. Cập nhật ngay StatusStrip sau khi vừa mở 1 form mới
            CapNhatStatusStrip();
        }

        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(CapNhatStatusStrip));
        }

        private void mnuCuaSoXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuCuaSoXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuCuaSoXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuTepThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuTepSapXep_Click(object sender, EventArgs e)
        {

        }

        
    }
}
