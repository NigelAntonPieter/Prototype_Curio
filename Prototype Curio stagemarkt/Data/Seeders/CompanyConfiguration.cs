﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasOne(c => c.LearningPath)
                    .WithMany(lp => lp.Companies)
                    .HasForeignKey(c => c.LearningPathId);

            builder.HasOne(c =>c.Level)
                .WithMany(l =>l.Companies)
                .HasForeignKey(c => c.LevelId);

            builder.HasData(
                new Company { Id = 1, Name = "Company1", Phone = "123-456-7890", EmailAddress = "Company1@hotmail.nl", Password = SecureHasher.Hash("password121"), City = "Breda", Specialization = "Native",LearningPathId = 1, LevelId = 1,Description = "Over Ons:\r\n\r\nWij zijn Company1, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!",  Street = "123 Main Street" },
                new Company { Id = 2, Name = "Company2", Phone = "987-654-3210", EmailAddress = "Company2@hotmail.nl", Password = SecureHasher.Hash("password122"), City = "Tilburg", Specialization = "Native", LearningPathId = 2, LevelId = 2, Description = "Over Ons:\r\n\r\nWij zijn Company2, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!" , Street = "456 Oak Avenue" },
                new Company { Id = 3, Name = "Company3", Phone = "555-123-4567", EmailAddress = "Company3@hotmail.nl", Password = SecureHasher.Hash("password123"), City = "Roosendaal", Specialization = "Native", LearningPathId = 1, LevelId = 3, Description = "Over Ons:\r\n\r\nWij zijn Company3, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen.\n Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren.\n Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit.\n Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. \nAls je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", Street = "789 Pine Road" },
                new Company { Id = 4, Name = "Company4", Phone = "555-123-4567", EmailAddress = "Company4@hotmail.nl", Password = SecureHasher.Hash("password124"), City = "Genk", Specialization = "Web", LearningPathId = 2, LevelId = 1, Description = "Over Ons:\r\n\r\nWij zijn Company4, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", Street = "799 Pine Road" },
                new Company { Id = 5, Name = "Company5", Phone = "555-123-4568", EmailAddress = "Company5@hotmail.nl", Password = SecureHasher.Hash("password125"), City = "Breda", Specialization = "Web", LearningPathId = 1, LevelId = 2, Description = "Over Ons:\r\n\r\nWij zijn Company5, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", Street = "749 Pine Road" },
                new Company { Id = 6, Name = "Company5", Phone = "555-123-4568", EmailAddress = "Company5@hotmail.nl", Password = SecureHasher.Hash("password125"), City = "Rotterdam", Specialization = "Web", LearningPathId = 2, LevelId = 3, Description = "Over Ons:\r\n\r\nWij zijn Company5, een dynamisch softwareontwikkelingsbedrijf dat innovatieve oplossingen biedt voor complexe problemen. Onze expertise ligt in het creëren van op maat gemaakte softwaretoepassingen die de bedrijfsprocessen van onze klanten optimaliseren. Van mobiele apps tot uitgebreide webplatformen, wij brengen ideeën tot leven met cutting-edge technologie en een focus op kwaliteit. Ons team bestaat uit gepassioneerde ontwikkelaars, ontwerpers en projectmanagers die samen streven naar uitmuntendheid in elk project.\r\n\r\nWat We Zoeken in een Stagiair:\r\n\r\nWij zijn op zoek naar getalenteerde en leergierige stagiaires die onze passie voor technologie delen. Als stagiair bij [Bedrijfsnaam] krijg je de kans om deel uit te maken van een innovatief team en mee te werken aan uitdagende projecten.\r\n\r\n**Opleidingsachtergrond:**\r\n- Je volgt een opleiding in Informatica, Software Engineering, of een gerelateerde technische studie.\r\n- Basiskennis van programmeertalen zoals Java, Python, of JavaScript is gewenst.\r\n- Bekendheid met softwareontwikkelingsmethodologieën, zoals Agile, is een pluspunt.\r\n\r\n**Karaktereigenschappen:**\r\n- **Proactief:** Je neemt initiatief en bent niet bang om met nieuwe ideeën te komen.\r\n- **Leergierig:** Je hebt een sterke drang om nieuwe vaardigheden te leren en jezelf voortdurend te verbeteren.\r\n- **Teamplayer:** Je werkt graag in teamverband en kunt goed communiceren.\r\n- Oog voor detail: Je hebt een nauwkeurige aanpak en streeft naar hoge kwaliteit in je werk.\r\n\r\nBij [Bedrijfsnaam] geloven we in het bieden van een omgeving waar stagiaires kunnen groeien en waardevolle ervaring kunnen opdoen in de wereld van softwareontwikkeling. Als je klaar bent voor een uitdaging en een passie hebt voor technologie, dan kijken we ernaar uit om van je te horen!", Street = "749 Pine Road" }
            );
        }
    }
}
