using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class dm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Messages",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsRead", "SentAt" },
                values: new object[] { false, new DateTime(2024, 10, 8, 13, 53, 24, 123, DateTimeKind.Local).AddTicks(4594) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
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
    }
}
