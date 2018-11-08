using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PARK.JONG.SOO.Models.SystemViewModel
{
    public partial class TCommonCode
    {
        [Key]
        public string CodeType { get; set; }
        public string CodeTypeName { get; set; }
        [Key]
        public string CodeId { get; set; }
        public string CodeName { get; set; }
        public int? CodeVal { get; set; }
        public int? SortOrder { get; set; }
        public string UseYn { get; set; }
        public string CodeComment { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
