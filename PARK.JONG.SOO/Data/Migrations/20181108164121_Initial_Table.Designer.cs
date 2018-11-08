﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PARK.JONG.SOO.Data;

namespace PARK.JONG.SOO.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181108164121_Initial_Table")]
    partial class Initial_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PARK.JONG.SOO.Models.ManageViewModel.TOrgInfo", b =>
                {
                    b.Property<string>("OrgCd")
                        .HasColumnName("ORG_CD")
                        .HasMaxLength(32);

                    b.Property<string>("Addr1")
                        .HasColumnName("ADDR1")
                        .HasMaxLength(256);

                    b.Property<string>("Addr2")
                        .HasColumnName("ADDR2")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreateDt")
                        .HasColumnName("CREATE_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CREATE_USER_ID")
                        .HasMaxLength(16);

                    b.Property<string>("FaxNo")
                        .HasColumnName("FAX_NO")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LinkDt")
                        .HasColumnName("LINK_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("LinkUserId")
                        .HasColumnName("LINK_USER_ID")
                        .HasMaxLength(16);

                    b.Property<int>("OrgLevel")
                        .HasColumnName("ORG_LEVEL");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnName("ORG_NAME")
                        .HasMaxLength(128);

                    b.Property<int>("OrgOrder")
                        .HasColumnName("ORG_ORDER");

                    b.Property<int>("SortOrder")
                        .HasColumnName("SORT_ORDER");

                    b.Property<DateTime?>("UpdateDt")
                        .HasColumnName("UPDATE_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdateUserId")
                        .HasColumnName("UPDATE_USER_ID")
                        .HasMaxLength(16);

                    b.Property<string>("UpperOrgCd")
                        .HasColumnName("UPPER_ORG_CD")
                        .HasMaxLength(32);

                    b.Property<string>("UseYn")
                        .HasColumnName("USE_YN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("ZipCd")
                        .HasColumnName("ZIP_CD")
                        .HasMaxLength(8);

                    b.HasKey("OrgCd");

                    b.ToTable("T_ORG_INFO");
                });

            modelBuilder.Entity("PARK.JONG.SOO.Models.ManageViewModel.TUserInfo", b =>
                {
                    b.Property<string>("Bunho")
                        .HasColumnName("BUNHO")
                        .HasMaxLength(16);

                    b.Property<string>("AssignedIp")
                        .HasColumnName("ASSIGNED_IP")
                        .HasMaxLength(64);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnName("CONFIRM_PASSWORD")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("CreateDt")
                        .HasColumnName("CREATE_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CREATE_USER_ID")
                        .HasMaxLength(16);

                    b.Property<string>("DutyType")
                        .HasColumnName("DUTY_TYPE")
                        .HasMaxLength(32);

                    b.Property<string>("DutytypeName")
                        .HasColumnName("DUTYTYPE_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnName("EMAIL")
                        .HasMaxLength(128);

                    b.Property<string>("JikgupName")
                        .HasColumnName("JIKGUP_NAME")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastLoginDt")
                        .HasColumnName("LAST_LOGIN_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("LockYn")
                        .HasColumnName("LOCK_YN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("LoginYn")
                        .HasColumnName("LOGIN_YN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("MenuAuth")
                        .HasColumnName("MENU_AUTH")
                        .HasMaxLength(32);

                    b.Property<string>("Mobilephone")
                        .HasColumnName("MOBILEPHONE")
                        .HasMaxLength(16);

                    b.Property<string>("OrgCd")
                        .HasColumnName("ORG_CD")
                        .HasMaxLength(16);

                    b.Property<string>("Password")
                        .HasColumnName("PASSWORD")
                        .HasMaxLength(64);

                    b.Property<string>("PwdchangeYn")
                        .HasColumnName("PWDCHANGE_YN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("SortOrder")
                        .HasColumnName("SORT_ORDER");

                    b.Property<string>("Telephone")
                        .HasColumnName("TELEPHONE")
                        .HasMaxLength(16);

                    b.Property<DateTime?>("UpdateDt")
                        .HasColumnName("UPDATE_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdateUserId")
                        .HasColumnName("UPDATE_USER_ID")
                        .HasMaxLength(16);

                    b.Property<string>("UserAuth")
                        .HasColumnName("USER_AUTH")
                        .HasMaxLength(32);

                    b.Property<string>("UserName")
                        .HasColumnName("USER_NAME")
                        .HasMaxLength(32);

                    b.Property<string>("UserType")
                        .HasColumnName("USER_TYPE")
                        .HasMaxLength(32);

                    b.HasKey("Bunho");

                    b.ToTable("T_USER_INFO");
                });

            modelBuilder.Entity("PARK.JONG.SOO.Models.SystemViewModel.TCommonCode", b =>
                {
                    b.Property<string>("CodeType")
                        .HasColumnName("CODE_TYPE")
                        .HasMaxLength(32);

                    b.Property<string>("CodeId")
                        .HasColumnName("CODE_ID")
                        .HasMaxLength(32);

                    b.Property<string>("CodeComment")
                        .HasColumnName("CODE_COMMENT")
                        .HasMaxLength(128);

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnName("CODE_NAME")
                        .HasMaxLength(128);

                    b.Property<string>("CodeTypeName")
                        .IsRequired()
                        .HasColumnName("CODE_TYPE_NAME")
                        .HasMaxLength(128);

                    b.Property<int?>("CodeVal")
                        .HasColumnName("CODE_VAL");

                    b.Property<DateTime?>("CreateDt")
                        .HasColumnName("CREATE_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CREATE_USER_ID")
                        .HasMaxLength(16);

                    b.Property<int?>("SortOrder")
                        .HasColumnName("SORT_ORDER");

                    b.Property<string>("UseYn")
                        .HasColumnName("USE_YN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.HasKey("CodeType", "CodeId");

                    b.HasAlternateKey("CodeId", "CodeType");

                    b.ToTable("T_COMMON_CODE");
                });

            modelBuilder.Entity("PARK.JONG.SOO.Models.SystemViewModel.TMenu", b =>
                {
                    b.Property<int>("MenuSeq")
                        .HasColumnName("MENU_SEQ");

                    b.Property<string>("ImagePath")
                        .HasColumnName("IMAGE_PATH")
                        .HasMaxLength(256);

                    b.Property<string>("MenuDescription")
                        .HasColumnName("MENU_DESCRIPTION")
                        .HasMaxLength(512);

                    b.Property<string>("MenuName")
                        .HasColumnName("MENU_NAME")
                        .HasMaxLength(128);

                    b.Property<string>("PgmId")
                        .HasColumnName("PGM_ID")
                        .HasMaxLength(64);

                    b.Property<int?>("SortOrder")
                        .HasColumnName("SORT_ORDER");

                    b.Property<int?>("UpperMenuSeq")
                        .HasColumnName("UPPER_MENU_SEQ");

                    b.Property<string>("UseYn")
                        .HasColumnName("USE_YN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.HasKey("MenuSeq");

                    b.ToTable("T_MENU");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
