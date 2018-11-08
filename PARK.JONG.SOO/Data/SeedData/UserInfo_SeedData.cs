using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PARK.JONG.SOO.Models.ManageViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARK.JONG.SOO.Data.SeedData
{
    public static class UserInfo_SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.TUserInfo.Any())
                {
                    return;   // DB has been seeded
                }

                context.TUserInfo.AddRange(
                    new TUserInfo
                    {
                        AssignedIp = "",
                        Bunho = "박종수",
                        ConfirmPassword = "#skdlf12",
                        CreateDt = DateTime.Now,
                        CreateUserId = "박종수",
                        DutyType = "3",
                        DutytypeName = "담당",
                        Email = "parkjs@email.com",
                        JikgupName = "3급",
                        LastLoginDt = DateTime.Now,
                        LockYn = "N",
                        LoginYn = "N",
                        MenuAuth = "3",
                        Mobilephone = "010-0100-0100",
                        OrgCd = "127000",
                        Password = "#skdlf12",
                        PwdchangeYn = "N",
                        SortOrder = 1,
                        Telephone = "02-222-2222",
                        UpdateDt = DateTime.Now,
                        UpdateUserId = "박종수",
                        UserAuth = "7",
                        UserName = "박종수이름",
                        UserType = "U"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
