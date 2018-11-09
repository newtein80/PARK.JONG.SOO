using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PARK.JONG.SOO.Models.ApplicationModel;
using PARK.JONG.SOO.Models.ManageViewModel;
using PARK.JONG.SOO.Models.SystemViewModel;

namespace PARK.JONG.SOO.Data
{
    // Exception : Cannot create a DbSet for 'ApplicationUser' because this type is not included in the model for the context
    // I found the problem. My ApplicationContext was inheriting from DbContext. I changed it to IdentityDbContext<ApplicationUser> and it works.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TOrgInfo> TOrgInfo { get; set; }
        public virtual DbSet<TUserInfo> TUserInfo { get; set; }

        public virtual DbSet<TCommonCode> TCommonCode { get; set; }
        public virtual DbSet<TMenu> TMenu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            modelBuilder.Entity<TOrgInfo>(entity =>
            {
                entity.HasKey(e => e.OrgCd);

                entity.ToTable("T_ORG_INFO");

                entity.Property(e => e.OrgCd)
                    .HasColumnName("ORG_CD")
                    .HasMaxLength(32)
                    .ValueGeneratedNever();

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(256);

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR2")
                    .HasMaxLength(256);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CREATE_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("CREATE_USER_ID")
                    .HasMaxLength(16);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(32);

                entity.Property(e => e.LinkDt)
                    .HasColumnName("LINK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkUserId)
                    .HasColumnName("LINK_USER_ID")
                    .HasMaxLength(16);

                entity.Property(e => e.OrgLevel).HasColumnName("ORG_LEVEL");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasColumnName("ORG_NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.OrgOrder).HasColumnName("ORG_ORDER");

                entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UPDATE_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UPDATE_USER_ID")
                    .HasMaxLength(16);

                entity.Property(e => e.UpperOrgCd)
                    .HasColumnName("UPPER_ORG_CD")
                    .HasMaxLength(32);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCd)
                    .HasColumnName("ZIP_CD")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<TUserInfo>(entity =>
            {
                entity.HasKey(e => e.Bunho);

                entity.ToTable("T_USER_INFO");

                entity.Property(e => e.Bunho)
                    .HasColumnName("BUNHO")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedIp)
                    .HasColumnName("ASSIGNED_IP")
                    .HasMaxLength(64);

                entity.Property(e => e.ConfirmPassword)
                    .HasColumnName("CONFIRM_PASSWORD")
                    .HasMaxLength(64);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CREATE_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("CREATE_USER_ID")
                    .HasMaxLength(16);

                entity.Property(e => e.DutyType)
                    .HasColumnName("DUTY_TYPE")
                    .HasMaxLength(32);

                entity.Property(e => e.DutytypeName)
                    .HasColumnName("DUTYTYPE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(128);

                entity.Property(e => e.JikgupName)
                    .HasColumnName("JIKGUP_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LastLoginDt)
                    .HasColumnName("LAST_LOGIN_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LockYn)
                    .HasColumnName("LOCK_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoginYn)
                    .HasColumnName("LOGIN_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MenuAuth)
                    .HasColumnName("MENU_AUTH")
                    .HasMaxLength(32);

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("MOBILEPHONE")
                    .HasMaxLength(16);

                entity.Property(e => e.OrgCd)
                    .HasColumnName("ORG_CD")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(64);

                entity.Property(e => e.PwdchangeYn)
                    .HasColumnName("PWDCHANGE_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasMaxLength(16);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UPDATE_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UPDATE_USER_ID")
                    .HasMaxLength(16);

                entity.Property(e => e.UserAuth)
                    .HasColumnName("USER_AUTH")
                    .HasMaxLength(32);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(32);

                entity.Property(e => e.UserType)
                    .HasColumnName("USER_TYPE")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TCommonCode>(entity =>
            {
                entity.HasKey(e => new { e.CodeType, e.CodeId });

                entity.ToTable("T_COMMON_CODE");

                entity.Property(e => e.CodeType)
                    .HasColumnName("CODE_TYPE")
                    .HasMaxLength(32);

                entity.Property(e => e.CodeId)
                    .HasColumnName("CODE_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.CodeComment)
                    .HasColumnName("CODE_COMMENT")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeName)
                    .IsRequired()
                    .HasColumnName("CODE_NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeTypeName)
                    .IsRequired()
                    .HasColumnName("CODE_TYPE_NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeVal).HasColumnName("CODE_VAL");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CREATE_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("CREATE_USER_ID")
                    .HasMaxLength(16);

                entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMenu>(entity =>
            {
                entity.HasKey(e => e.MenuSeq);

                entity.ToTable("T_MENU");

                entity.Property(e => e.MenuSeq)
                    .HasColumnName("MENU_SEQ")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImagePath)
                    .HasColumnName("IMAGE_PATH")
                    .HasMaxLength(256);

                entity.Property(e => e.MenuDescription)
                    .HasColumnName("MENU_DESCRIPTION")
                    .HasMaxLength(512);

                entity.Property(e => e.MenuName)
                    .HasColumnName("MENU_NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.PgmId)
                    .HasColumnName("PGM_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");

                entity.Property(e => e.UpperMenuSeq).HasColumnName("UPPER_MENU_SEQ");

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });
        }
    }
}
