using DevExpress.DataAccess.DataFederation;
using DevExpress.Map.Kml.Model;
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
using WinForms_Vsoft.BUS;
using WinForms_Vsoft.DAO;
using WinForms_Vsoft.DTO;
using static DevExpress.XtraEditors.XtraInputBox;

namespace WinForms_Vsoft
{
    public partial class FrmSelectDocument : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAO_DocumentWatchers DAO_DocumentWatchers = new DAO_DocumentWatchers();
        BUS_DocumentWatchers BUS_DocumentWatchers = new BUS_DocumentWatchers();
        List<ENT_User> lstUser = new List<ENT_User>();
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

        private async void btnSelect_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(dateExpiredIn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày hết hạn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Lấy dòng hiện tại đang chọn
            if (grdViewDocument.SelectedRowsCount > 0)
            {
                // Lấy chỉ số của dòng đầu tiên đang chọn
                int focusedRowHandle = grdViewDocument.GetSelectedRows()[0];
                ENT_Document doc = grdViewDocument.GetRow(focusedRowHandle) as ENT_Document;
                if (!doc.IsActive)
                {
                    MessageBox.Show($"Tài liệu chưa được kích hoạt");
                    return;
                }
                if (doc.Status != 1 && doc.Status != 3)
                {
                    MessageBox.Show("Tài liệu không được phép chia sẻ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<ENT_User> users = grdViewSelectedUser.DataSource as List<ENT_User>;
                if(users == null)
                {
                    MessageBox.Show("Vui lòng chọn người dùng muốn chia sẻ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DTO_Response msgPost = await BUS_DocumentWatchers.SaveData(doc,users,dateExpiredIn,cbIsActive.Checked);
                MessageBox.Show(msgPost.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(msgPost.Success) this.Close();
            }
            else
            {
                MessageBox.Show("Chưa có dòng nào được chọn.");
            }
        }

        private void btnSelectUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addForm = new FrmSelectUser();
            
            addForm.ShowDialog();
            //Cập nhật danh sách User đã chọn để không trùng
            var existingEmails = lstUser.Select(item => item.Email).ToHashSet();
            foreach (var item in addForm.lstSelectedUser)
            {
                if (!existingEmails.Contains(item.Email))
                {
                    lstUser.Add(item);
                    existingEmails.Add(item.Email);
                }
            }
            //Gán data vào grid
            grdCtrSelectedUser.DataSource = null;
            grdCtrSelectedUser.DataSource = lstUser;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Lấy dòng hiện tại đang chọn
            if (grdViewDocument.SelectedRowsCount > 0)
            {
                // Lấy chỉ số của dòng đầu tiên đang chọn
                int focusedRowHandle = grdViewSelectedUser.GetSelectedRows()[0];

                // Lấy giá trị của cột Id
                var emailValue = grdViewSelectedUser.GetRowCellValue(focusedRowHandle, "Email");
                if (emailValue != null)
                {
                    lstUser.RemoveAll(u => u.Email == emailValue.ToString());
                    // Cập nhật lại DataSource của GridControl
                    grdCtrSelectedUser.DataSource = null; // Unbind current data source
                    grdCtrSelectedUser.DataSource = lstUser; // Bind new data source

                    // Làm mới GridView
                    grdCtrSelectedUser.RefreshDataSource();
                }
                else
                {
                    MessageBox.Show("Lỗi xóa dòng người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Chưa có dòng nào được chọn.");
            }
        }

        private void btnSelectEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addForm = new FrmSelectEmail();
            
            addForm.ShowDialog();
            //Cập nhật danh sách User đã chọn để không trùng email
            var existingEmails = lstUser.Select(item => item.Email).ToHashSet();
            foreach (var item in addForm.lstUser)
            {
                if (!existingEmails.Contains(item.Email))
                {
                    lstUser.Add(item);
                    existingEmails.Add(item.Email);
                }
            }
            //Gán data vào grid
            grdCtrSelectedUser.DataSource = null;
            grdCtrSelectedUser.DataSource = lstUser;
        }
    }
}