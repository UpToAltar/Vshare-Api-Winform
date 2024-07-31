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
    }
}
