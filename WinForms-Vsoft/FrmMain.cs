using DevExpress.DocumentServices.ServiceModel.DataContracts;
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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAO_DocumentWatchers DAO_DocumentWatchers = new DAO_DocumentWatchers();
        public FrmMain()
        {
            InitializeComponent();
            Load();
        }

        public async void Load()
        {
            var data = await DAO_DocumentWatchers.LoadData();
            grdCtrDocumentWatchers.DataSource = data;
            grdViewDocumentWatchers.ExpandAllGroups();
        }

        private void btnLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            Load();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addForm = new FrmSelectDocument();
            this.Hide();
            addForm.ShowDialog();
            this.Show();
            Load();
        }

        private async void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Lấy dòng hiện tại đang chọn
            if (grdViewDocumentWatchers.SelectedRowsCount > 0)
            {
                // Lấy chỉ số của dòng đầu tiên đang chọn
                int focusedRowHandle = grdViewDocumentWatchers.GetSelectedRows()[0];

                // Lấy giá trị của cột Id
                var idValue = grdViewDocumentWatchers.GetRowCellValue(focusedRowHandle, "Id");

                string msg = await DAO_DocumentWatchers.DeleteDataReturnMsg(idValue.ToString());
                if(msg == "")
                {
                    MessageBox.Show("Xóa chia sẻ tài liệu thành công");
                    Load();
                }
                else
                {
                    MessageBox.Show(msg);
                }

            }
            else
            {
                MessageBox.Show("Chưa có dòng nào được chọn.");
            }
        }
    }
}