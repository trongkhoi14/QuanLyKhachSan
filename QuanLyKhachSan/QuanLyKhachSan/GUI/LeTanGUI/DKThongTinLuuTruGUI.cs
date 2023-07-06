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
            //dtgvDanhSachDKLuuTru.DataSource = CTPhieuNhanPhongBUS.Instance.LTLayDSKhachHangNhanPhong(maPNP);

            DataTable dsLuuTru = CTPhieuNhanPhongBUS.Instance.LTLayDSKhachHangNhanPhong(maPNP);
            lvDSLuuTru.Items.Clear();
            foreach (DataRow row in dsLuuTru.Rows)
            {
                ListViewItem item = new ListViewItem(row["TENKH"].ToString());
                item.SubItems.Add(DateTime.Parse(row["NGAYSINH"].ToString()).ToString("dd/MM/yyyy"));
                item.SubItems.Add(row["DIACHI"].ToString());
                item.SubItems.Add(row["EMAIL"].ToString());
                item.SubItems.Add(row["SODT"].ToString());
                item.SubItems.Add(row["SOFAX"].ToString());

                lvDSLuuTru.Items.Add(item);


            }
            foreach (ColumnHeader column in lvDSLuuTru.Columns)
            {
                column.Width = (lvDSLuuTru.Width - 6) / 6;
                column.AutoResize(ColumnHeaderAutoResizeStyle.None);
            }
        }

        [Obsolete]
        void HienThiDSKhachHang()
        {
            dtgvDSKhachHang.DataSource = dsKhachHang;

            dsKhachHang.DataSource = KhachHangBUS.Instance.LTLayDanhSachKhachHang();

            AddBingding();
        }
        void AddBingding()
        {
            txbMaKH.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "MAKH", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "TENKH", true, DataSourceUpdateMode.Never));
            txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "EMAIL", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "SODT", true, DataSourceUpdateMode.Never));
            txbSoFax.DataBindings.Add(new Binding("Text", dtgvDSKhachHang.DataSource, "SOFAX", true, DataSourceUpdateMode.Never));
        }
        void ClearBinding()
        {
            txbMaKH.DataBindings.Clear();
            txbHoTen.DataBindings.Clear();
            txbNgaySinh.DataBindings.Clear();
            txbDiaChi.DataBindings.Clear();
            txbEmail.DataBindings.Clear();
            txbSDT.DataBindings.Clear();
            txbSoFax.DataBindings.Clear();
        }
       
        #endregion

        #region event

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            if (txbHoTen.Text == "" || txbNgaySinh.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui long điền đầy đủ thông tin bắc buộc");
            }
            else
            {
                //Kiểm tra khách hàng này đã tồn tại hay chưa
                if (KhachHangBUS.Instance.KiemTraTonTai(txbHoTen.Text, txbNgaySinh.Text, txbDiaChi.Text))
                {
                    MessageBox.Show("Khách hàng đã tồn tại");
                }
                else
                {
                    if (KhachHangBUS.Instance.LTThemKhachHang(txbHoTen.Text, txbNgaySinh.Text, txbDiaChi.Text, txbEmail.Text,
                        txbSDT.Text, txbSoFax.Text))
                    {
                        MessageBox.Show("Thêm thành công");
                        ClearBinding();
                        HienThiDSKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }

                }
            }

        }

        [Obsolete]
        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã điền đầy đủ thông tin hay chưa
            if (txbHoTen.Text == "" || txbNgaySinh.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui long điền đầy đủ thông tin bắc buộc");
            }
            else
            {
                //Kiểm tra khách hàng này đã tồn tại hay chưa
                if (KhachHangBUS.Instance.KiemTraTonTai(txbHoTen.Text, txbNgaySinh.Text, txbDiaChi.Text))
                {
                    //Nếu tồn tại thì cập nhật
                    if (KhachHangBUS.Instance.LTCapNhatKhachHang(txbMaKH.Text, txbEmail.Text, txbSDT.Text, txbSoFax.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        ClearBinding();
                        HienThiDSKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                }
            }
        }

        [Obsolete]
        private void btnDangKyLuuTru_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã tồn tại chưa
            if(CTPhieuNhanPhongBUS.Instance.LTKiemTraDaTonTai(maPNP, txbMaKH.Text))
            {
                MessageBox.Show("Khách hàng đã được đăng ký");
            }
            else
            {
                if(CTPhieuNhanPhongBUS.Instance.LTThemCTPhieuNhanPhong(maPNP, txbMaKH.Text))
                {
                    MessageBox.Show("Đăng ký lưu trú thành công");
                    HienThiDSLuuTru(maPNP);
                }
                else
                {
                    MessageBox.Show("Đăng ký lưu trú thất bại");
                }
                
            }

        }

        [Obsolete]
        private void btnHuyDangKyLuuTru_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã được đăng ký chưa
            if(CTPhieuNhanPhongBUS.Instance.LTKiemTraDaTonTai(maPNP, txbMaKH.Text))
            {
                //Nếu đã đăng ký thì mới hủy được
                if(CTPhieuNhanPhongBUS.Instance.LTXoaCTPhieuNhanPhong(maPNP, txbMaKH.Text))
                {
                    MessageBox.Show("Hủy đăng ký lưu trú thành công");
                    HienThiDSLuuTru(maPNP);
                }
                else
                {
                    MessageBox.Show("Hủy đăng ký lưu trú thất bại");
                }
            }
            else
            {
                MessageBox.Show("Khách hàng chưa được đăng ký lưu trú");
            }
        }

        [Obsolete]
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Cập nhật: làm trống ô nhập như mặt định\n" +
                 "2. Thêm: ghi nhận thông tin khách hàng mới\n" +
                 "3. Cập nhật: cập nhật thông tin khách hàng\n" +
                 "4. Đăng ký: đăng ký lưu trú cho khách hàng đang chọn\n" +
                 "5. Hủy đăng ký: hủy đăng ký lưu trú cho khách hàng đang chọn", "Hướng dẫn");
        }
        #endregion

       
    }
}
