﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InternschipTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternschipTeachers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LearningPaths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningPaths", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GradeLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Specialization = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InternshipTeacherId = table.Column<int>(type: "int", nullable: true),
                    InternschipTeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_InternschipTeachers_InternschipTeacherId",
                        column: x => x.InternschipTeacherId,
                        principalTable: "InternschipTeachers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_InternschipTeachers_InternshipTeacherId",
                        column: x => x.InternshipTeacherId,
                        principalTable: "InternschipTeachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    LearningPathId = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsOpen = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_LearningPaths_LearningPathId",
                        column: x => x.LearningPathId,
                        principalTable: "LearningPaths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoursWorked = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkHours_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Motivation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CvFilePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AppliedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FavoriteCompanies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteCompanies", x => new { x.CompanyId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_FavoriteCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteCompanies_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SentAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SenderStudentId = table.Column<int>(type: "int", nullable: true),
                    SenderCompanyId = table.Column<int>(type: "int", nullable: true),
                    ReceiverStudentId = table.Column<int>(type: "int", nullable: true),
                    ReceiverCompanyId = table.Column<int>(type: "int", nullable: true),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_ReceiverCompany",
                        column: x => x.ReceiverCompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_ReceiverStudent",
                        column: x => x.ReceiverStudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_SenderCompany",
                        column: x => x.SenderCompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_SenderStudent",
                        column: x => x.SenderStudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsCompany = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    IntershipTeacherId = table.Column<int>(type: "int", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    StudentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_InternschipTeachers_IntershipTeacherId",
                        column: x => x.IntershipTeacherId,
                        principalTable: "InternschipTeachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[] { 1, "Fedde", "mf82PJ2tPP+F6Vmjp59uNr3MVJ8TvVslF+ZklPclisQ=:vrHCxgYgjvYi6N8ce48U5w==:10000:SHA512" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Native" },
                    { 2, "Web" },
                    { 3, "FrontEnd" }
                });

            migrationBuilder.InsertData(
                table: "InternschipTeachers",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Laurens", "ZeTMxRoHLOLqW0Qpvz12O2BH8uzq9REfnaynb0QR9HY=:wa5QvConzYRxxyvAXa+U7w==:10000:SHA512" },
                    { 2, "Kiki", "KqV5kn4WjIb/u32DTuL/n6Iw1nUo+CpMnMliYYeNpBU=:Ytvev9MCOA9S2P+cxydzdg==:10000:SHA512" }
                });

            migrationBuilder.InsertData(
                table: "LearningPaths",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BOL" },
                    { 2, "BBL" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "GradeLevel" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Description", "EmailAddress", "ImagePath", "IsOpen", "LearningPathId", "LevelId", "Name", "Password", "Phone", "Specialization", "Street" },
                values: new object[,]
                {
                    { 1, "Breda", "Over Ons:\r\n\r\nWij zijn Company1, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company1@hotmail.nl", null, true, 1, 1, "Company1", "Mh28j2e19Rc371Y7HJrC8BhCp5ElNug5ZcOLYt22TYY=:mFKe0uOXSqPmf2Cxb2c3dQ==:10000:SHA512", "123-456-7890", "Native", "123 Main Street" },
                    { 2, "Tilburg", "Over Ons:\r\n\r\nWij zijn Company2, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company2@hotmail.nl", null, true, 2, 2, "Company2", "/ItSoIwmAq9Q3TwRbGzLbgEmMSH9JrdVysO5wrgHIhQ=:mtnOU+ZJFLYrtRsvtDO+ng==:10000:SHA512", "987-654-3210", "Native", "456 Oak Avenue" },
                    { 3, "Roosendaal", "Over Ons:\r\n\r\nWij zijn Company3, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company3@hotmail.nl", null, true, 1, 3, "Company3", "r0CgEB7GBW3nyutDX3+lHF24oB9+h1MUIHrT2FJxinA=:qxrqzpTuC+pb178N+0znag==:10000:SHA512", "555-123-4567", "Native", "789 Pine Road" },
                    { 4, "Genk", "Over Ons:\r\n\r\nWij zijn Company4, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company4@hotmail.nl", null, true, 2, 1, "Company4", "y9C4syN+5HUu419rkWLmU0hvCFL1ultjrs32infHSkE=:jSi5whf59CFhiKpkXiUbJg==:10000:SHA512", "555-123-4567", "Web", "799 Pine Road" },
                    { 5, "Breda", "Over Ons:\r\n\r\nWij zijn Company5, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company5@hotmail.nl", null, true, 1, 2, "Company5", "stjOHv3VSjxLnKQ4LGfC23wXmx2BgLmMJu3a5NN0ASQ=:eeaD47S3B1oxpRXBLmMQ+A==:10000:SHA512", "555-123-4568", "Web", "749 Pine Road" },
                    { 6, "Rotterdam", "Over Ons:\r\n\r\nWij zijn Company5, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company5@hotmail.nl", null, true, 2, 3, "Company5", "a48+Gntv+xqjVc/QDpwoqC7/F/C/kWqY6qwj1UqX83Q=:cZVjcp/zfMQjWf2NOo8Rpw==:10000:SHA512", "555-123-4568", "Web", "749 Pine Road" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EmailAddress", "ImagePath", "InternschipTeacherId", "InternshipTeacherId", "Name", "Password", "Specialization" },
                values: new object[,]
                {
                    { 1, "student1@example.com", null, null, 1, "Max", "ML0GLqeJ+lB/2F5XL8F9iTaWmkFSJa5eSkEMNhwr6ak=:SqA8znKrefFv9OOfZP1HZA==:10000:SHA512", "Native" },
                    { 2, "student2@example.com", null, null, 2, "JJ", "j1bCrloNFbYGgzAvhN2B1YOYRNLur7oR4paDwZYbsJ8=:N+58VEEMSf8J7YvFe5gPNw==:10000:SHA512", "Web" },
                    { 3, "student1@example.com", null, null, 1, "Krijn", "nvwBLXwOXARVNLwvSKzkNvCMGpjbM6Wh7ALaoTQStOs=:zLy4Qn8qNcuFZiTRedgJSA==:10000:SHA512", "FrontEnd" },
                    { 4, "student2@example.com", null, null, 2, "Luna", "n2PGRxYT5DAJetOGkJgakQ4kdOCGDwQUDhfGOwTsrzk=:htPerpILoyv7cT1pFl65kw==:10000:SHA512", "Native" },
                    { 5, "student1@example.com", null, null, 1, "Wiardi", "AQNVzczPDFovH/DYAnK5vFWvWtxhuda+YqtuUyu5oXg=:eB1d3Qw6av7303I+1uWsMg==:10000:SHA512", "Web" },
                    { 6, "student2@example.com", null, null, 2, "Nigel", "x+Mfo1okyUEcm9V3D4g6jJgyZP4tf5KlJMBusmafCwc=:1i0uoAyh0AJ2IYHh2nbhkg==:10000:SHA512", "Native" },
                    { 7, "student1@example.com", null, null, 1, "Kelvin", "ZpcSPB/k+VgFE118u7rhG4gWgwnbH0B+URKaqDzpMF4=:4vy/jYrnbLGqx7KIQeieFQ==:10000:SHA512", "Native" },
                    { 8, "student2@example.com", null, null, 1, "Jonathan", "LWJkoSDY5pgpZG80BaQ82ImWUuxtBMay5ACCsacvmos=:SpYHhyiPgarrT8S4aTyqGQ==:10000:SHA512", "Web" },
                    { 9, "student1@example.com", null, null, 1, "Brent", "4CgfXxRT7swssBAtjV2KkyhJsGXYyO0pDKEBSH/GRIc=:ALfHfTJ7vNz1itSmejifdA==:10000:SHA512", "Native" },
                    { 10, "student2@example.com", null, null, 2, "Simon", "3nA2smHARow7avFrbOkvsASECn+YXJl/vCD9myftkD8=:fBcbSMo/7GsJUuy6oeqNfA==:10000:SHA512", "Native" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AdminId", "CompanyId", "IntershipTeacherId", "IsCompany", "LastLogin", "StudentId", "StudentId1" },
                values: new object[,]
                {
                    { 11, null, null, 1, false, null, null, null },
                    { 12, null, null, 2, false, null, null, null },
                    { 13, 1, null, null, false, null, null, null },
                    { 1, null, null, null, false, null, 1, null },
                    { 2, null, null, null, false, null, 2, null },
                    { 3, null, null, null, false, null, 3, null },
                    { 4, null, null, null, false, null, 4, null },
                    { 5, null, null, null, false, null, 5, null },
                    { 6, null, null, null, false, null, 6, null },
                    { 7, null, null, null, false, null, 7, null },
                    { 8, null, null, null, false, null, 8, null },
                    { 9, null, null, null, false, null, 9, null },
                    { 10, null, null, null, false, null, 10, null },
                    { 14, null, 1, null, true, null, null, null },
                    { 15, null, 2, null, true, null, null, null },
                    { 16, null, 3, null, true, null, null, null },
                    { 17, null, 4, null, true, null, null, null },
                    { 18, null, 5, null, true, null, null, null },
                    { 19, null, 6, null, true, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "WorkHours",
                columns: new[] { "Id", "Date", "HoursWorked", "Reason", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 1 },
                    { 2, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 0, 2 },
                    { 3, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 1 },
                    { 4, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 2, 3 },
                    { 5, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 4 },
                    { 6, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 5 },
                    { 7, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 2, 2 },
                    { 8, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 3 },
                    { 9, new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 2, 4 },
                    { 10, new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, null, 1, 5 },
                    { 11, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 0, 6 },
                    { 12, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1, 7 },
                    { 13, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 2, 8 },
                    { 14, new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 9 },
                    { 15, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 0, 10 },
                    { 16, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 1 },
                    { 17, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 2, 2 },
                    { 18, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 3 },
                    { 19, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 0, 4 },
                    { 20, new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 2, 5 },
                    { 21, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 6 },
                    { 22, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 2, 7 },
                    { 23, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 1, 8 },
                    { 24, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 9 },
                    { 25, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1, 10 },
                    { 26, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), 7, null, 2, 1 },
                    { 27, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), 3, null, 1, 2 },
                    { 28, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 5, null, 0, 3 },
                    { 29, new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 2, null, 2, 4 },
                    { 30, new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 1, 5 },
                    { 31, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 6 },
                    { 32, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CompanyId",
                table: "Applications",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StudentId",
                table: "Applications",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LearningPathId",
                table: "Companies",
                column: "LearningPathId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LevelId",
                table: "Companies",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCompanies_StudentId",
                table: "FavoriteCompanies",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CompanyId",
                table: "Messages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverCompanyId",
                table: "Messages",
                column: "ReceiverCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverStudentId",
                table: "Messages",
                column: "ReceiverStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderCompanyId",
                table: "Messages",
                column: "SenderCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderStudentId",
                table: "Messages",
                column: "SenderStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_StudentId",
                table: "Messages",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InternschipTeacherId",
                table: "Students",
                column: "InternschipTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InternshipTeacherId",
                table: "Students",
                column: "InternshipTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdminId",
                table: "Users",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IntershipTeacherId",
                table: "Users",
                column: "IntershipTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentId",
                table: "Users",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentId1",
                table: "Users",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHours_StudentId",
                table: "WorkHours",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "FavoriteCompanies");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkHours");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "LearningPaths");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "InternschipTeachers");
        }
    }
}