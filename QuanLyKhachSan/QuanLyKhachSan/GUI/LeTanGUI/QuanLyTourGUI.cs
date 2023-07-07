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
    public partial class QuanLyTourGUI : Form
    {
        BindingSource dsTourDuLich = new BindingSource();
        [Obsolete]
        public QuanLyTourGUI()
        {
            InitializeComponent();

            LoadTour();

            LoadDoiTac();
        }
        [Obsolete]
        void LoadTour()
        {
            dtgvDSTour.DataSource = dsTourDuLich;
            ClearBinding();
            dsTourDuLich.DataSource = TourDuLichBUS.Instance.LayDSTour();
            if (dsTourDuLich.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaTDL.DataBindings.Add(new Binding("Text", dtgvDSTour.DataSource, "MATDL", true, DataSourceUpdateMode.Never));
                txbTenTDL.DataBindings.Add(new Binding("Text", dtgvDSTour.DataSource, "TEN", true, DataSourceUpdateMode.Never));
                txbDiaDiem.DataBindings.Add(new Binding("Text", dtgvDSTour.DataSource, "DIADIEM", true, DataSourceUpdateMode.Never));
                txbMoTa.DataBindings.Add(new Binding("Text", dtgvDSTour.DataSource, "MOTA", true, DataSourceUpdateMode.Never));
                txbGia.DataBindings.Add(new Binding("Text", dtgvDSTour.DataSource, "GIA", true, DataSourceUpdateMode.Never));
                txbMaDT.DataBindings.Add(new Binding("Text", dtgvDSTour.DataSource, "MADT", true, DataSourceUpdateMode.Never));
            }
        }

        void ClearBinding()
        {
            txbMaTDL.DataBindings.Clear();
            txbTenTDL.DataBindings.Clear();
            txbMoTa.DataBindings.Clear();
            txbDiaDiem.DataBindings.Clear();
            txbGia.DataBindings.Clear();
            txbMaDT.DataBindings.Clear();
        }
        [Obsolete]
        void LoadDoiTac()
        {
            DataTable dsDoiTac = TourDuLichBUS.Instance.LayDSDoiTac();
            lvDoiTac.Items.Clear();
            foreach (DataRow row in dsDoiTac.Rows)
            {
                ListViewItem item = new ListViewItem(row["MADT"].ToString());
                item.SubItems.Add(row["TENDT"].ToString());
                item.SubItems.Add(row["EMAIL"].ToString());
                item.SubItems.Add(row["DIACHI"].ToString());
                item.SubItems.Add(row["SODT"].ToString());

                lvDoiTac.Items.Add(item);


            }
            foreach (ColumnHeader column in lvDoiTac.Columns)
            {
                column.Width = (lvDoiTac.Width - 3) / 5;
                column.AutoResize(ColumnHeaderAutoResizeStyle.None);
            }
        }

        #region event

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [Obsolete]
        private void btnThemTour_Click(object sender, EventArgs e)
        {
            string matdl = txbMaTDL.Text;
            string ten = txbTenTDL.Text;
            string diadiem = txbDiaDiem.Text;
            string mota = txbMoTa.Text;
            string gia = txbGia.Text;
            string madt = txbMaDT.Text;
            if(matdl != "" && ten != "" && diadiem != "" && mota != "" && gia != "" && madt != "" )
            {
                if (TourDuLichBUS.Instance.ThemTour(matdl, ten, diadiem, mota, gia, madt))
                {
                    MessageBox.Show("Thêm tour du lịch thành công");
                    LoadTour();
                }
                else
                {
                    MessageBox.Show("Thêm tour du lịch thất bại :((");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            
        }

        [Obsolete]
        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            string matdl = txbMaTDL.Text;
            if(matdl != "")
            {
                if (TourDuLichBUS.Instance.XoaTour(matdl))
                {
                    MessageBox.Show("Xóa Tour du lịch thành công");
                    LoadTour();
                }
                else
                {
                    MessageBox.Show("Xóa Tour du lịch thất bại :((");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tour du lịch muốn xóa!");
            }
        }

        [Obsolete]
        private void btnCapNhatTour_Click(object sender, EventArgs e)
        {
            string matdl = txbMaTDL.Text;
            string ten = txbTenTDL.Text;
            string diadiem = txbDiaDiem.Text;
            string mota = txbMoTa.Text;
            string gia = txbGia.Text;
            string madt = txbMaDT.Text;
            if (matdl != "" && ten != "" && diadiem != "" && mota != "" && gia != "" && madt != "")
            {
                if (TourDuLichBUS.Instance.CapNhatTour(matdl, ten, diadiem, mota, gia, madt))
                {
                    MessageBox.Show("Cập nhật tour du lịch thành công");
                    LoadTour();
                }
                else
                {
                    MessageBox.Show("Cập nhật tour du lịch thất bại :((");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txbMaTDL.Text = "";
            txbTenTDL.Text = "";
            txbDiaDiem.Text = "";
            txbGia.Text = "";
            txbMoTa.Text = "";
            txbMaDT.Text = "";
        }

        #endregion
    }
}
