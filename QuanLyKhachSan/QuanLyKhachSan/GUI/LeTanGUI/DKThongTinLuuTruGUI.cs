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
            HienThiDSLuuTru(maPNP);
        }
        [Obsolete]
        #region method
        void HienThiDSLuuTru(string maPNP)
        {
            dtgvDanhSachDKLuuTru.DataSource = CTPhieuNhanPhongBUS.Instance.LTLayDSKhachHangNhanPhong(maPNP);
        }
        #endregion

        #region event

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        #endregion


    }
}
