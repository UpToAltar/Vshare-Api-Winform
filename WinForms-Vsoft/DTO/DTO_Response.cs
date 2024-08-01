using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Vsoft.DTO
{
    public class DTO_Response
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
        public object? Data { get; set; }
    }
}
