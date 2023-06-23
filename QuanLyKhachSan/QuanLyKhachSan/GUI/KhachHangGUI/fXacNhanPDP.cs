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
    public partial class fXacNhanPDP : Form
    {
        public int ReturnValue { get; set; }
        public fXacNhanPDP(PhieuDatPhongBUS pdp, string ptttoan, List<string> MaPhongChecked)
        {
            InitializeComponent();
            NgaydenTimePicker.Value = Convert.ToDateTime(pdp.NGAYDEN);
            SoDemLuuTruTBox.Text = pdp.SODEMLUUTRU;
            PhuongThucTTTBox.Text = ptttoan;
            SoNgTrongDoanTBox.Text = pdp.SONGUOI;
            for(int i = 0;i< MaPhongChecked.Count;i++)
            {
                if (i == MaPhongChecked.Count - 1)
                {
                    PhongTBox.Text += MaPhongChecked[i].ToString();
                }
                else
                {
                    PhongTBox.Text += MaPhongChecked[i].ToString() + ", ";
                }
            }
        }

        private void fXacNhanPDP_Load(object sender, EventArgs e)
        {
            
        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {
            this.ReturnValue = 1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = 0;
            this.Close();
        }
    }
}
