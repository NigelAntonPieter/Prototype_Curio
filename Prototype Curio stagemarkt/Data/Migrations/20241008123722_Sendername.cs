using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class Sendername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "27D+VivEvJgELi+z7qVjHe9+OrLcXn2YlzCIYHh2oKo=:GBYW+/kGEPtk6NWKbswyAQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "qtaaBEuR81/yCA5dS0hU5ALtVE2xL029hnD/IJ4Few4=:2Sz+0VaAkPchxoLtfz7XpA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "HTGF0aTCWidS04qgriEy9n0zLvwgAu7a0VyhJl3dGiw=:h2ttl1lYtyTggJ4MbnXFjA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "WIU/11kBcwjUF6V2SaayS6I4ohyr2038qdWzHoBGB8c=:UCtwDr50ZK387QBo5C8eSQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "tj5++1v+4khO2rFJzs1ntlQJWMoCdPqE+XSmLo6g24k=:AM3+AmRgz4uOCWPJ2DNkWg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "daQNHqBNMAD+b2/73ecmMKw/KDSWwnQ4vbEOW/FiEGU=:2KWO99HO6IMgVDk9MXCXmA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "UDhEDiUI8BI7DxQLHFaDO6tGyztqN7RBlvzcV8bYosw=:fhQ76X9+9eFclbEV5+YByA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "5CvvNueyLf5NHvv5Nz8LDaYZd156KeknCkoRVmk9wzA=:SUmOXlrC6t0t8W4848A1zg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "VBDWRuNH1+2OgYFUjtvoYy7tRUYnGsWp0GgWyb6m5vM=:AVD1V1UFuZXqV+6AgFbLxQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "TBHBQrxIazTETPdY1D5IcT/lbx0XoHe15gMNgjutiRs=:ypJIDq+N8MjcOW4WOjs5+g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "wFchDGg6VL+nrKEqhzLFXqYPcIXxIXz5QLqde5DzGuE=:WSPjULahmjFejOj+FUp5TQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "KReMk9oGzsqUnJBN8NtHMaP07rr91S/bHzRcDdApefE=:CArdWaxixIaOH6Mkd2YA2w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "jIX+mEsi8cL7MkgzfcKMJvWDMLl9oq3b7xUj3Gn7atA=:doHNGro+v2chLViII/68mg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "nmbXJR/L0yJZCr8qx/2nL7NiWD2W6LMw0O0J23NFbuk=:Go70zAGGc11Z7bWmsM+8sQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "YTZ2/IdL8GvUpTqyxkG7HpN6dkJjry+qJr6GMUW2+Zk=:+SHEGjcTZXtCGjXvkjB+Mg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "8YAlHd5yR8WhmeYuKl9pjUXsEeEDhTc7Nbr4CTbg+o4=:5ug47XpDHKanTWDhxIGWKQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "FYoZcLvsOYvZQ5RSB4eVdqF9+iWsDM7vW1ohuwATZ4I=:ME2ddifgatHMBxIrDGY46g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "2N+KO8i8U8b8qsqCgvO8Ll7OzrRS7dFZMAtOWYVsBOk=:a1XXdKaKNDRy7q5PH6TLVA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "VewSWHy0YRxO/vWaQgkGNuKsdxOwQc5GwVgn32SjtrI=:n81vbCaLRWe0VH18CKn3Xg==:10000:SHA512");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "02ftV6WJfYRdRt5Gjzb65eV/c/TX8SX9ywC4Csdw384=:EDdnEYfAqocbBVbBYyDw8g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "9HcEGOfZe8MREe5l6UgHm8a4QlVnYUnC53vwyvVPvf0=:BMQ74HCl8dHc3lH1Vgiz/Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "sag7eFzeeWJNTEo5o+m7WzU/CDmWbiq8j+Jz/wIwhSA=:/bhnMAb6Zlt2gk73iMl8UA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "599SOy3ePdodBBtlJDgXAF1qPOgbvdqkT26CEymyRA4=:vcScSWU5U9T1AOTf/IIlJA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "e1KYc5K0E2GHMTbDDtOZrEZodia+qOgNsLHPOLbqi40=:kyuGavT2NunUKy4eFqiDdw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "fjxIVvmfClKFoN99gsxH+dL1yiSYoY1apJ3JfRuzCCA=:UDTqsFBOjNlFMcCbz8OtkQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "EBW/y+pGuTb9uBRyeetGFZi8ebJiLnf26JLow9ZqBHg=:qFDwQ5eXNDGh+ExN7E4bjQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "xGoWzNCRQDw4DcAoGat0W8AonnmnuIh37sdb+p9pIfU=:ote9MHChjz+k6wW113Vi+A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Y0WWEGoyiV57yVXVIKbo+hYVa5kd0QMYuPhycqmGuQg=:wByOnOPgt6RVLj9X6e/7Lg==:10000:SHA512");

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CompanyId", "Content", "IsRead", "ReceiverId", "SenderCompanyId", "SenderStudentId", "SentAt", "StudentId" },
                values: new object[] { 1, null, "Hello from Company 2 to Student 6", false, 6, 2, null, new DateTime(2024, 10, 8, 13, 53, 24, 123, DateTimeKind.Local).AddTicks(4594), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Xw97efZmc8jZBPR3MbYoFvNSuuAcK82BDZJNNIJC7iM=:p2/k629ByjTGMG4JYnKvqw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "7QkLu16Qu1krqag1T/MfGP//KNeZqIzuyKX5d1vtpYg=:PzFLhq4D47ZN50A+x4QOzg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "bgyw5PChrB6B7r6VTCyXi4I6v4IJLFldGRcXpdHJIyk=:VOTtIa/IhCfgJq7DfE2RZQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "yw0LW510qu6ahaigUJwqficzHxcH/NGR8GLhvnR41Oo=:8BEdS+4UPxjwykhMSRXRVA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "XHYgFEUcxskl9y73481jpZBLgnVYPcR5/Kd/cjK72/A=:DoLE6ttIf1ovAZ/nZZunyw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "7UX+Qf2gySRsb9bYnA+nEesbv4wCCXd+jJVOdiQAiro=:3vaZCx1rj1UJH/okl502JQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "s1OaFx9rr3W+LYvWrnSOuhAj70LJzHD3R0mHlumOyUg=:c6UU3Udk+BpVy3KpZ+PznQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "hxzP1vl5Ripc4SpyrAqFwJ6ta73mE1VwpptuF5rAl+8=:UryjlYqrM1OXqgxKmv+IyA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "kZ+NvD1ca0hpEdY75Ht+yFJ3DTi1ugfeEqnJbrIl2ow=:g/9+gzh7bAf3/qrm4Wcquw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "cXDbrZa5GKyNMzdJ6/yZE90kVJuWtH2PcsGjSxTm29Q=:FA+TRPAzRYfSpdNUQsp5DQ==:10000:SHA512");
        }
    }
}
