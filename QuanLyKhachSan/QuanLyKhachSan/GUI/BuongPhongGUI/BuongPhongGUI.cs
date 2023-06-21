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

namespace QuanLyKhachSan.GUI.BuongPhongGUI
{
    public partial class BuongPhongGUI : Form
    {
        public BuongPhongGUI()
        {
            InitializeComponent();
            NotiLabel.Text = null;
        }

        [Obsolete]
        private async void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            var pdgttp = new PDGTinhTrangPhongBUS();
            pdgttp.MAPDG = PDGTinhTrangPhongBUS.Instance.BPGetPDGCode();
            pdgttp.MAPHONG = MaPhongTBox.Text;
            pdgttp.NGAYLAP = DateTime.Today;
            pdgttp.MOTA=MoTaTBox.Text;

            var check = PDGTinhTrangPhongBUS.Instance.BPCheckValidPDG(pdgttp);
            if (check == 0)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui lòng điền mã phòng";
            }
            else if(check == 1)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Mô tả không được trống";
            }
            else if (check == 2)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Mã phòng không tồn tại";
            }
            else 
            {
                MessageBox.Show("Đánh giá tình trạng phòng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotiLabel.Text = null;
                MaPhongTBox.Text = null;
                MoTaTBox.Text = null;
            }
        }
    }
}
