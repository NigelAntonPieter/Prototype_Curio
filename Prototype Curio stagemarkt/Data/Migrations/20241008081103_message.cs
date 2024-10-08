using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                table: "Students",
                newName: "EmailAddress");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Messages",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CompanyId",
                table: "Messages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_StudentId",
                table: "Messages",
                column: "StudentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Companies_CompanyId",
                table: "Messages",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Students_StudentId",
                table: "Messages",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
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

            migrationBuilder.DropForeignKey(
                name: "FK_Message_SenderCompany",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_SenderStudent",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Companies_CompanyId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Students_StudentId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_CompanyId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_StudentId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Students",
                newName: "EmailAdress");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "4ZXfWNuJ6GLtSI8RTmQQbXFv1ze1368ckHIOZHq635k=:CryaJGZoh/2qHqfnG8YmAA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "owi+OX98PGsKjd2Z6lEEcp9hBtSjHhfZD7Jwa03svJU=:2UsnYWk4ocjdCu6hPYs1dg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "k33rwX3T9z+xpBgfD0DeV7+cihmNj00ClkCOqkajOrY=:5y7KxCjFxbqmn6Zp9uKh4A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "5QjzbgVHms0mCAveJqdm9JP/oFtXmnUnagLplhtX+h4=:tY4Bz0L+nnQy7OSjrg4PmA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "GLDOaZijYGboppTOxFNf0vIUtO4ZaVxKZyBwci+l+4E=:Kp9zHVQdhzKyaznTuKB6Lw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "z1hXFqfhUqpNgEOlwlVHgT8EXXPQTrjxIELiLgdlHbs=:xGSd1fa/3vr7q4DEouzUHw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "DR3LJmtYAEpjw6Eu2FiqXkOjqJuc78stXbg9flBFAlM=:D7VhVWJ2MbNYSxiyzq7BiQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "ypKT9p0g01+ao4UixpfCXEHusYyw7tAh6JIIzwlk9KQ=:suthcLRII5t5b96WzQGMDg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AqgUdKhuiM08t+NOhPertRwRQ1RH4W+6OnwpF0Y7Ye8=:/aF0GybTC9UlG0Q0G1uafA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Lm+uaTS4/RXiqv4FD89ZT9TKGzj5Tab9bCbrfN+grak=:qs5zsKU/JINXy4mxwRC15A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "2Z5dxCnzI8h+L3tNIzLc/OWJrws04tpmSyUbTqD+/ao=:19NI/EPDxP0UkkLcMlZQxA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "H9dIQ0+15Qpygyfa2WvDa8GcvFBgEsu6O7XXYCXXyyM=:b9Llz0wYe3pHXD9ngQBqPQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "+HIVGy30ioA48zOEqbHtFxd5UYeqyEzwHwbX+AmXBi4=:MxZasV1FbXXxsUjsNUbB0w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "Vdat7ytymAJGi/uPm0/3YwLQYepbIjWkM6m5ix/hI0M=:LC6xY+k5o/kCvJ4HWlWncg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "FCiky2v3P9Ro5FiUQKHwa+DaXtv+6zqCPBUTXxXI//Y=:VU7JXA18BPqh1eXavcr8Hw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "zIPBk21v4/eHJmBtDZA5BsRGm6SPn+pZJBEPubmFk9Y=:UKTFktoS3tTNoFPB6JeJOA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "6GW9SzDIyXJ2qfDQeg0eUEz+jPTnsjsrRr1heg+0Ebo=:xiym8kxR74ySVQ00uT3M1w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "7gMsCCr8hfTC5XJG3LHKDlfAmmRAmpAlW5xJkJf9xYU=:umOz4ughTR7866loJZAkdQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "aoX19Kz95xfmjyy3avgzIj+Gb/tjRvq56QTjq7Y+uaE=:gz2K/qh1/vxD0yS9SoAblQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
