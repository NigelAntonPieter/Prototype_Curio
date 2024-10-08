using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class change_message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverType",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "d5utq+ezHRwQZZYmLw+3+5SxCANS5jDA+ZYBLRR0KwQ=:lfdN40iD2Ougjc2159IS4Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "9LHwxFEsC3jNBzOJgBSsviuDu40H0tr6g9s3+4loNz0=:GaBYbmus6BKWRdVbfn4Jsg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "WRTcXN5DMRnMzVdtqk4M6FpyyP32C9h1sgdLzRjjlSQ=:N9Lt3uS7dejJqfY9ih/Pfw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "8X3t0wyZ5FUvqayyk+v4LofRyWO8gMZQI/GIn/XYp2k=:u1ErEAUdb7gcSukjh4XnzA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "UHsBhmTf8E/zefISWZb5nuwUC7ihejauXq1HzaRVwx0=:MlkIBd01KW1Od1zrM0j4tQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "c+gE2yJ/FHXivtjBZ1QSZ8phZ+4lg3QLQUI7RusmeJg=:eOtOo98+wLLWCJWZQpGJpg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "jcANumXPMS2jIAXeKAa20yMG2bZD4HkOPzgApPuwR0Q=:BmidKl18pD97u2WVh6nbRw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "lV7Ex28KR8JTaIl94rG/MNs9K+nQDcgJ2MDP7cHP52Q=:GGEfUoOHVShgqa+aKzMZBg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "hCgySDfXx7SCH+d3o04voWZ8Wy8UCcSRTJQ/y9IM1Jg=:avVqeaKE3I5pRPKxQppxmw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2024, 10, 8, 12, 12, 55, 338, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "wroD5d9dUFRqa2ecyyxvNvZGr1S2rKQVbEVe+y1JiM8=:IHNuQhpoUqIQXtincqHDlA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "VQgIBQfTAaOScuL4UsvYEH5Co4JQLgS8VZpAdz+0ErA=:9/wGO7O30jcUM0PB49n3rw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "EWtnJ2RBhqkCFzMwB9q0kbkfzKv1Cjs2UmA24D/oU6w=:tmvWwllTJJ4wzwrDMzcczw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "/itCgr1jkOGXRZyAsW1Iw1LWcUXda4Sy72/hZyTxcEU=:5JgtqoYJCEx1Y8sW2JNTqA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "REdZRj7ef2OKz5yRGi0K1QR5H/oh4pUT0zeaxhX4Kb4=:uRCYxs+gHP07YzkyWDYvGg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "XjjoylGLmlMNpLOJqI/VI8BVDRr89gMDcCS4IEEmwhI=:Huifzz/tk3Xi+48Q9mULDg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "16oZlBob6UXIeMkgrNLPimXh3lmUTlTsMYh4bGCpAYY=:AAN+03CmkTgU1rno+CGqXw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "gSZydZqHN0i59Dnb9JxuVUBhn4DFtrhxSdX1QlnhJZY=:5iGIsxyJIztn+RtTnp5YUQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "WIqK5C7CpyzAsCECZosU9yb2ReElZX3xjdQiJ0WZmIo=:bnhyRVxoglCMFP8YytdzEA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "01tEztcrCDLzCxZolrm1iUXDZLE9Jt23p65QvNVynJc=:MUCsjnjqHnHbAVd6BNR6QA==:10000:SHA512");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverType",
                table: "Messages",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReceiverType", "SentAt" },
                values: new object[] { null, new DateTime(2024, 10, 8, 12, 2, 2, 783, DateTimeKind.Local).AddTicks(9314) });

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
    }
}
