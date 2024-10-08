using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class update_message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_SenderCompany",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_SenderStudent",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderType",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "SenderCompanyId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderStudentId",
                table: "Messages",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderCompanyId",
                table: "Messages",
                column: "SenderCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderStudentId",
                table: "Messages",
                column: "SenderStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_SenderCompany",
                table: "Messages",
                column: "SenderCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_SenderStudent",
                table: "Messages",
                column: "SenderStudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_SenderCompany",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_SenderStudent",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderCompanyId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderStudentId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderCompanyId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderStudentId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SenderType",
                table: "Messages",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "y/PhAYSzm/GAnKeqysnhu6I4EN6fEZOYBkfjzKs1Ncc=:ItgNQFtLbtTTOEtzG29ijg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "ARSKTn+c8KLzYVcysu8JLWlFwcyE1fxCvMuvSiOFFVc=:QXOnaJFS1aonzn7o2KweTQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "HUWLrSGx4/ioU5kth9anUp4UEsc00BxbwrIIsu8jp9M=:X0JVUTMrDx+jDC7gBeUdgQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "xulxCRbtqJfovVr/dvRS4FoH4OUCwrO4TyQJuY8FPgg=:kXOoFoW3FAy/H2wsyJUlOg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "uUJirUnXNMFA2/FWdjVgRNzhIPncV03+sKh+JhwclAQ=:09idHX3gOPVClEAvWS0fqQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "kJcwAAaPfU4S59lp0auItBFi6BpabEHhDv/GbyWXn9g=:8qoSdbzu10fxpIjyYcSYYQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "uUxY/Yvvm2iPm/xP2TopH3YN2wXaRESP0ImD4kv873A=:aRm8AimpHsd0obB5D9udSQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Ak3Y5DQTJtdDuI8JVvL7pzGqfa/8NerZv3fw8oT3XdA=:QALRrT8GLGvPwCryGqU/2g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "PCo91NiAHYSghXKPR4/cv7XjiVy/oPRocahGGs9P6BA=:61SBAqcHKOsEWGbUfrMWjA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "o5oKDCeZn78fOktl1fOWSfO340n+PTf7YvIyo7afh4Y=:Gpv+x5N1vLqXgMOB7674pw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "fhlgxve1ilgSdiIGjdiekx9CsHptasbxvUIwrbwmj94=:R+0IgPrf24S2TzrrOUeWeg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "zSj37WF400oAZWSopbxSwjE94x/Nq2PAeC/qV/6KbDM=:diElEq93Lz0sIMWqtzASaw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "ed3Nlh//D/GkglL72aHGptiitI23oZv7IRtn2Eyl9JM=:NMYBLCu11NDLYiEvHXRb3w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "qtxe87WLnCp0MShm7PML173ocveXmgTR3xNxjSN75Qo=:Iit3z1TvtMIvS8EDqL8wjQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "ZBdV7uHjw7L1/D3p7CujKVBaQAZqDdZOyCWqiuc4bqs=:S4PolgERPbGm6EoHz+wBjw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "2su/unb/zepULz7ub4rJlEJR9thc30pN+LXm0hmPlMI=:u3aAlIC/HSrU/FjyAhJ45g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "NNx4ezVPF8c3063ZSgyVqbRrm2ZLf2IoIzKNktRxBN0=:PnWAswmjFVY2x18Sxvz9RQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "6hk+DnbwgYjY29iMxDLwehOaggrPLBBkzWZJiYQaKMA=:WjQ1hzY/v5Gte2XkB1p8TA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "HoYG2iw5STZ9G2hPKav6E3lKtzRXB49PpcJkS06SgAc=:NGKlS+qkdM1QO7tL+WHlXw==:10000:SHA512");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_SenderCompany",
                table: "Messages",
                column: "SenderId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_SenderStudent",
                table: "Messages",
                column: "SenderId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
