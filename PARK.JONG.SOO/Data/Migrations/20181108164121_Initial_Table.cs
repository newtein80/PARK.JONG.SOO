using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PARK.JONG.SOO.Data.Migrations
{
    public partial class Initial_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_COMMON_CODE",
                columns: table => new
                {
                    CODE_TYPE = table.Column<string>(maxLength: 32, nullable: false),
                    CODE_TYPE_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    CODE_ID = table.Column<string>(maxLength: 32, nullable: false),
                    CODE_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    CODE_VAL = table.Column<int>(nullable: true),
                    SORT_ORDER = table.Column<int>(nullable: true),
                    USE_YN = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    CODE_COMMENT = table.Column<string>(maxLength: 128, nullable: true),
                    CREATE_USER_ID = table.Column<string>(maxLength: 16, nullable: true),
                    CREATE_DT = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COMMON_CODE", x => new { x.CODE_TYPE, x.CODE_ID });
                    table.UniqueConstraint("AK_T_COMMON_CODE_CODE_ID_CODE_TYPE", x => new { x.CODE_ID, x.CODE_TYPE });
                });

            migrationBuilder.CreateTable(
                name: "T_MENU",
                columns: table => new
                {
                    MENU_SEQ = table.Column<int>(nullable: false),
                    MENU_NAME = table.Column<string>(maxLength: 128, nullable: true),
                    UPPER_MENU_SEQ = table.Column<int>(nullable: true),
                    PGM_ID = table.Column<string>(maxLength: 64, nullable: true),
                    MENU_DESCRIPTION = table.Column<string>(maxLength: 512, nullable: true),
                    IMAGE_PATH = table.Column<string>(maxLength: 256, nullable: true),
                    USE_YN = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    SORT_ORDER = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MENU", x => x.MENU_SEQ);
                });

            migrationBuilder.CreateTable(
                name: "T_ORG_INFO",
                columns: table => new
                {
                    ORG_CD = table.Column<string>(maxLength: 32, nullable: false),
                    ORG_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    UPPER_ORG_CD = table.Column<string>(maxLength: 32, nullable: true),
                    ORG_LEVEL = table.Column<int>(nullable: false),
                    ORG_ORDER = table.Column<int>(nullable: false),
                    ZIP_CD = table.Column<string>(maxLength: 8, nullable: true),
                    ADDR1 = table.Column<string>(maxLength: 256, nullable: true),
                    ADDR2 = table.Column<string>(maxLength: 256, nullable: true),
                    FAX_NO = table.Column<string>(maxLength: 32, nullable: true),
                    USE_YN = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    LINK_USER_ID = table.Column<string>(maxLength: 16, nullable: true),
                    LINK_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREATE_USER_ID = table.Column<string>(maxLength: 16, nullable: true),
                    CREATE_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATE_USER_ID = table.Column<string>(maxLength: 16, nullable: true),
                    UPDATE_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    SORT_ORDER = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ORG_INFO", x => x.ORG_CD);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_INFO",
                columns: table => new
                {
                    BUNHO = table.Column<string>(maxLength: 16, nullable: false),
                    USER_NAME = table.Column<string>(maxLength: 32, nullable: true),
                    PASSWORD = table.Column<string>(maxLength: 64, nullable: true),
                    CONFIRM_PASSWORD = table.Column<string>(maxLength: 64, nullable: true),
                    ORG_CD = table.Column<string>(maxLength: 16, nullable: true),
                    ASSIGNED_IP = table.Column<string>(maxLength: 64, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 128, nullable: true),
                    TELEPHONE = table.Column<string>(maxLength: 16, nullable: true),
                    MOBILEPHONE = table.Column<string>(maxLength: 16, nullable: true),
                    USER_TYPE = table.Column<string>(maxLength: 32, nullable: true),
                    USER_AUTH = table.Column<string>(maxLength: 32, nullable: true),
                    DUTY_TYPE = table.Column<string>(maxLength: 32, nullable: true),
                    MENU_AUTH = table.Column<string>(maxLength: 32, nullable: true),
                    LOGIN_YN = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    LOCK_YN = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    LAST_LOGIN_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREATE_USER_ID = table.Column<string>(maxLength: 16, nullable: true),
                    CREATE_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATE_USER_ID = table.Column<string>(maxLength: 16, nullable: true),
                    UPDATE_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    SORT_ORDER = table.Column<int>(nullable: false),
                    PWDCHANGE_YN = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    JIKGUP_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    DUTYTYPE_NAME = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_INFO", x => x.BUNHO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_COMMON_CODE");

            migrationBuilder.DropTable(
                name: "T_MENU");

            migrationBuilder.DropTable(
                name: "T_ORG_INFO");

            migrationBuilder.DropTable(
                name: "T_USER_INFO");
        }
    }
}
