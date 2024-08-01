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
using Vsoft_share_document.DTO;
using WinForms_Vsoft.DAO;

namespace WinForms_Vsoft
{
    public partial class FrmSelectUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAO_DocumentWatchers DAO_DocumentWatchers = new DAO_DocumentWatchers();
        public List<ENT_User> lstSelectedUser = new List<ENT_User>();
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
                int[] selectedRowHandles = gridViewUser.GetSelectedRows();
                foreach (int rowHandle in selectedRowHandles)
                {
                    ENT_User rowData = gridViewUser.GetRow(rowHandle) as ENT_User; 
                    if(rowData != null && rowData.IsActive) lstSelectedUser.Add(rowData);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Chưa có dòng nào được chọn.");
            }
        }
    }
}