using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Vsoft.DAO;

namespace WinForms_Vsoft
{
    public partial class FrmSelectUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAO_DocumentWatchers DAO_DocumentWatchers = new DAO_DocumentWatchers();
        public string UserId { get; set; } = "";
        public FrmSelectUser()
        {
            InitializeComponent();
            LoadData();

        }
        public async void LoadData()
        {
            var data = await DAO_DocumentWatchers.LoadDataUser();
            grdCtrUser.DataSource = data;
        }

        private void btnLoadData_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSelect_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Lấy dòng hiện tại đang chọn
            if (gridViewUser.SelectedRowsCount > 0)
            {
                // Lấy chỉ số của dòng đầu tiên đang chọn
                int focusedRowHandle = gridViewUser.GetSelectedRows()[0];

                // Lấy giá trị của cột Id
                var idValue = gridViewUser.GetRowCellValue(focusedRowHandle, "Id");
                var isActive = gridViewUser.GetRowCellValue(focusedRowHandle, "IsActive");
                if (!(bool)isActive) {
                    MessageBox.Show($"Người dùng hệ thống chưa được kích hoạt");
                }
                else
                {
                    UserId = idValue.ToString();

                    // Hiển thị giá trị Id
                    MessageBox.Show($"Đã chọn người dùng Id: {idValue}");
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Chưa có dòng nào được chọn.");
            }
        }
    }
}