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
            ClearBinding();
            if (dsPhieuDatPhong.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaPDP.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "MAPDP", true, DataSourceUpdateMode.Never));
                txbNgayDen.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "NGAYDEN", true, DataSourceUpdateMode.Never));
                txbSoDem.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SODEMLUUTRU", true, DataSourceUpdateMode.Never));
                txbSoNguoi.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SONGUOI", true, DataSourceUpdateMode.Never));
                txbHoTen.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "TENKH", true, DataSourceUpdateMode.Never));
                txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
                txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
                txbSDT.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SODT", true, DataSourceUpdateMode.Never));
            }    
        }
        void ClearBinding()
        {
            txbMaPDP.DataBindings.Clear();
            txbNgayDen.DataBindings.Clear();
            txbSoDem.DataBindings.Clear();
            txbSoNguoi.DataBindings.Clear();
            txbHoTen.DataBindings.Clear();
            txbNgaySinh.DataBindings.Clear();
            txbDiaChi.DataBindings.Clear();
            txbSDT.DataBindings.Clear();

            txbMaPDP.Text = "";
            txbNgayDen.Text = "";
            txbSoDem.Text = "";
            txbSoNguoi.Text = "";
            txbHoTen.Text = "";
            txbNgaySinh.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }

        [Obsolete]
        void DanhSachPhong()
        {
            string maPDP = txbMaPDP.Text;
            DataTable dsPhong = PhongBUS.Instance.LTLayDSPhongTheoPDP(maPDP);
            lvPhong.Items.Clear();
            foreach (DataRow row in dsPhong.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAPHONG"].ToString());
                item.SubItems.Add(row["TRANGTHAI"].ToString());
                item.SubItems.Add(row["HANGPHONG"].ToString());
                item.SubItems.Add(row["GIAMOTDEM"].ToString());
                item.SubItems.Add(row["LOAIGIUONG"].ToString());
                item.SubItems.Add(row["SUCCHUA"].ToString());

                lvPhong.Items.Add(item);

                
            }
            foreach (ColumnHeader column in lvPhong.Columns)
            {
                column.Width = (lvPhong.Width-1)/6;
                column.AutoResize(ColumnHeaderAutoResizeStyle.None);
            }
        }

        [Obsolete]
        void DanhSachDichVu()
        {
            string maPDP = txbMaPDP.Text;
            DataTable dsDichVu = PhieuDichVuBUS.Instance.LTLayDSDichVuTheoPDP(maPDP);
            lvDichVu.Items.Clear();
            foreach (DataRow row in dsDichVu.Rows)
            {
                ListViewItem item = new ListViewItem(row["TENDV"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["DONVITINH"].ToString());
                item.SubItems.Add(DateTime.Parse(row["LICHSUDUNG"].ToString()).ToString("dd/MM/yyyy"));
                item.SubItems.Add(row["GHICHU"].ToString());
                item.SubItems.Add(row["GIADV"].ToString());

                lvDichVu.Items.Add(item);


            }
            foreach (ColumnHeader column in lvDichVu.Columns)
            {
                column.Width = (lvPhong.Width - 1) / 6;
                column.AutoResize(ColumnHeaderAutoResizeStyle.None);
            }
        }

        void DoiMauPDP()
        {
            foreach (DataGridViewRow row in dtgvDanhSachDP.Rows)
            {
                if (row != null && row.Cells["MAPDP"].Value != null)
                {
                    string maPNP = PhieuNhanPhongBUS.Instance.LTLayMaPNP(row.Cells["MAPDP"].Value.ToString());
                    if (maPNP != "")
                    {
                        if (CTPhieuNhanPhongBUS.Instance.LTKiemTraDangKyLuuTru(maPNP))
                        {
                            // Thay đổi màu của dòng tìm thấy
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }
        #endregion

        #region event
        [Obsolete]
        private void CheckInGUI_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();

            DoiMauPDP();
        }

        [Obsolete]
        private void btnDangKyThongTinLuuTru_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng ký thông tin lưu trú cho phiếu đặt phòng này", "Thông báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                DKThongTinLuuTruGUI dk = new DKThongTinLuuTruGUI(txbMaPDP.Text);
                this.Hide();
                dk.ShowDialog();
                this.Show();
            }
        }

        [Obsolete]
        private void txbMaPDP_TextChanged(object sender, EventArgs e)
        {
            DanhSachPhong();
            DanhSachDichVu();
            //Kiểm tra xem đã Phiếu đặt phòng này đã check-in thành công chưa
            string maPNP = PhieuNhanPhongBUS.Instance.LTLayMaPNP(txbMaPDP.Text);
            if (maPNP != "")
            {
                //Nếu đã check-in thành công khóa các button lại
                if (CTPhieuNhanPhongBUS.Instance.LTKiemTraDangKyLuuTru(maPNP))
                {
                    this.btnDangKyThongTinLuuTru.Enabled = false;
                    this.btnHoanTat.Enabled = false;
                }
                else
                {
                    this.btnDangKyThongTinLuuTru.Enabled = true;
                    this.btnHoanTat.Enabled = true;
                }

            }
            else
            {
                this.btnDangKyThongTinLuuTru.Enabled = true;
                this.btnHoanTat.Enabled = true;
            }
        }

        [Obsolete]
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [Obsolete]
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string maPNP = PhieuNhanPhongBUS.Instance.LTLayMaPNP(txbMaPDP.Text);
            if(maPNP != "")
            {
                if (CTPhieuNhanPhongBUS.Instance.LTKiemTraDangKyLuuTru(maPNP))
                {
                    MessageBox.Show("Check-in thành công");
                    //dtgvDanhSachDP.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    // Duyệt qua tất cả các dòng trong dtgvDanhSachDP
                    foreach (DataGridViewRow row in dtgvDanhSachDP.Rows)
                    {
                        if (row != null && row.Cells["MAPDP"].Value != null)
                        {
                            // Kiểm tra giá trị MaPDP với giá trị của cột tương ứng trong dòng
                            if (row.Cells["MAPDP"].Value.ToString() == txbMaPDP.Text)
                            {
                                // Thay đổi màu của dòng tìm thấy
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa hoàn thành đăng ký lưu trú cho khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa hoàn thành đăng ký lưu trú cho khách hàng");
            }

        }







        #endregion
        [Obsolete]
        private void btnLocPDP_Click(object sender, EventArgs e)
        {
            dtgvDanhSachDP.DataSource = dsPhieuDatPhong;
            ClearBinding();
            //Lấy danh sách
            dsPhieuDatPhong.DataSource = PhieuDatPhongBUS.Instance.LTLayDanhSachPDPTheoNgay();
            
            if (dsPhieuDatPhong.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaPDP.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "MAPDP", true, DataSourceUpdateMode.Never));
                txbNgayDen.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "NGAYDEN", true, DataSourceUpdateMode.Never));
                txbSoDem.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SODEMLUUTRU", true, DataSourceUpdateMode.Never));
                txbSoNguoi.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SONGUOI", true, DataSourceUpdateMode.Never));
                txbHoTen.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "TENKH", true, DataSourceUpdateMode.Never));
                txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
                txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
                txbSDT.DataBindings.Add(new Binding("Text", dtgvDanhSachDP.DataSource, "SODT", true, DataSourceUpdateMode.Never));
            }
            DoiMauPDP();
        }

        [Obsolete]
        private void btnTatCaPDP_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
            DoiMauPDP();
        }
    }
}
