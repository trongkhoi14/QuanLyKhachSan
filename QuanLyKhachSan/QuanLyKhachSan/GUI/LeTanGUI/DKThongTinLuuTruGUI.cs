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
    public partial class DKThongTinLuuTruGUI : Form
    {
        BindingSource dsKhachHang= new BindingSource();

        private string maPNP;
        public string MaPNP
        {
            get { return maPNP; }
            set { maPNP = value; }
        }
        [Obsolete]
        public DKThongTinLuuTruGUI(string mapdp)
        {
            InitializeComponent();
            PhieuNhanPhongBUS.Instance.LTThemPNP(mapdp);
            this.maPNP = PhieuNhanPhongBUS.Instance.LTLayMaPNP(mapdp);
            LoadData();
           
            
        }
        [Obsolete]
        #region method
        void LoadData()
        {
            HienThiDSLuuTru(maPNP);
            HienThiDSKhachHang();
        }
        [Obsolete]
        void HienThiDSLuuTru(string maPNP)
        {
            dtgvDanhSachDKLuuTru.DataSource = CTPhieuNhanPhongBUS.Instance.LTLayDSKhachHangNhanPhong(maPNP);
        }

        [Obsolete]
        void HienThiDSKhachHang()
        {
            dtgvDSKhachHang.DataSource = dsKhachHang;

            dsKhachHang.DataSource = KhachHangBUS.Instance.LTLayDanhSachKhachHang();

            txbMaKH.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "MAKH", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "TENKH", true, DataSourceUpdateMode.Never));
            txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "EMAIL", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "SODT", true, DataSourceUpdateMode.Never));
            txbSoFax.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "SOFAX", true, DataSourceUpdateMode.Never));
        }

       
        #endregion

        #region event

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txbMaKH.Text = "";
            txbHoTen.Text = "";
            txbNgaySinh.Text = "";
            txbDiaChi.Text = "";
            txbEmail.Text = "";
            txbSDT.Text = "";
            txbSoFax.Text = "";
        }

        [Obsolete]
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã điền đầy đủ thông tin hay chưa
            if(txbHoTen.Text == "" || txbNgaySinh.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui long điền đầy đủ thông tin bắc buộc");
            }    
            //Kiểm tra khách hàng này đã tồn tại hay chưa
            if(KhachHangBUS.Instance.KiemTraTonTai(txbHoTen.Text, txbNgaySinh.Text, txbDiaChi.Text))
            {
                MessageBox.Show("Khách hàng đã tồn tại");
            }
            else
            {

                MessageBox.Show("Thêm thành công");
            } 
        }
    }
}
