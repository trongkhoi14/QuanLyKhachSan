using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    public partial class fTraCuuDichVu : Form
    {
        BindingSource dsdv = new BindingSource();
        BindingList<DichVuBUS> dsdvdc = new BindingList<DichVuBUS>();

        public fTraCuuDichVu()
        {
            InitializeComponent();
            HienThi();
        }

        void HienThi()
        {
            dsDVDtgv.DataSource = dsdv;
            dvDaChonDtgv.DataSource = dsdvdc;
            LayDSDV();
            HienThiTTDVDangChon();
        }

        void LayDSDV()
        {
            dsdv.DataSource = DichVuBUS.Instance.LayDSDV();
        }

        void HienThiTTDVDangChon()
        {
            tenDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "TENDV", true, DataSourceUpdateMode.Never));
            maDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "MADV", true, DataSourceUpdateMode.Never));
            donViTinhTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "DONVITINH", true, DataSourceUpdateMode.Never));
            giaDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "GIADV", true, DataSourceUpdateMode.Never));
            loaiDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "LOAIDV", true, DataSourceUpdateMode.Never));
            soLuongTxb.Text = "1";
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            if (maDVTxb.Text != "")
            {
                dsdv.DataSource = DichVuBUS.Instance.LayDVTheoMaDV(maDVTxb.Text);
            }
            else
            {
                dsdv.DataSource = DichVuBUS.Instance.LayDSDV();
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            dsdvdc.Add(new DichVuBUS(tenDVTxb.Text, maDVTxb.Text, donViTinhTxb.Text, Convert.ToDouble(giaDVTxb.Text), loaiDVTxb.Text));
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (dsdvdc.Count() > 0)
            {
                dsdvdc.RemoveAt(dvDaChonDtgv.CurrentCell.RowIndex);
            }
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
