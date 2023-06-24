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
    }
}
