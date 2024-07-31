using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Vsoft.DTO
{
    public class DTO_DocumentWatchers_View
    {
        public Guid Id { get; set; }
        public Guid DocumentId { get; set; }
        public Guid? UserId { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime ExpiredIn { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime EditedOn { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? EditedBy { get; set; }
        public string? CheckSum { get; set; }

        public int SecurityLevel { get; set; }

        public string DocumentSummary { get; set; }

        public string StatusMessage { get; set; }
    }

}
