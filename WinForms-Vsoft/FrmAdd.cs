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
using WinForms_Vsoft.BUS;

namespace WinForms_Vsoft
{
    public partial class FrmAdd : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_DocumentWatchers BUS_DocumentWatchers = new BUS_DocumentWatchers();
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseAddForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private async void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            string msgErr = await BUS_DocumentWatchers.SaveData(txtDocumentId, txtUserId, txtEmail, dateExpiredIn, cbIsActive);
            if (msgErr == "")
            {
                MessageBox.Show("Chia sẻ tài liệu cho người dùng thành công");
            }
            else
            {
                MessageBox.Show(msgErr);
            }
        }

        private void btnShowDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formSelectDocument = new FrmSelectDocument();
            formSelectDocument.ShowDialog();
            txtDocumentId.Text = formSelectDocument.DocumentId;
            
        }

        private void btnShowUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formSelectUser = new FrmSelectUser();
            formSelectUser.ShowDialog();
            txtUserId.Text = formSelectUser.UserId;
        }
    }
}