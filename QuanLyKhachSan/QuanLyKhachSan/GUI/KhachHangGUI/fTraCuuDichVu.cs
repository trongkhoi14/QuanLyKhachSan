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
        fDangKyDichVu f = new fDangKyDichVu();
        BindingSource dsdv = new BindingSource();
        public BindingList<CTPhieuDichVuBUS> dsdvdc = new BindingList<CTPhieuDichVuBUS>();

        public fTraCuuDichVu(fDangKyDichVu fDKDV)
        {
            InitializeComponent();
            f = fDKDV;
        }

        [Obsolete]
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dsDVDtgv.DataSource = dsdv;
            dvDaChonDtgv.DataSource = dsdvdc;
            maPDVLb.Text = maPDVLb.Text + " " + LayMaPDV();
            LayDSDV();
            HienThiTTDVDangChon();
        }

        [Obsolete]
        void LayDSDV()
        {
            dsdv.DataSource = DichVuBUS.Instance.LayDSDV();
        }

        [Obsolete]
        string LayMaPDV()
        {
            return PhieuDichVuBUS.Instance.LayMaPhieuDichVu(PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH));
        }

        void HienThiTTDVDangChon()
        {
            tenDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "TENDV", true, DataSourceUpdateMode.Never));
            maDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "MADV", true, DataSourceUpdateMode.Never));
            donViTinhTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "DONVITINH", true, DataSourceUpdateMode.Never));
            giaDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "GIADV", true, DataSourceUpdateMode.Never));
            loaiDVTxb.DataBindings.Add(new Binding("Text", dsDVDtgv.DataSource, "LOAIDV", true, DataSourceUpdateMode.Never));
            soLuongTxb.Text = "1";
            ghiChuTxb.Text = "không";
            nhanXetTxb.Text = "không";
        }

        [Obsolete]
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

        [Obsolete]
        private void themBtn_Click(object sender, EventArgs e)
        {
            foreach (CTPhieuDichVuBUS i in dsdvdc)
            {
                if (i.MaDV == maDVTxb.Text && i.LichSuDung == lichSuDungDTP.Value && i.GhiChu == ghiChuTxb.Text )
                {
                    i.SoLuong = 0 + i.SoLuong + Convert.ToInt32(soLuongTxb.Text);
                    dvDaChonDtgv.Refresh();
                    return;
                }
            }
            dsdvdc.Add(new CTPhieuDichVuBUS(LayMaPDV(), maDVTxb.Text, Convert.ToInt32(soLuongTxb.Text), lichSuDungDTP.Value, ghiChuTxb.Text, nhanXetTxb.Text));
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (dsdvdc.Count() > 0)
            {
                dsdvdc.RemoveAt(dvDaChonDtgv.CurrentCell.RowIndex);
            }
        }

        [Obsolete]
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            f.dsdvdc = dsdvdc;
            f.refesh();
            this.Hide();
        }
    }
}
