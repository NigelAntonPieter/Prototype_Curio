using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class chbage_student_seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "PWiwhrzrpteOv4hMFWlbFiFTI3fPMC676/dv/APwrvA=:YLMnZJh94db2zFEEnjAQMw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Ckn5g1QXdLSXy9sKm6r2rQPP8Jzo3j4x2q7o8zt9sbw=:JL7N2VOySEYo43WEjwIURQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "pFooY/Qwkz2coX8XCSW5SZf62mVYDE4AV4HOXdFamqE=:EvKcK3jmdsbfJP81sOA14Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "jkZXk9yuhTOWj31ppn6v2F2nzRmsmCQdBqi7KrBkNV8=:PtkVFWtoBk/xiH85dgiDHw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "UqMOxlYvrPypWX1NX8LUBAlv76It6C+3iTiTtzaGrJs=:6knK+Z7mbUqk5l08Oer3jQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "D9SpyYDj9a2MyylaPGiCFq4qaU2WlgRc8GfAOE5qw4k=:geVuS+jRiIskZVPklMRi0w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "uZw4BS3MSGYXtUdIxS8c17xc3MPG4Ct9YBnD4TNA0i4=:IWYyGyxHiWBboIc2sglWqQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "o+IDokGWm/K7yYLGZXfyrh5zkBgKB0ifQb5DNfah4do=:XAS0OZyfbiidifalMVeq0Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "SL9f0HLvVfDqR4pTJWa4YujczVI54ayeK1RZefl+UNU=:V3X/zzXYU40T5hqXFwF+Hg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "25qUbIDoz9GpXFAsJHmG4b2pf/fSFyj/j67BDhmEdBI=:cXSOpRqfKqsqPAyyrCov7A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "FWNuouaGuUUDvoeKiqUBllhWvytnJCd/9MNanGOkr8E=:70oNWhFZ8fPesSExHfnGuQ==:10000:SHA512", "Web" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "gm0CKuwButZE23wzozGTw/dxAgyd+nOr2ktTWVD+E/0=:CyWg6fPVoAlZkicQOVo64w==:10000:SHA512", "Frontend" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "fdHhpJRTfR7v6YHHXa+Y2KMlIilfGcx0lK2NXt+q7l8=:Br//GeOvDQvErfnXd+SRsA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "UAiGnIsSbJfh0RvUXeDtl9vTT1i4EnMeEx/C+GC8rnM=:oNUcXsBZCzz5qHLKlmLF5g==:10000:SHA512", "Web" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "B3/a+CVpj4dlwXyAC38IwBM37fOZA5kXwurpgbeVm0o=:jJKnwXmb0LkN/uS7RYsUkw==:10000:SHA512", "Frontend" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "rDPyEFqElwbALWiXvQ2XpWgaqTQKTqjz6B6sP2eJ9Y4=:MqqS75/+IURximyL3F8pkA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "dhvrHc+u/huXe2t65EoI6/4zAEzqkIF5bdJ1mUc0skI=:AzX7RZVEbrhnPKNAXr7pXA==:10000:SHA512", "Web" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "+e53+g8nu9lhHpQwq7zbQ9+D1Frjs/OJ/pfSPPTzxb4=:GBxBNBR1UUHWcmJ0TYJv9A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "4Ipa2zem1MbN8qHTX3SoNlptFrNEci/Vw8M2TvC7eYk=:VgYSxpkCK3tXof7gh6GHJA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "WorkHours",
                columns: new[] { "Id", "Date", "HoursWorked", "Reason", "Status", "StudentId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 1 },
                    { 4, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 2, 3 },
                    { 5, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 4 },
                    { 6, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 5 },
                    { 7, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 2, 2 },
                    { 8, new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 3 },
                    { 9, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 2, 4 },
                    { 10, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, null, 1, 5 },
                    { 11, new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 0, 6 },
                    { 12, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1, 7 },
                    { 13, new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 2, 8 },
                    { 14, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 9 },
                    { 15, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 0, 10 },
                    { 16, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 1 },
                    { 17, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 2, 2 },
                    { 18, new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 3 },
                    { 19, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 0, 4 },
                    { 20, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 2, 5 },
                    { 21, new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 6 },
                    { 22, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 2, 7 },
                    { 23, new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 8 },
                    { 24, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 9 },
                    { 25, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1, 10 },
                    { 26, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 2, 1 },
                    { 27, new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 1, 2 },
                    { 28, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 0, 3 },
                    { 29, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), 2, null, 2, 4 },
                    { 30, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 5 },
                    { 31, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 6 },
                    { 32, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "+ls4MA8+KzICHz3KPJVo4rT9kEm5GMxMpaMmYhJoVRA=:GgHdJ91Buz/mNxAi2GvtEQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "APXSzduSaSZw5gqWn+69pmTT4ngGgt6z4NyAtTK6LRg=:wugqYITx6lclPNHTJV27tg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Y3UF3JTfMxvZ+rDABGQ93/ir2x7wo5dw8Y7bAeVPaWA=:YOpGKVfiS0p5V96uigwRkA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "7xKJCTZsBWargNaMo/rFF5iJFYHabCdmzoNIXCzxino=:ZLU3Nq5EHI7TRN9KhJK0kA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "mbczi9tJUkX+GXPPK9R2btyRHKWHHotC3joqrwFSAps=:6Y0HpqhZoZF70PHcHUAJYQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "FNKhjnMt1oagdxlb/YURMjc9ZMkw9smlh1vI9kPTiWs=:8+QgriWwmSnmC8Vq5pnvBA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "wIxHzhx375gbinbIRmMKPztLafhxlZzJ0MPZlFbQkcU=:AQ3PbKm/yFjsqAPbIXcVBw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "mY3Faktkm04fXoBkK41UnT9DyC4M9xW1DL4P6QNJuMo=:ZlYJxe+uqFzri/0+N6gecg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Y/eNzg4elcZRpUIxdS+SrNJTRRSk6ABh/ZO0wV9gf40=:4+1NmlSOYzkRMxi8NJlmSA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "XT+bboca3zqrJlWNVDHzdX612cfa9SgRPxLHixsa3OQ=:nBK6lw7meyh0lJHepBXrsQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "OKxw+CyIzSTYRFs0DFBETzyhnDIhByPo6fauRY5MEqM=:9ovJl5cjuzSk6NsJG6Wxlg==:10000:SHA512", "Native" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "h5Q2fLg4rg9J1Z9jjMEyENFDldVtSbe5HQMv81SYjpw=:/HmUf0oY/uArG8iL+1zT2A==:10000:SHA512", "Native" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "Jz0YxlQ4LOHvzaCKVrzReA1wgJ3jscdJ3cxKqKtmH2s=:itM8oOnv4Gva7Aay4LJmhw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "ENCj8Wt7G5RscZt3SHW9/LjJ677CAFIqbggX5evNYqk=:6GnIkPAhtNO114QZ8An5Fw==:10000:SHA512", "Native" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "W6xgYqGPnTtMR3fv3v5ndqT+ZYdcpIwp9fucjAYM5OI=:vHNHYOIUs9vVvI/Qr6rBLQ==:10000:SHA512", "Native" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "VpdzhLTBjO0r+Gki5I4o2rHJzdpdIESmB6R5+zSU00A=:brrWeFTY6QWE/9UQlxZFwQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "wN231DJQL+HVoblpClUGzd/TvSN/5s8fSrfLsYtghSY=:9gQMVXoN5Acpsg39X8ziTA==:10000:SHA512", "Native" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "dRjLyS9motIQBN8jD12Go23jOugtqsutaFUp3+w/X08=:nFy7VCBmQm1p2Xo7EfVfKg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "LgisEp2srvNDYvQMO/DHsyD7MUpYx9qhCEOysdM1iiM=:vwDoq6r2NvkicNDd21G3xA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
