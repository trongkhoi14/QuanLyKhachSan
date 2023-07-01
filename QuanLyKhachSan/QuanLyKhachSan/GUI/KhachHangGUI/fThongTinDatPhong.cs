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
    public partial class fThongTinDatPhong : Form
    {
        public fThongTinDatPhong()
        {
            InitializeComponent();
            ThongTinDatPhongDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            ThongTinDatPhongDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            LoaiPhongDaDatDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            LoaiPhongDaDatDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        [Obsolete]
        private void fThongTinDatPhong_Load(object sender, EventArgs e)
        {
            ThongTinDatPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayPhieuTatCaPDPDaDat(PhieuDatPhongBUS.MAKH);
            LoaiPhongDaDatDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayThongTinPhongDaDat(PhieuDatPhongBUS.MAKH);
        }

        [Obsolete]
        private void XoaPDPBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quí khách muốn xóa phiếu đặt phòng gần nhất", "Notice",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                var pdp = PhieuDatPhongBUS.Instance.KHLayPDPMoiNhat(PhieuDatPhongBUS.MAKH);
                bool isDaDatCoc = String.Equals((string)pdp.Rows[0]["TINHTRANG"], "Da coc", StringComparison.OrdinalIgnoreCase);
                //thông báo nếu đã đặt cọc
                if (isDaDatCoc)
                {
                    MessageBox.Show("Nếu quí khách muốn xóa phòng đã đặt cọc, vui lòng liên hệ lễ tân", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                //xóa phiếu đặt phòng gần nhất nếu chưa đặt cọc
                else
                {
                    var mapdp = (string)pdp.Rows[0]["mapdp"];
                    //xóa chi tiết pdp
                    CTPhieuDatPhongBUS.Instance.KHDeleteCtPDP(mapdp);
                    //xóa hóa đơn
                    HoaDonBUS.Instance.KHDeleteInvoice(mapdp);
                    //xóa pdp
                    PhieuDatPhongBUS.Instance.KHDeletePDP(mapdp);

                    //thông báo cho khách hàng
                    MessageBox.Show("Đã xóa phiếu đặt phòng gần nhất", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThongTinDatPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayPhieuTatCaPDPDaDat(PhieuDatPhongBUS.MAKH);
                    LoaiPhongDaDatDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayThongTinPhongDaDat(PhieuDatPhongBUS.MAKH);
                }
            }
            else
            {

            }
        }
    }
}
