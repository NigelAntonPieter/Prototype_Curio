using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prototype_Curio_stagemarkt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    EmailAdress = table.Column<string>(type: "longtext", nullable: true)
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
                    LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[] { 1, "Fedde", "+ls4MA8+KzICHz3KPJVo4rT9kEm5GMxMpaMmYhJoVRA=:GgHdJ91Buz/mNxAi2GvtEQ==:10000:SHA512" });

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
                    { 1, "Laurens", "mY3Faktkm04fXoBkK41UnT9DyC4M9xW1DL4P6QNJuMo=:ZlYJxe+uqFzri/0+N6gecg==:10000:SHA512" },
                    { 2, "Kiki", "Y/eNzg4elcZRpUIxdS+SrNJTRRSk6ABh/ZO0wV9gf40=:4+1NmlSOYzkRMxi8NJlmSA==:10000:SHA512" }
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
                    { 1, "Breda", "Over Ons:\r\n\r\nWij zijn Company1, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company1@hotmail.nl", null, true, 1, 1, "Company1", "APXSzduSaSZw5gqWn+69pmTT4ngGgt6z4NyAtTK6LRg=:wugqYITx6lclPNHTJV27tg==:10000:SHA512", "123-456-7890", "Native", "123 Main Street" },
                    { 2, "Tilburg", "Over Ons:\r\n\r\nWij zijn Company2, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company2@hotmail.nl", null, true, 2, 2, "Company2", "Y3UF3JTfMxvZ+rDABGQ93/ir2x7wo5dw8Y7bAeVPaWA=:YOpGKVfiS0p5V96uigwRkA==:10000:SHA512", "987-654-3210", "Native", "456 Oak Avenue" },
                    { 3, "Roosendaal", "Over Ons:\r\n\r\nWij zijn Company3, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company3@hotmail.nl", null, true, 1, 3, "Company3", "7xKJCTZsBWargNaMo/rFF5iJFYHabCdmzoNIXCzxino=:ZLU3Nq5EHI7TRN9KhJK0kA==:10000:SHA512", "555-123-4567", "Native", "789 Pine Road" },
                    { 4, "Genk", "Over Ons:\r\n\r\nWij zijn Company4, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company4@hotmail.nl", null, true, 2, 1, "Company4", "mbczi9tJUkX+GXPPK9R2btyRHKWHHotC3joqrwFSAps=:6Y0HpqhZoZF70PHcHUAJYQ==:10000:SHA512", "555-123-4567", "Web", "799 Pine Road" },
                    { 5, "Breda", "Over Ons:\r\n\r\nWij zijn Company5, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company5@hotmail.nl", null, true, 1, 2, "Company5", "FNKhjnMt1oagdxlb/YURMjc9ZMkw9smlh1vI9kPTiWs=:8+QgriWwmSnmC8Vq5pnvBA==:10000:SHA512", "555-123-4568", "Web", "749 Pine Road" },
                    { 6, "Rotterdam", "Over Ons:\r\n\r\nWij zijn Company5, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", "Company5@hotmail.nl", null, true, 2, 3, "Company5", "wIxHzhx375gbinbIRmMKPztLafhxlZzJ0MPZlFbQkcU=:AQ3PbKm/yFjsqAPbIXcVBw==:10000:SHA512", "555-123-4568", "Web", "749 Pine Road" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EmailAdress", "ImagePath", "InternschipTeacherId", "InternshipTeacherId", "Name", "Password", "Specialization" },
                values: new object[,]
                {
                    { 1, "student1@example.com", null, null, 1, "Max", "XT+bboca3zqrJlWNVDHzdX612cfa9SgRPxLHixsa3OQ=:nBK6lw7meyh0lJHepBXrsQ==:10000:SHA512", "Native" },
                    { 2, "student2@example.com", null, null, 2, "JJ", "OKxw+CyIzSTYRFs0DFBETzyhnDIhByPo6fauRY5MEqM=:9ovJl5cjuzSk6NsJG6Wxlg==:10000:SHA512", "Native" },
                    { 3, "student1@example.com", null, null, 1, "Krijn", "h5Q2fLg4rg9J1Z9jjMEyENFDldVtSbe5HQMv81SYjpw=:/HmUf0oY/uArG8iL+1zT2A==:10000:SHA512", "Native" },
                    { 4, "student2@example.com", null, null, 2, "Luna", "Jz0YxlQ4LOHvzaCKVrzReA1wgJ3jscdJ3cxKqKtmH2s=:itM8oOnv4Gva7Aay4LJmhw==:10000:SHA512", "Native" },
                    { 5, "student1@example.com", null, null, 1, "Wiardi", "ENCj8Wt7G5RscZt3SHW9/LjJ677CAFIqbggX5evNYqk=:6GnIkPAhtNO114QZ8An5Fw==:10000:SHA512", "Native" },
                    { 6, "student2@example.com", null, null, 2, "Nigel", "W6xgYqGPnTtMR3fv3v5ndqT+ZYdcpIwp9fucjAYM5OI=:vHNHYOIUs9vVvI/Qr6rBLQ==:10000:SHA512", "Native" },
                    { 7, "student1@example.com", null, null, 1, "Kelvin", "VpdzhLTBjO0r+Gki5I4o2rHJzdpdIESmB6R5+zSU00A=:brrWeFTY6QWE/9UQlxZFwQ==:10000:SHA512", "Native" },
                    { 8, "student2@example.com", null, null, 1, "Jonathan", "wN231DJQL+HVoblpClUGzd/TvSN/5s8fSrfLsYtghSY=:9gQMVXoN5Acpsg39X8ziTA==:10000:SHA512", "Native" },
                    { 9, "student1@example.com", null, null, 1, "Brent", "dRjLyS9motIQBN8jD12Go23jOugtqsutaFUp3+w/X08=:nFy7VCBmQm1p2Xo7EfVfKg==:10000:SHA512", "Native" },
                    { 10, "student2@example.com", null, null, 2, "Simon", "LgisEp2srvNDYvQMO/DHsyD7MUpYx9qhCEOysdM1iiM=:vwDoq6r2NvkicNDd21G3xA==:10000:SHA512", "Native" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AdminId", "CompanyId", "IntershipTeacherId", "IsCompany", "LastLogin", "StudentId" },
                values: new object[,]
                {
                    { 11, null, null, 1, false, null, null },
                    { 12, null, null, 2, false, null, null },
                    { 13, 1, null, null, false, null, null },
                    { 1, null, null, null, false, null, 1 },
                    { 2, null, null, null, false, null, 2 },
                    { 3, null, null, null, false, null, 3 },
                    { 4, null, null, null, false, null, 4 },
                    { 5, null, null, null, false, null, 5 },
                    { 6, null, null, null, false, null, 6 },
                    { 7, null, null, null, false, null, 7 },
                    { 8, null, null, null, false, null, 8 },
                    { 9, null, null, null, false, null, 9 },
                    { 10, null, null, null, false, null, 10 },
                    { 14, null, 1, null, true, null, null },
                    { 15, null, 2, null, true, null, null },
                    { 16, null, 3, null, true, null, null },
                    { 17, null, 4, null, true, null, null },
                    { 18, null, 5, null, true, null, null },
                    { 19, null, 6, null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "WorkHours",
                columns: new[] { "Id", "Date", "HoursWorked", "Reason", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 8, null, 0, 1 },
                    { 2, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 0, 2 }
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
