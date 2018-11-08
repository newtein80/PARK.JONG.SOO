using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PARK.JONG.SOO.Models.SystemViewModel
{
    public partial class TMenu
    {
        [Key]
        public int MenuSeq { get; set; }
        public string MenuName { get; set; }
        public int? UpperMenuSeq { get; set; }
        public string PgmId { get; set; }
        public string MenuDescription { get; set; }
        public string ImagePath { get; set; }
        public string UseYn { get; set; }
        public int? SortOrder { get; set; }
    }
}
