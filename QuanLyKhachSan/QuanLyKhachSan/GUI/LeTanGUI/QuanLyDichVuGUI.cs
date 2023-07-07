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
    public partial class QuanLyDichVuGUI : Form
    {
        BindingSource dsDichVu = new BindingSource();
        public QuanLyDichVuGUI()
        {
            InitializeComponent();
            LoadDV();
        }

        void LoadDV()
        {
            dtgvDSDichVu.DataSource = dsDichVu;
            ClearBingding();
            dsDichVu.DataSource = DichVuBUS.Instance.LayDSDV();

            if (dsDichVu.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaDV.DataBindings.Add(new Binding("Text", dsDichVu.DataSource, "MADV", true, DataSourceUpdateMode.Never));
                txbTenDV.DataBindings.Add(new Binding("Text", dtgvDSDichVu.DataSource, "TENDV", true, DataSourceUpdateMode.Never));
                txbDonViTinh.DataBindings.Add(new Binding("Text", dtgvDSDichVu.DataSource, "DONVITINH", true, DataSourceUpdateMode.Never));
                txbGia.DataBindings.Add(new Binding("Text", dtgvDSDichVu.DataSource, "GIADV", true, DataSourceUpdateMode.Never));
                txbLoaiDV.DataBindings.Add(new Binding("Text", dtgvDSDichVu.DataSource, "LOAIDV", true, DataSourceUpdateMode.Never));

            }
        }

        void ClearBingding()
        {
            txbMaDV.DataBindings.Clear();
            txbTenDV.DataBindings.Clear();
            txbDonViTinh.DataBindings.Clear();
            txbGia.DataBindings.Clear();
            txbLoaiDV.DataBindings.Clear();

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string madv = txbMaDV.Text;
            string tendv = txbTenDV.Text;
            string donvitinh = txbDonViTinh.Text;
            string gia = txbGia.Text;
            string loai = txbLoaiDV.Text;
            if (madv != "" && tendv != "" && donvitinh != "" && gia != "" && loai != "")
            {
                if (DichVuBUS.Instance.ThemDV(madv, tendv, donvitinh, gia, loai))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    LoadDV();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại :((");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            string madv = txbMaDV.Text;
            if (madv != "")
            {
                if (DichVuBUS.Instance.XoaDV(madv))
                {
                    MessageBox.Show("Xóa dịch vụ thành công");
                    LoadDV();
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ thất bại :((");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa!");
            }
        }

        private void btnCapNhatDV_Click(object sender, EventArgs e)
        {
            string madv = txbMaDV.Text;
            string tendv = txbTenDV.Text;
            string donvitinh = txbDonViTinh.Text;
            string gia = txbGia.Text;
            string loai = txbLoaiDV.Text;
            if (madv != "" && tendv != "" && donvitinh != "" && gia != "" && loai != "")
            {
                if (DichVuBUS.Instance.CapNhatDV(madv, tendv, donvitinh, gia, loai))
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công");
                    LoadDV();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại :((");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txbMaDV.Text = "";
            txbTenDV.Text = "";
            txbDonViTinh.Text = "";
            txbGia.Text = "";
            txbLoaiDV.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
