using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "o4uZSAne18JU6SHcIClKPM2u9SfnE4+JrUXbHs4d27g=:QRLg8Gk3EP35WfeWE4c8aA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "nFFF64ZMFunmCkCXGUwncxcmzruHdjKFact5klyftwU=:zKzY/WtWndf+IQa7lWPxsw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "4AxBFpd/JP2gxMyQDRMOv/yhx7O5I/IeQMz4SydQhAg=:Uapfm097D7fphNTX/vwHCw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "ni5zSRSQkMGEz3J9zvy4mbi4aMRoPe5tqYDMalcBkZQ=:qkcq5fMyKJQV6zZ8n630nQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "KjLZADCsw+HsxkW0zYYwwqq13K46zbATMYUCob3JLTQ=:KvOLvt2XZUVSN2tVhc1rdg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "6EauRWeEOffuMnirmmcqQEGG1jP3UCjhBPkwLPiQanE=:mXTfBKiBheDHp0qYmAjg9w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "hcbvTNwKwp7UA468LQ26m9w1EpPcW7jBj0DCQb6uEqE=:KmVy/SPM97ARYvEgmSGMEA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "TxJ+a9N+m6kpybEdbxJScy5s3QiCjM8GJ9gwGSzLwaA=:OUP6SWmpUP1fSpRRyM+nwg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "SbU35tQBXRWB89f55lg3OBXQDNYCbi4oVlU4lT+0JrA=:dK5Yy5t86KK/YiaNEBi/1A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "7QEf3mGNIJH44QNzImZeemEk/4BvOiDL+D+AfKCrQG8=:LiXThXscPB0biL09hLtGBQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Y7dJwlMzapl/q+n/09kEG09K3MqfDQZiv+HQgiTWMfI=:e6bUfdZJ7H3GZr2Xx7MlqQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "3uFXUTfFY8wqBbAOqS5JUoeXs5G1CiMMhEFoeII0HbM=:K/uxlfWDA8pe38yUzam2tg==:10000:SHA512", "FrontEnd" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "lXSyJut1Od+IM/O3Knt/FB89BViKMJC+4oKi5GeZq4g=:mvlnQiI0xBxb1XeSnHVhaw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "+vRNDD+nc9uMtnyVdnUp2G39EssRZ+L2amgN5UiUL3o=:/3ZG06j+9+FsW5XdPebSNA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "Specialization" },
                values: new object[] { "zjZoFkRTOhy9DIXknscnsuXN3PVq2AyZDW0vB4KtBWI=:+Vwf5T5ahV0Is5wqfJC2ew==:10000:SHA512", "FrontEnd" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "ySGeYKoyVNX5EITsWKraig+gAAyYoahNo7UhLR4hpf8=:JUiYmeRbr+OHuzjN3bYRDg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "8pbsg1DJj+tfvvAj0+9BiMirLPVUoue0ornx7A9AGaU=:YN1WJHiPZIrXj5AC0SGk5w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "wuD1kz8DcrFYgot5gNK4fmv99xQUxy88vSHK179mgGw=:cYw2Db/bWI6jdclixvt6KA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "fHOVuJhMh1LcW92vcwle+5qL5DLIK4nbMpy5csPflTU=:91fnaYEl2ZMDhureunblaQ==:10000:SHA512");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Password",
                value: "FWNuouaGuUUDvoeKiqUBllhWvytnJCd/9MNanGOkr8E=:70oNWhFZ8fPesSExHfnGuQ==:10000:SHA512");

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
                column: "Password",
                value: "UAiGnIsSbJfh0RvUXeDtl9vTT1i4EnMeEx/C+GC8rnM=:oNUcXsBZCzz5qHLKlmLF5g==:10000:SHA512");

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
                column: "Password",
                value: "dhvrHc+u/huXe2t65EoI6/4zAEzqkIF5bdJ1mUc0skI=:AzX7RZVEbrhnPKNAXr7pXA==:10000:SHA512");

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
        }
    }
}
