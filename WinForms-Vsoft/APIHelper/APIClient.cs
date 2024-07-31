using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Vsoft.APIHelper
{
    public class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetDataFromAPI(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody != null ? responseBody : "";
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }

        public static async Task<string> PostDataReturnMsg(string url, Dictionary<string,object> data)
        {
            try
            {
                // Chuyển đổi đối tượng data sang JSON
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Gửi yêu cầu POST
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Kiểm tra trạng thái phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Phản hồi thành công (200-299)
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return "";
                }
                else
                {
                    // Phản hồi lỗi (400-599)
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return $"Lỗi: {(int)response.StatusCode} - {response.ReasonPhrase}. {responseBody}";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                return $"Lỗi: {ex.Message}";
            }
        }

        public static async Task<string> DeleteDataReturnMsg(string url, string id)
        {
            try
            {
                url = url + "/" + id;
                HttpResponseMessage response = await client.DeleteAsync(url);
                // Kiểm tra trạng thái phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Phản hồi thành công (200-299)
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return "";
                }
                else
                {
                    // Phản hồi lỗi (400-599)
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return $"Lỗi: {(int)response.StatusCode} - {response.ReasonPhrase}. {responseBody}";
                }
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }
    }
}
