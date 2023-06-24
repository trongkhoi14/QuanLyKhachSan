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
            ThongTinDatPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayPhieuDatPhong();
            LoaiPhongDaDatDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayThongTinPhongDaDat();
        }

        [Obsolete]
        private void DaThanhToanBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quí khách muốn xóa phiếu đặt phòng gần nhất", "Notice",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                var pdp = PhieuDatPhongBUS.Instance.KHLayPhieuDatPhong();
                bool isDaDatCoc = String.Equals((string)pdp.Rows[0]["tinhtrang"], "Da coc", StringComparison.OrdinalIgnoreCase);
                //thông báo nếu đã đặt cọc
                if (isDaDatCoc)
                {
                    MessageBox.Show("Quí khách đã đặt cọc, vui lòng đến quầy lễ tân đễ được hỗ trợ nhận lại tiền cọc", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                }
            }
            else
            {

            }
        }
    }
}
