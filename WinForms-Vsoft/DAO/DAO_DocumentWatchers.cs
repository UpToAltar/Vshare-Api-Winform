using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Vsoft_share_document.DTO;
using WinForms_Vsoft.APIHelper;
using WinForms_Vsoft.DTO;

namespace WinForms_Vsoft.DAO
{
    public class DAO_DocumentWatchers
    {
        public async Task<List<DTO_DocumentWatchers_View>> LoadData()
        {
            string url = ApiURL.GET_ALL_DOCUMENTWATCHERS;
            var data  = await ApiClient.GetDataFromAPI(url);
            List<DTO_DocumentWatchers_View> lst = JsonConvert.DeserializeObject<List<DTO_DocumentWatchers_View>>(data);
            return lst != null ? lst : new List<DTO_DocumentWatchers_View>() ;
        }
        public async Task<List<ENT_User>> LoadDataUser()
        {
            string url = ApiURL.GET_ALL_USER_TO_ADD;
            var data = await ApiClient.GetDataFromAPI(url);
            List<ENT_User> lst = JsonConvert.DeserializeObject<List<ENT_User>>(data);
            return lst != null ? lst : new List<ENT_User>();
        }
        public async Task<List<ENT_Document>> LoadDataDocument()
        {
            string url = ApiURL.GET_ALL_DOCUMENT_TO_ADD;
            var data = await ApiClient.GetDataFromAPI(url);
            List<ENT_Document> lst = JsonConvert.DeserializeObject<List<ENT_Document>>(data);
            return lst != null ? lst : new List<ENT_Document>();
        }

        public async Task<string> PostDataReturnMsg(Dictionary<string, object> body)
        {
            string url = ApiURL.POST_DOCUMENTWATCHERS;
            string msg = await ApiClient.PostDataReturnMsg(url,body);
            return msg;
        }
        public async Task<string> DeleteDataReturnMsg(string id)
        {
            string url = ApiURL.DELETE_DOCUMENTWATCHERS;
            string msg = await ApiClient.DeleteDataReturnMsg(url, id);
            return msg;
        }
    }
}
