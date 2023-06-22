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

namespace QuanLyKhachSan.GUI.LeTanGUI
{
    public partial class CheckInGUI : Form
    {
        BindingSource dsPhieuDatPhong = new BindingSource();
        
        [Obsolete]
        public CheckInGUI()
        {
            InitializeComponent();
            HienThiDuLieu();

        }
        #region method

        [Obsolete]
        void HienThiDuLieu()
        {
            DanhSachPDP();
            DanhSachPhong();
            DanhSachDichVu();
        }
        [Obsolete]
        void DanhSachPDP()
        {
            dtgvDanhSachDP.DataSource = dsPhieuDatPhong;
            //Lấy danh sách
            dsPhieuDatPhong.DataSource = PhieuDatPhongBUS.Instance.LTLayDanhSachPDP();
            
            //Ràng buộc với textbox
            txbMaPDP.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "MAPDP", true, DataSourceUpdateMode.Never));
            txbNgayDen.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "NGAYDEN", true, DataSourceUpdateMode.Never));
            txbSoDem.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SODEMLUUTRU", true, DataSourceUpdateMode.Never));
            txbSoNguoi.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SONGUOI", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "TENKH", true, DataSourceUpdateMode.Never)); 
            txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never)); 
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "DIACHI", true, DataSourceUpdateMode.Never)); 
            txbSDT.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SODT", true, DataSourceUpdateMode.Never));

        }

        [Obsolete]
        void DanhSachPhong()
        {
            string maPDP = txbMaPDP.Text;
            dtgvPhong.DataSource = PhongBUS.Instance.LTLayDSPhongTheoPDP(maPDP); 
        }

        [Obsolete]
        void DanhSachDichVu()
        {
            string maPDP = txbMaPDP.Text;
            dtgvDichVu.DataSource = PhieuDichVuBUS.Instance.LTLayDSDichVuTheoPDP(maPDP);

        }
        #endregion

        #region event
        private void btnDangKyThongTinLuuTru_Click(object sender, EventArgs e)
        {
            DKThongTinLuuTruGUI dk = new DKThongTinLuuTruGUI(txbMaPDP.Text);
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        [Obsolete]
        private void txbMaPDP_TextChanged(object sender, EventArgs e)
        {
            DanhSachPhong();
            DanhSachDichVu();
        }
        #endregion


    }
}
