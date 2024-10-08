using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class skipi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_ReceiverCompany",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_ReceiverStudent",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverCompanyId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverStudentId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "wDgi8/7e3vkKTZs8MH/xnlSZdu4dyTdzcuO2jPDqgCQ=:9hvCiM8MYIfSwrPiZZxzEA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "M6VAUOolQXRKjuHkQlCYb82AO/pixNB/w6TdXHtJBYE=:I1NkPs903pJDsLGu8kPr/A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "zvRcGYsAVmsoVnYgy1dlC+mS3lrN8yzNza8jYy4KtBo=:SwaoNIcrKC092nsb6GCTZg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "eEWQDuc2oMbXvYqFqXe+vF7y32A1ceSHVe9aYDKq+TY=:/wZuvDj6pie5TqL1o6lcDw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "Q8SbYkWM3QIoYlnJ/bJdEpqvqTnIERdwPGTW178ua7k=:5sSRK6GDejYu7k8fmKyKMw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "U9uvq3Lb8VWzaRIV00h+yaKqOdvaZK3hcu2mGEao5fI=:jhC5Z8IacE5lDsQdoMxp7w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "aUAc7HjJEYCiubDdF4hPU74zoPn4Xen9caDjftrcemo=:sDyJRCkGOz8PENSKcw3HhA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "5ZmKqgn8G62OIVo+5sNwlSEIBvAU5zC17W3BcAS2YJ4=:lVoafW3OZbXkyXbYQmqXfQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "f2/UbOFH6r+QHO15uLdOxzT0j+MaZltcRIf/wWtP56c=:yZlTbsEzjSlnXYobLItw8A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Z6D1fXtibk2jNDzxmKeSlqebUxl4bLQDoEAXZYP1sWw=:w9HIy+nr9/62eHv/a5ATMQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "vVf2A8SKyUoECFezexFwfpMC0y/sQwmIlYgmS8o2zRI=:oqo9tfbeIqHKQ6Va65j80Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "UG5IqtirawHRbBdfUVY75Xilgs7sj+RWUc12LUJqVIA=:PBlIo7o5caPRnBqUuXpCLA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "Rkk0XL8ilurWDiexg3lpogTMmh0gs3xZletQsYbpM7Y=:71x+I6zLeW1hZ3qK7YeB6w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "rF/589hDNYAPSiBxPpb3vyMyVJCVefql8kcrhCS7NFA=:iLwXvQGquiwz5hKHKjpwiA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "wkF4h/10xBax/scdCWDLhOHTwJVLSzyqFf6uLcFTNZs=:fVkS42ddVuISZ7Ua+WlqfQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "TVh0hzijGE/7GCASSKMkN/wKrYC3bVfVifZKqhqh/FM=:W0mas3qWa/9eo9deOWxB3A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "D00bfNfGzibU9dakpU36Z+oElUmWgBZ5c6enfy15XbI=:Ot7lQRq3hRquJfMvB5J75A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "Q75AGy031WPp/2NhLGt/7ebjQv+f4F20gI9aMFgG8pY=:ZB8NyP/s9GpW8WRpZauFYQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "WOX2NIJRDUgl2JQWYHO0uYmeQWEmaW4AD2jpOMXGxnc=:zKHkvRMoA8qQI+DLrYglOg==:10000:SHA512");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverCompanyId",
                table: "Messages",
                column: "ReceiverCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverStudentId",
                table: "Messages",
                column: "ReceiverStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_ReceiverCompany",
                table: "Messages",
                column: "ReceiverCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_ReceiverStudent",
                table: "Messages",
                column: "ReceiverStudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_ReceiverCompany",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_ReceiverStudent",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverCompanyId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverStudentId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReceiverCompanyId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReceiverStudentId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_ReceiverCompany",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_ReceiverStudent",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
