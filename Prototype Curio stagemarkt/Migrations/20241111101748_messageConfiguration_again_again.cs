using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class messageConfiguration_again_again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Students_StudentId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_StudentId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Y8s1/aZexnbDLRuJLzYajc606ui8DdrSMjNM0mFJ8BQ=:DIl4zKY6NlRpZUrwD6Oo4w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "cdzQt8aRSXc+Z5rhgIsn2DhsmCI086JFdW0Vtzlg1og=:UCtHz77Lomw7KY5RdH8ZeQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "WPxrcB95r7+ADJFjypvcCYEHP2f0JZYeZ4S0jY73eWY=:Ly8yTDKwZHrhINvAZwfLGA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "slSURy31SLlDPo3AQj9t4i5ikGjWWA1Czt1zUCx6P7o=:9DwZMucM6gYr9pBq7sh1XA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "Q/nkax99guO5d+d8ilh8gbRBV1Y88JXFKevoBx3I7L4=:gA9wTbrDXzn63H/mSBKxdQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "XXdOdl0sH0MrDZymAAkMFYPEyS5OhjQJhOy/4DBO7/o=:ezNqKiufbXrFfvs3qHkyGA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "96eAyApMNV2vfQk3vIWw5Y1l4n1XHwTuYBPWV1EwqYw=:2h31oz1X1yyfJK2fOc+uww==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "BVwoqOa65gOyUD30wLf4vjCQyBjqm6JnNwSffL8IcZU=:0RRDc3tz8MU+H7qYa9AhHA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "/1WTlhEX3akouKKX/DWrph/kAwBu7LMb5Ik/GLkV+OU=:AVmbyctOKPq+sv0PD46fJQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "5lUa/Th9axvec3wRyCHvL4r22IpKMDRsHI5vRr75Gcg=:kvhdh4dO55dG6E0O1muTmw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "BdQEy/W94ZWcWjsCcS0KayVoM8qtF7YozArTuCw5ybw=:YysAVlFcFL2DhybPhBVT5Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "XHPV76X682m/7ZjEVW2PSSOqbLlNErNMUCZfFZA01zk=:wV+7ND43T3v0hJ7L+S6t+Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "bK3z01kSNuvUEWDOg3ngQUQVUPu+/7DndH3N7b/YSzE=:h3IQD2brNeaBCCgXfagLqQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "u7+sm5xc+v7QryAg5ysXgBV2ZYhcI+ATabeRXiZByZg=:fD4/I9qq9cZDX+g9H1xSXw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "FmxstyT17oHklwWjofyRUFsW7/FbTAI/x+sPWloH8Ew=:ucF3dA926ck+x/KkOKGtEA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "MWjLx/uLaQOGsve/EcFPZm5aPLEsvm2su1YHtCBxl2s=:8zkhcBvyTWfKuju+4smR1Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "YSW7qwwW0VukOS3fxDVEOFjVokxseao2ZIeEXDb2/Fc=:juuXeH5t64lUhcW/rAfiqA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "U7r3Rb7OJQl4dCk5TLaxkUykR7RpcK9WMPbCEwBDb7k=:/OEjsV2X2M83Kzjoh8sQEQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "QumqgkSsNFGAP6mcwRD6KSBg/bKa/a4V726rZHPXge8=:KE0JNFRuNqJ6vHbBqt0xPQ==:10000:SHA512");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "DCnviR8fUhBHS0OQZIJrRmKdzNB7Gskct6xY0cibLM8=:tKHimR6XTgJZGjSie26jiA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "rNLc2bW86JLA+VOUPbY1caivUcNATvg04qzz6RS9PKk=:QzmST1cyseJG+V6lC13EWw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "hfwwuaqyofLHp+1LAeRu6taYSXovBI3laJxFENBLSfQ=:KONYW2dOveSFo0i0mCU5hA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "pROkm2oyWZP5sI1ts/gVzEUh8ygPUbY5mYp7qel0yIU=:8nyfSFGTr3J/Fk6QPr5knA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "BxhlqLPcapID2N9GtJMNCTRsFlHPyaPG/6y+Z3p7np0=:XZKTg1pt5t6aobCm+hgymQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "52KfuumebwGkUhs9+BuDAHRw9unZcONPLh0pGTgao0Q=:NI99bdxqMlpacTHqRPY4HA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "cwVSsMEuld0U2S59+DrV243/670OE8PJ6/fKwjYz+K4=:7gec58BN7BcIb0iHjjpC8A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "HQKpIXaK8F+EW8Y/1QlM8W7ci+Eo9OKX2EF+hrPWbqk=:XdproFBjMJYzhpI1bTis2A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "YmeBEW2rWxaeqwQhPcb5cynwSIf1gbzQUx5GMxh8iIc=:8iZRiu6zfWstuMoOnklw0A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "ILswYJ72nTTxq3cxTJITZXue8Msd/SiARWhKl+dRoB4=:SlXM4rtz9/U5ZoYWS/YBxQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "1XPPN4wiUbmEL9LHA/NRewwWTwkYyfqoI3Jcu1M/zNU=:C/7mBy1yHOxt994wk6ObdA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "B/ZPFXNDO+emPXKSc4EQ2mawI2U2FJq5ajyoYoMleK4=:FsYVA3s/r2ZvA847pmILbg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "UiVfa/qIipnIaWiF0bfQGulAoiYdNIBO7G1mcvv2/nA=:Nu+TiD2VNgxRFWUMZYha2A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "mHIVfmpUKgSBkRFNChyqPDl5QeYGDbFF2VbF+AkKTd8=:0nGmzp7swodCmn2W0y6sGg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "3KjuMxi5UapmP6jU1A9MYK4DzINUnMrRU4PycuFOMFM=:uP+3Vl2wWDcA3JJbhwHa2Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "KT/E2uq6K6KTuONV561+B1WEkQB1HLf4BuOBIVqOze4=:kgGj7XQjP3w1HvxUNFv7kg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "6dOVYbgtRpHpOq8LRn9E3QOrSnb08plO0g7aFxbixJY=:+vg8PqR251qIRtV0Hi4EWw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "Pn1Hy5Qh7FwgQ+K+1HlcDDVoPaEF7MscWYuSnb9ml8Q=:gUIkKYhssBRXnWWkfDDxgg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "SLOkcDE+F1xE+AXfDOuLQsei+WBpIzk4iKfcQRVY72c=:yd6JObz1BzHIHfwVpB8UQA==:10000:SHA512");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_StudentId",
                table: "Messages",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Students_StudentId",
                table: "Messages",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
