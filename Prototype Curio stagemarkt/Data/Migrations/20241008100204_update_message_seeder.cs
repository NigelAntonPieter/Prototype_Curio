using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class update_message_seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "PG+SxjqqIsqywxkR5pK51yQfYVGjaY5XwtFAlfeEeeU=:m0FVeph7a5+T4IxRp+B5PA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "X45btdNFTxHCnLYA+AGZi16QAjcr+dv7FubYbWbZdLU=:g1Mr7Y7o/3NbsijcLlB26A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "5fIp4lxe2z9Xcmk+lKv+cjGoRAAg4ArPkhqPxIDGuZ4=:7hyXqpEk5bF6IgBhpZRQ4g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "ynlko5awfOYZFtaxaSTu6QUtoVMw/aflTHhEmGPotCE=:hq8u96q91985E3ruADYI7w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "ZIBUJvUACgpyD4qZQ52qDEKY0DPRWmWEkEHDJtZ39+o=:yuaJsDM6uaCUO851t8NEEg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "ECD+U5GTQdtBOmQgfGGfB2JtcDG2miFkujUTwE6jtls=:eL83vZRaB9vYbcBg1DIuoA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "nXqfXmNvgmaGkEUqvDGKHP1sQepCaxMnwWFEWw8GknE=:V+CaO8qRrbZHwdgFP4WWbg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "x6r/JKV5r9xiKLIePxUFvrdukIB/WbPT4G+o9GZm2hM=:02WgQO1aqu9Wn+OwJe5tEg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "RwYe21aBuD203cnEBT56zsuI0lfWMQ71sqc3eMywEyk=:kPtqssUbwSa8JajAVKx5Lg==:10000:SHA512");

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CompanyId", "Content", "ReceiverId", "ReceiverType", "SenderCompanyId", "SenderStudentId", "SentAt", "StudentId" },
                values: new object[] { 1, null, "Hello from Company 2 to Student 6", 6, null, 2, null, new DateTime(2024, 10, 8, 12, 2, 2, 783, DateTimeKind.Local).AddTicks(9314), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "1TkZtJBi0SDfjQ39mKMUQWRZGszPOUtsbDne4bhJey4=:Apvv3dUotSffYR05BptV8A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "hIlrNVACUjsgY8hY9brICM93QAlZ4pP8wjCMVbQCX4c=:k7NsNGHHhDlB5MAx52mhqw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "nr7e/fhXNn+oQ1YxKZX8juFzm8mBZGUFeXdtAs5LMqs=:SQOfmYLvgTdjZ+Cf+/hA4w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "L6h5y617FrTDw3M3v2ZXJqUL11bOvqgE2jwbH8yC72I=:BVHOVQdU+APcX1CyuIcPoA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "1IOhkLJbKxEdTo+EwAEcgqKLaYlquoCrU+ch/8GK3I4=:CIp9HYmn7M7R5/lyheIj3A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "oQLhnFgj76dT3fZfLo1UTY25trTcqxnDVxKAfsw34rY=:LLcU8vqxTHPkqGo7AZoTcg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "esY4Vi3O+8OAR+lsF+VtWJixqJ5GZw41hAcK/2BovJU=:tR7ZK75YLz5j4UZcuiep8Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "MFmMUZ3liivignsmw+vrYC3dJSSGYjJxkgpESB3NS9U=:4W39gJXU2YKjv6ZKpYAllw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "d6ODmOLHtKUZf09HtnY6rEnFKxoaKDXPxYhFofHnzCY=:esaqcgJ9KUig9FS0nCHN9A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "PHpt3vgAWj8kLelya1Cc509bUMA0FK3dpUYusUVl0Kk=:cINezDw6gzjh0v90UZfqRg==:10000:SHA512");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "li4pFKASUHJlT5Qfs743JeBnA+Hh6OvsNwpG+gTRSo0=:vfryZ7cIe0N25mfMN6fMwA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "II3wrQ42nGd7X0lAjNrKfuvFWorbNb3EsOsw69vxnZA=:TXqKvBPKaaju3ul9n4VNLw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Q+hJPHgfgkre4QrqddeO8pThqzj3aTfvgAhQ3prilzo=:/oCZdGjsCb112R1fOHgjcQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "sx+ZkEQ+hTcJqNq7wTWTC3hX75jqKneCwrYbfLn0kDc=:CRWuJG3xZ6kZMBpkVMfxHA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "w5Mj2wn1jo201Ur8DHeVnppS3gkHtyrvsTSSXRZ6qLw=:8aNDGx0difj7n0JC7FG/MA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "+oNX4Tb2YGh7iNcQbN47eMui8FduYoxtjFE2bx5m6U0=:WsptBUF8XcR4EpzqaShabQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "LtHyqfmnFt4cPDZDPUDGV0nJI6697eKgyQaZlQ6XCOY=:GLPQrXjcilpeWuUhEozHyA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "CArrWJfbCxfdqm6yNT0M8TmcVcbKP1VpsMKhsDkFKC8=:4tUHo6RYB2ckSVi04qpW7A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "ODMNO2Y+4c8TDmhakZUnh9Bj3Z+K21wZkpjEgR8eF0w=:kpQtGdNLiaR+tfpU1GZ6dA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "wnBabam4kQK7R/bUtFmvMmzWa1naIg+j23xUFn6C0PY=:owP5tFJMYlayBp2GUmDjQQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "NWAd7zKN9wW5z6+loC87b+FSncUg8SXCcNDHF6qSbuE=:l73KOhPL7EBh4GeBTWNVkw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "KgFE5Zs2uEFu5jS+xdA78Fk9tF3EnoPVlBbAZ++30Rs=:qn6gNFLYgmAB/+IEMzhD3Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "xTbL4HZXmxoY2EaiJ64BVKCQrdgD+q+pHpYC6jKu6+0=:5+B50WAqtAYRVWNUw1UNFg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "BTZ1JpZdJJjdzEo6E9CdTsAQx+g6QXcMJEPF435RFOM=:tyylmJIi+w49qGEer37Rcw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "w4qzxUKu66SrQGHK7QthoDZAtCBnCCVMwrMONopbfds=:CLArslUZ0DF4drMKhO/LcQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "9MUD/JXBf/moRLY+HYiyF0qHv4Gz1OVA7WhhXZeKNf8=:+71NxXWByMO7NhusBF2EOw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "qtuiOg70LDU4FSCO8FYJhsTJ0oen1l5VU65POlDOLpo=:rjcMrlzLXT315ofye42aoA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "9l2iMv73x+0CSiBLLO7FkwaVsZafSCNDZgfzgpQgpZA=:0lH3rnmznjfMeMVMwBFH2g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "3PpLsIbTI2lZGMCxGnnP5SJYmgh8wt6j2r8aaROrhQU=:0bYX0ZO5rw6GSPIYLdtTOQ==:10000:SHA512");
        }
    }
}
