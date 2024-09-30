using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class Add_Lastlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Ke0tkgWR8N9A+G1D/K1Ra8wsxkLZb/jH9MQiwBTless=:uqNDg7EUVGlKFKfXWAHfaA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "ZLTK1G8O6XYufOfDlpZ9h3dGumNKOKJ5bHiO7GnZp9Y=:LPzeztXjYlqGK+HerkBqug==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "ZJfEoTDyLV9cCWQlGgfEOy0oVAMSO41MQPpXsbusvTw=:YJyCtDXFvv04We/6zE/+yQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "1fEVUGrS64TcAV8fRFd89jN3m1lba++WGyM1VLMOahU=:s3g2J0KivqXcsj53kLFdwQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "pS7Ctiru/2rR0hXgrFJ0A+kPJg2Wp/109F4phIC+2AQ=:tq0ZwiRyTvhKWD7VBFeAGg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "3IsE1Mu0UFGoqm5V9G7iEHqEEH4Hw8UV2Qi9hVaFwtQ=:/ciGMwcT0PmMlvv0M4Jvqw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "VB/ZKjtZEpsRBDHTzS6IZkDercLAv2Gw+ML3i2Hn7qs=:SfpfIP87/RKT+0/cmDhA0A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "grR28Ny2hQGLKc1B4iwF80eyBWrkz/maTY+crW4UFXs=:+m4bGAA739OPKBesGwVJdw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "THopWGl0TeUbvrgpKEzmdrs+CsAbkWy7wXdelORoMKA=:ebPO1XF5FwjbO5pfaJuNug==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "BGcoHFHE5MuUKCfJHdzigTK7oob24UanWQRa8zpvyQ4=:/sHN5VNVparrgzmPom12jA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "9y5ofrAfNwDDKtvglT1pM7pABFid4IfgyHAbQ3DeGE8=:7C1h20NqZWHlvRnM/WGmHg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "9iaxGb+hN7YnZlNR/bz/xqlFpdrigezG7Er80R9+nTE=:bE+8WdisiCJOzfqg84kFTw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "sBRMePYmiLRSBaTc85Flm3EJFu5IRpKm23AQ1dCLn7o=:QXhNXAHihYWDidnuFg0pEw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "wApodi2/d3dSrvhj5ErW7CklOQyGeq8NEOCr3JVwsuw=:tGUiUasxPKBVrm3O72aC1w==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "r7/d8ToqMo11zJ2P2+6dL2rN1LNGTPZb39TkHLtMaNs=:q1S/9yjZObQVJbkqQk/7+A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "NCBCUTqxzw0GoK7Lun9lINL+Pu0aflW7ZpNphf0JeUk=:sv65V7l0+iCHbgb04aMg0g==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "5ZwzUFORY9Q/F1FvHg/E1GIEtxADsEHNIHP332u0zZk=:cClFk4MlFyL1j6J3JJBT+Q==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "2gUju/6g9rwQT4Zu0nBnHBO+VjZh0JU4sL5Vj767fAc=:xf+uLLfUKpwD1wbWf1rFjw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "3oMIlSH0Ken9PF3cSZc4etGTyytBp0olctz4keIk+TY=:1GrvHcVMVwWQ8Cbo6PwhwQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastLogin",
                value: null);

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "osgriDosmCm7P/3BNm4Wz4flocJmwfl3ZaO3UGd5zpk=:uq9fLAcLag1Q57s+6wssTw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "r8do599o6G59gmyD23axf3cgUG9FpUIBl/WXsuVL3wE=:wqWWrutJX54qazxDK4CUNQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "OnouLchWRiLjK1BrS3BAPVOvf4ZMixSyj+kucD8s214=:oBp/bku5OoXGOfG36ZdsQQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "z33Tq+e14kcLEcTEmxfuwHnqoxctP+8hRux6fTwaEzU=:ijjZyZfem5pIcHUro7kW2A==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "kJ7FZVt7XOyqjgE0xvjxTfr8FTouetjxCO2DKDUZwJg=:D0SJU6VJ81IVOZVIZlZdpQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "AECsSI2IxqtBfHWWLiVBIcQ2PHnOBIOHjiWWGQ6ZUCI=:nj7MIos+lAeKKOUuHuAnPw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "Y53cL+NRdK3qnZq4S9gUm3WQLcfXQ4vtezjy8WzNXlI=:Nzew8Kf3p4pz8dKgF1gGXQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "PGhbu6lDkjFewDIQPbFtJaMR4FABC13oVsoEj2tTtg4=:j45AuD9xCLmSbXbzPXVlkg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "InternschipTeachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "pF2hdItMsfYLOgxr2ApszDTfjyXT7f7PMijBw/xsLCk=:bTvhCarYAnpqP/dH2PxUag==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "prbkM48EHLICaDJDm7/m+PVYsc0IpTt6KrYOa9xq6sI=:pz3poN67286ThsAM/NxaOw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "UlzsL6mXkYUwrrEu38S9ZppBB7D6an8w1Cudp8WfZzU=:TaFZrRAD3K3bc6GFdfCSXA==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "4ZVUK4zF0RZ8SMnxVDmeXqvl54alHe5KIu2Ig39fH9c=:GTzAKp1UBK/ZrZGBSUCiGQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "O6TtI7vz5vlry7Ynmwvh3xR17X1tH85IY/NhwDB/tM8=:etx2epML6z0vfJS/iutKOw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "dkLbcdtllxln1HL4bgLZGx40Cnriiv8tnG9AosSmsKE=:moPShJDPBYf9huNtXopUhw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "HVNZhge1Q+S6gRaSe/U6WG2DI3otLQ1ULjV80faRQ4k=:BommHdQzvmdwuJOVumBKyw==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "tWjkLcFvyFsKC3eWPexQb+IVF5MUshRRSXQilVPj+ac=:15DH4f22x0iZRtq8tO91Ow==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "eU7096WmPBZHWI4mpqWx4BUxX394Gepddtynh0coXBo=:DcyIZhfCDWbG0039S60GGQ==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "Rgnue62sqmxGU3brqjiYz2Cce8Owqo5YFbt6MHo91kU=:DkjcfRIAlMOS5Ww7idepgg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "Password",
                value: "NM15kZkXy/I2RIXf3fRmwWIuJZgt5QaYMQvORNFpJdg=:AXdcWBswwsBDHNRoMzElYg==:10000:SHA512");

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
