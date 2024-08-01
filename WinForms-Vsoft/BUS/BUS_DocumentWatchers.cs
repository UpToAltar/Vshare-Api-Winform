using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsoft_share_document.DTO;
using WinForms_Vsoft.DAO;
using WinForms_Vsoft.DTO;

namespace WinForms_Vsoft.BUS
{
    public class BUS_DocumentWatchers
    {
        DAO_DocumentWatchers DAO_DocumentWatchers = new DAO_DocumentWatchers();
        public async Task<string> SaveData(TextEdit documentId, TextEdit userId, TextEdit email, DateEdit expiredIn, CheckBox isActive)
        {
            if (documentId.Text == "") return "Vui lòng nhập Id tài liệu";
            Guid result;

            bool isValidGuid = Guid.TryParse(documentId.Text, out result);
            if (!isValidGuid) return "Id tài liệu phải đúng định dạng Guid";

            if (expiredIn.Text == "") return "Vui lòng chọn ngày hết hạn";

            var param = new Dictionary<string, object>();
            param["DocumentId"] = documentId.Text;
            param["ExpiredIn"] = ((DateTime)expiredIn.EditValue).ToString("dd-MM-yyyy");
            param["IsActive"] = isActive.Checked;
            if(userId.Text != "")
            {
                isValidGuid = Guid.TryParse(userId.Text, out result);
                if (!isValidGuid) return "Id Người dùng phải đúng định dạng Guid";
                param["UserId"] = userId.Text;
            }
            else
            {
                param["Email"] = email.Text;
            }
            string msg = await DAO_DocumentWatchers.PostDataReturnMsg(param); 
            return msg;
        }

        public async Task<DTO_Response> SaveData(ENT_Document document, List<ENT_User> users, DateEdit expiredIn, bool isChecked)
        {
            string result = "";
            bool success = true;
            foreach (var user in users) {
                // Khai báo body khi post
                object body;
                if(user.Id == Guid.Empty)
                {
                    body = new
                    {
                        DocumentId = document.Id,
                        Email = user.Email,
                        ExpiredIn = ((DateTime)expiredIn.EditValue).ToString("dd-MM-yyyy"),
                        IsActive = isChecked
                    };
                }
                else
                {
                    body = new ENT_CreateDocumentWatchers
                    {
                        DocumentId= document.Id,
                        Email = user.Email,
                        UserId = user.Id,
                        ExpiredIn = ((DateTime)expiredIn.EditValue).ToString("dd-MM-yyyy"),
                        IsActive = isChecked
                    };
                }

                //Thực hiện post data trả về msg
                string msg = await DAO_DocumentWatchers.PostDataReturnMsg(body);
                if(msg == "")
                {
                    //Thành công
                    result += $"Chia sẻ thành công tài liệu cho người dùng có email : {user.Email} \n";
                }
                else
                {
                    //Thất bại
                    result += $"Lỗi chia sẻ tài liệu cho người dùng có email {user.Email} : {msg} \n";
                    success = false;
                }
            }
            return new DTO_Response
            {
                Message = result,
                Success = success,
                Data = null
            };
        }

    }
}
