using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        

            var checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DefaultCellStyle.NullValue = false;
            DsPhongDataGridView.Columns.Add(checkBoxColumn);
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "Select";
        }

        [Obsolete]
        private void fPhieuDatPhong_Load(object sender, EventArgs e)
        {
            DsPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayDanhSachPDP();
            label10.Visible = false;
            SoNgTrongDoanTBox.Visible = false;
            NotiLabel.Text = null;
        }
        private void DsPhongDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int checkedColumnIndex = DsPhongDataGridView.Columns["Select"].Index;
            foreach (DataGridViewRow row in this.DsPhongDataGridView.Rows)
            {
                if (row.Cells[checkedColumnIndex].Value == null)
                {
                    bool isChecked = (bool)row.Cells[checkedColumnIndex].FormattedValue;
                    row.Cells[checkedColumnIndex].Value = isChecked;
                }
            }
        }
        [Obsolete]
        private async void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            PhieuDatPhongBUS pdp = new PhieuDatPhongBUS();

            pdp.MAPDP = PhieuDatPhongBUS.Instance.KHLayMaPDP();
            pdp.NGAYDEN = NgaydenTimePicker.Value;
            pdp.NGAYLAP = DateTime.Today;
            pdp.SODEMLUUTRU = SoDemLuuTruTBox.Text;

            if (doanCheckBox.Checked) pdp.SONGUOI = SoNgTrongDoanTBox.Text;
            else{
                pdp.SONGUOI = "1";
            }

            //kiểm tra xem có chọn phòng nào chưa
            int checkedColumnIndex = DsPhongDataGridView.Columns["Select"].Index;
            bool hasCheckedBox = false;
            foreach (DataGridViewRow row in DsPhongDataGridView.Rows){
                if (row.Cells[checkedColumnIndex] != null && row.Cells[checkedColumnIndex].Value != null)
                {
                    bool isChecked = (bool)row.Cells[checkedColumnIndex].Value;
                    if (isChecked)
                    {
                        hasCheckedBox = true;
                        break;
                    }
                }
            }

            if (!hasCheckedBox)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Thông tin chưa hợp lệ";
            }

            else
            {
                //Các thông tin hợp lệ
                if (PhieuDatPhongBUS.Instance.KHKiemTraThongTinPDP(pdp))
                {
                    MessageBox.Show("Đặt phòng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotiLabel.Text = null;

                    //Lưu phiếu đặt phòng
                    PhieuDatPhongBUS.Instance.KHThemPDP(pdp);

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
                    for (int i = 0; i < MaPhongChecked.Count(); i++)
                    {
                        CTPhieuDatPhongBUS.Instance.KHThemCtPDP(pdp.MAPDP, MaPhongChecked[i]);
                    }


                    foreach (DataGridViewRow row in DsPhongDataGridView.Rows)
                    {
                        if (row.Cells[checkedColumnIndex].Value != null && (bool)row.Cells[checkedColumnIndex].Value == true)
                        {
                            row.Cells[checkedColumnIndex].Value = false;
                            DsPhongDataGridView.RefreshEdit();
                        }
                    }
                    SoDemLuuTruTBox.Text = "";
                }
                //Có thông tin chưa hợp lệ
                else
                {
                    NotiLabel.Text = null;
                    await Task.Delay(300);
                    NotiLabel.Text = "Thông tin chưa hợp lệ";
                }
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
