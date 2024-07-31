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
    public partial class FrmSelectDocument : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAO_DocumentWatchers DAO_DocumentWatchers = new DAO_DocumentWatchers();
        public string DocumentId { get; set; } = "";
        public FrmSelectDocument()
        {
            InitializeComponent();
            LoadData();

        }
        public async void LoadData()
        {
            var data = await DAO_DocumentWatchers.LoadDataDocument();
            grdCtrDocument.DataSource = data;
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
            if (grdViewDocument.SelectedRowsCount > 0)
            {
                // Lấy chỉ số của dòng đầu tiên đang chọn
                int focusedRowHandle = grdViewDocument.GetSelectedRows()[0];

                // Lấy giá trị của cột Id
                var idValue = grdViewDocument.GetRowCellValue(focusedRowHandle, "Id");
                var isActive = grdViewDocument.GetRowCellValue(focusedRowHandle, "IsActive");
                if (!(bool)isActive) {
                    MessageBox.Show($"Tài liệu chưa được kích hoạt");
                }
                else
                {
                    DocumentId = idValue.ToString();

                    // Hiển thị giá trị Id
                    MessageBox.Show($"Đã chọn tài liệu Id: {idValue}");
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