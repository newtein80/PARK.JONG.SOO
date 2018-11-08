using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PARK.JONG.SOO.Models.ManageViewModel
{
    public partial class TOrgInfo
    {
        [Key]
        public string OrgCd { get; set; }
        public string OrgName { get; set; }
        public string UpperOrgCd { get; set; }
        public int OrgLevel { get; set; }
        public int OrgOrder { get; set; }
        public string ZipCd { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string FaxNo { get; set; }
        public string UseYn { get; set; }
        public string LinkUserId { get; set; }
        public DateTime? LinkDt { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDt { get; set; }
        public int SortOrder { get; set; }
    }
}
