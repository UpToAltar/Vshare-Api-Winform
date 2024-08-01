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
using WinForms_Vsoft.CollectionHelper;

namespace WinForms_Vsoft
{
    public partial class FrmSelectEmail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public List<string> lstSelectedEmailString = new List<string>();
        public List<ENT_User> lstUser = new List<ENT_User>();
        public FrmSelectEmail()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            TextBox emailTextBox = new TextBox();
            emailTextBox.Width = 250;
            flpSelectEmail.Controls.Add(emailTextBox);
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra nếu có ít nhất một phần tử trong FlowLayoutPanel
            if (flpSelectEmail.Controls.Count > 0)
            {
                // Xóa phần tử cuối cùng
                flpSelectEmail.Controls.RemoveAt(flpSelectEmail.Controls.Count - 1);
            }
            else
            {
                MessageBox.Show("Chưa có phần tử nào để xóa");
            }
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flpSelectEmail.Controls.Count > 0)
            {
                string msg = "Đã thêm các Email : ";
                foreach (Control control in flpSelectEmail.Controls)
                {
                    //Check email hợp lệ không và đã có trong list hay chưa
                    if (CollectionHelper.CollectionHelper.IsValidEmail(control.Text) && !lstSelectedEmailString.Contains(control.Text))
                    {
                        lstSelectedEmailString.Add(control.Text);
                        msg += control.Text + " ";
                    }
                    
                }

                //Tạo list User trả về
                foreach (string item in lstSelectedEmailString)
                {
                    var newUser = new ENT_User()
                    {
                        Id = Guid.Empty,
                        Email = item,
                        FullName = "",
                        IsActive = true,
                    };
                    lstUser.Add(newUser);
                }
                if(lstSelectedEmailString.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm Email người dùng để chia sẻ");
                    return;
                }
                MessageBox.Show(msg);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng thêm Email người dùng để chia sẻ");
            }
            
        }
    }
}