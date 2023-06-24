using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    public partial class fCapNhatPhieuDatPhong : Form
    {
        public fCapNhatPhieuDatPhong()
        {
            InitializeComponent();
            DsPhongDaDangKyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DsPhongDaDangKyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            NotiLabel.Text = null;
        }

        [Obsolete]
        private void fCapNhatPhieuDatPhong_Load(object sender, EventArgs e)
        {
            string maPDP = PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH);
            MaPDPTBox.Text = maPDP;
            var temp = PhieuDatPhongBUS.Instance.KHLayPDP(maPDP);
            SoDemLuuTruTBox.Text = temp.Rows[0]["SODEMLUUTRU"].ToString();
            NgayDenDateTimePicker.Value = Convert.ToDateTime(temp.Rows[0]["NGAYDEN"]);
            SoNguoiTrongDoanTBox.Text = temp.Rows[0]["SONGUOI"].ToString();

            var ptttoan = HoaDonBUS.Instance.KHRetrieveInvoice().Rows[0]["PHUONGTHUCTT"];
            if (String.Equals((string)ptttoan, "Tien mat", StringComparison.OrdinalIgnoreCase))
            {
                PhuongThucThanhToanComboBox.SelectedIndex = 0;
            }
            else if (String.Equals((string)ptttoan, "The tin dung", StringComparison.OrdinalIgnoreCase))
            {
                PhuongThucThanhToanComboBox.SelectedIndex = 1;
            }
            else
            {
                PhuongThucThanhToanComboBox.SelectedIndex = 2;
            }

            DsPhongDaDangKyDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayThongTinPhongDaDatTheoMaPDP(maPDP);
            LuuYTBox.Text = "Nếu quí khách muốn thay đổi phòng đã đặt, xin vui lòng hủy phiếu đặt phòng và đặt lại phiếu khác";
        }

        [Obsolete]
        private async void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            var newPDP = new PhieuDatPhongBUS();
            newPDP.MAPDP = PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH);
            newPDP.SODEMLUUTRU = SoDemLuuTruTBox.Text;
            newPDP.NGAYDEN = NgayDenDateTimePicker.Value;
            newPDP.SONGUOI = SoNguoiTrongDoanTBox.Text;

            var ptttoan = "";
            if (PhuongThucThanhToanComboBox.SelectedIndex == 0)
            {
                ptttoan = "Tien mat";
            }
            else if (PhuongThucThanhToanComboBox.SelectedIndex == 1)
            {
                ptttoan = "The tin dung";
            }
            else
            {
                ptttoan = "Chuyen khoan";
            }

            //kiểm tra hợp lệ
            var check = PhieuDatPhongBUS.Instance.CheckValidNewPDP(newPDP);
            if (check == 1)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui lòng điền đầy đủ thông tin";
            }
            else if (check == 2)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Số người trong đoàn không hợp lệ";
            }
            else if (check == 3)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Số đêm lưu trú không hợp lệ";
            }
            else if (check == 4)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = $"Ngày đến phải là hoặc sau ngày hiện tại: {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
            }
            else if (check == 5)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui lòng cập nhật thông tin mong muốn";
            }
            else
            {
                //cập nhật phương thức thanh toán trong hóa đơn
                HoaDonBUS.Instance.KHUpdatePTTToan(ptttoan);
                //cập nhật phiếu đặt phòng
                PhieuDatPhongBUS.Instance.KHCapNhatPDP(newPDP);
                MessageBox.Show("Cập nhật thành công\nVui lòng xem hướng dẫn thanh toán", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotiLabel.Text = null;
                fCapNhatPhieuDatPhong_Load(sender, e);
            }
        }
    }
}
