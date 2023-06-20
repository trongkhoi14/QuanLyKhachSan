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
    public partial class fPhieuDatPhong : Form
    {
        public fPhieuDatPhong()
        {
            InitializeComponent();
            DsPhongDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DsPhongDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        [Obsolete]
        private void fPhieuDatPhong_Load(object sender, EventArgs e)
        {
            DsPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.LayDanhSachPDP();
            var checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DefaultCellStyle.NullValue = false;
            DsPhongDataGridView.Columns.Add(checkBoxColumn);
            checkBoxColumn.Name = "Select";
            DsPhongDataGridView.AutoGenerateColumns = false;

            label10.Visible = false;
            SoNgTrongDoanTBox.Visible = false;
            NotiLabel.Text = null;
        }

        [Obsolete]
        private async void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            PhieuDatPhongBUS pdp = new PhieuDatPhongBUS();

            var temp = PhieuDatPhongBUS.Instance.LayMaPDPGanNhat();
            string tempPDP = (string)temp.Rows[0][0];

            pdp.MAPDP = PhieuDatPhongBUS.Instance.CurrentMaPDP(tempPDP);
            pdp.NGAYDEN = NgaydenTimePicker.Value;
            pdp.NGAYLAP = DateTime.Today;
            pdp.SODEMLUUTRU = SoDemLuuTruTBox.Text;

            if (doanCheckBox.Checked)
            {
                pdp.SONGUOI = SoNgTrongDoanTBox.Text;
            }
            else
            {
                pdp.SONGUOI = "1";
            }

            //Các thông tin hợp lệ
            if (PhieuDatPhongBUS.Instance.KiemTraThongTinPDP(pdp))
            {
                MessageBox.Show("Đặt phòng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotiLabel.Text = null;

                //Lưu phiếu đặt phòng
                PhieuDatPhongBUS.Instance.ThemPDP(pdp);

                //Lấy ds các mã phòng đã chọn
                List<string> MaPhongChecked = new List<string>();
                foreach (DataGridViewRow row in DsPhongDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(checkBoxCell.Value) == true)
                    {
                        MaPhongChecked.Add(row.Cells["MAPHONG"].Value.ToString());
                    }
                }
                //Lưu chi tiết phiếu đặt phòng
                for(int i=0; i<MaPhongChecked.Count(); i++)
                {
                    CTPhieuDatPhongBUS.Instance.ThemCtPDP(pdp.MAPDP, MaPhongChecked[i]);
                }
                //Quay về màn hình chính
                KhachHangGUI khg = new KhachHangGUI();
                this.Hide();
                khg.ShowDialog();
                this.Show();
            }
            //Có thông tin chưa hợp lệ
            else
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Thông tin chưa hợp lệ";
            }
        }

        private void doanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(label10.Visible == false) {
                label10.Visible = true;
                SoNgTrongDoanTBox.Visible = true;
            }
            else
            {
                label10.Visible = false;
                SoNgTrongDoanTBox.Visible = false;
            }
        }
    }
}
