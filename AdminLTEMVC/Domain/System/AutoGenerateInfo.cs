using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.System
{
    public class AutoGenerateInfo
    {
        public int id { get; set; }
        public int ModuleType { get; set; }
        public int DocumentID { get; set; }
        public int ReferenceDocumentID { get; set; }
        public int MenuID { get; set; }
        public int MenuItemID { get; set; }
        public int FormId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string FormName { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string FormText { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Prefix { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Prefix2 { get; set; }
        public int CodeLength { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Suffix { get; set; }
        public bool AutoGenerete { get; set; }
        public bool AutoClear { get; set; }
        public bool IsDepend { get; set; }
        public bool IsDependCode { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]

        public string ReportPrefix { get; set; }
        public int ReportType { get; set; }
        public bool IsBackDated { get; set; }
        public bool IsRoundOff { get; set; }
        public bool IsAutoComplete { get; set; }
        public bool IsAllowedInHO { get; set; }
        public bool IsAllowedInOutlet { get; set; }
        public bool IsActive { get; set; }

    }
}
