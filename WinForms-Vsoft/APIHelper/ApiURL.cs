using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Vsoft.APIHelper
{
    public static class ApiURL
    {
        public const string GET_ALL_DOCUMENTWATCHERS = "https://localhost:7221/api/DocumentWatchers";
        public const string POST_DOCUMENTWATCHERS = "https://localhost:7221/api/DocumentWatchers";
        public const string DELETE_DOCUMENTWATCHERS = "https://localhost:7221/api/DocumentWatchers";
        public const string GET_ALL_USER_TO_ADD = "https://localhost:7221/api/DocumentWatchers/GetUserToAdd";
        public const string GET_ALL_DOCUMENT_TO_ADD = "https://localhost:7221/api/DocumentWatchers/GetDocumentToAdd";
    }
}
