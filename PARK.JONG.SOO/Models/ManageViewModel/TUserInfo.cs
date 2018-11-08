using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PARK.JONG.SOO.Models.ManageViewModel
{
    public partial class TUserInfo
    {
        [Key]
        public string Bunho { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string OrgCd { get; set; }
        public string AssignedIp { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Mobilephone { get; set; }
        public string UserType { get; set; }
        public string UserAuth { get; set; }
        public string DutyType { get; set; }
        public string MenuAuth { get; set; }
        public string LoginYn { get; set; }
        public string LockYn { get; set; }
        public DateTime? LastLoginDt { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDt { get; set; }
        public int SortOrder { get; set; }
        public string PwdchangeYn { get; set; }
        public string JikgupName { get; set; }
        public string DutytypeName { get; set; }
    }
}
