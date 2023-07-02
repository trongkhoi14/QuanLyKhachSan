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
    public partial class fTraCuuTour : Form
    {
        fDangKyTour fdkt = new fDangKyTour();

        public fTraCuuTour(fDangKyTour f)
        {
            InitializeComponent();
            fdkt = f;
        }
        
        [Obsolete]
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LayDSTour();
            HienThiTourDangChon();
            
        }

        [Obsolete]
        void LayDSTour()
        {
            dsTourDtgv.DataSource = TourDuLichBUS.Instance.LayDSTour();
        }

        void HienThiTourDangChon()
        {
            tenTourTxb.DataBindings.Add(new Binding("Text", dsTourDtgv.DataSource, "TEN", true, DataSourceUpdateMode.Never));
            maTourTxb.DataBindings.Add(new Binding("Text", dsTourDtgv.DataSource, "MATDL", true, DataSourceUpdateMode.Never));
            diaDiemTxb.DataBindings.Add(new Binding("Text", dsTourDtgv.DataSource, "DIADIEM", true, DataSourceUpdateMode.Never));
            giaTxb.DataBindings.Add(new Binding("Text", dsTourDtgv.DataSource, "GIA", true, DataSourceUpdateMode.Never));
            moTaTxb.DataBindings.Add(new Binding("Text", dsTourDtgv.DataSource, "MOTA", true, DataSourceUpdateMode.Never));
            maDTTxb.DataBindings.Add(new Binding("Text", dsTourDtgv.DataSource, "MADT", true, DataSourceUpdateMode.Never));
        }

        [Obsolete]
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            fdkt.tour = new TourDuLichBUS(maTourTxb.Text, tenTourTxb.Text, diaDiemTxb.Text, moTaTxb.Text, Convert.ToDouble(giaTxb.Text), maDTTxb.Text);
            fdkt.refesh();
            this.Close();
        }
    }
}
