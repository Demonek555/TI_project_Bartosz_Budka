using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Start_data_moze_zadziala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Filmy pełne dynamicznych scen i efektów specjalnych.", "Akcja" },
                    { 2, "Filmy zapewniające rozrywkę i humor.", "Komedia" },
                    { 3, "Filmy o głębokich emocjach i poważnych tematach.", "Dramat" },
                    { 4, "Filmy, które wywołują strach i napięcie.", "Horror" },
                    { 5, "Filmy opowiadające o futurystycznych technologiach i kosmosie.", "Sci-Fi" },
                    { 6, "Filmy pełne magii i niezwykłych światów.", "Fantasy" },
                    { 7, "Filmy trzymające w napięciu z nieoczekiwanymi zwrotami akcji.", "Thriller" },
                    { 8, "Filmy animowane, często dla dzieci i rodzin.", "Animacja" },
                    { 9, "Filmy oparte na faktach i rzeczywistych wydarzeniach.", "Dokumentalny" },
                    { 10, "Filmy o miłości i relacjach międzyludzkich.", "Romans" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Postapokaliptyczna walka o przetrwanie.", "George Miller", 29.99m, "Mad Max: Na drodze gniewu" },
                    { 2, 1, "Historia rzymskiego generała, który staje się gladiatorem.", "Ridley Scott", 34.99m, "Gladiator" },
                    { 3, 2, "Bohater z ciętym językiem i niezwykłymi umiejętnościami.", "Tim Miller", 24.99m, "Deadpool" },
                    { 4, 3, "Historia człowieka, który przypadkiem wpływa na historię świata.", "Robert Zemeckis", 19.99m, "Forrest Gump" },
                    { 5, 4, "Załoga statku kosmicznego walczy z obcym stworzeniem.", "Ridley Scott", 39.99m, "Obcy: Ósmy pasażer Nostromo" },
                    { 6, 5, "Rzeczywistość to iluzja kontrolowana przez maszyny.", "Lana i Lilly Wachowski", 29.99m, "Matrix" },
                    { 7, 6, "Podróż Froda i jego towarzyszy w celu zniszczenia pierścienia.", "Peter Jackson", 49.99m, "Władca Pierścieni: Drużyna Pierścienia" },
                    { 8, 7, "Złodziej kradnie sekrety z umysłów podczas snu.", "Christopher Nolan", 34.99m, "Incepcja" },
                    { 9, 8, "Ogr wyrusza na misję, by odzyskać swoje bagno.", "Andrew Adamson, Vicky Jenson", 14.99m, "Shrek" },
                    { 10, 9, "Dokument ukazujący piękno naszej planety.", "Richard Dale", 24.99m, "Ziemia: Niezwykły dzień" },
                    { 11, 10, "Historia miłości na pokładzie słynnego statku.", "James Cameron", 19.99m, "Titanic" },
                    { 12, 1, "Zabójca wraca do gry, by pomścić stratę.", "Chad Stahelski", 29.99m, "John Wick" },
                    { 13, 2, "Dwoje przyjaciół próbuje przeżyć zwariowaną noc.", "Greg Mottola", 19.99m, "Superbad" },
                    { 14, 4, "Rodzina ukrywa się przed potworami reagującymi na dźwięk.", "John Krasinski", 27.99m, "Ciche miejsce" },
                    { 15, 5, "Misja kosmiczna w poszukiwaniu nowego domu dla ludzkości.", "Christopher Nolan", 39.99m, "Interstellar" },
                    { 16, 6, "Młody czarodziej odkrywa swoje przeznaczenie.", "Chris Columbus", 29.99m, "Harry Potter i Kamień Filozoficzny" },
                    { 17, 3, "Portret psychologiczny upadku człowieka.", "Todd Phillips", 31.99m, "Joker" },
                    { 18, 8, "Zabawki ożywają, gdy ludzie ich nie widzą.", "John Lasseter", 19.99m, "Toy Story" },
                    { 19, 6, "Opowieść o walce między naturą a cywilizacją.", "Hayao Miyazaki", 34.99m, "Księżniczka Mononoke" },
                    { 20, 1, "Oddział wyrusza na misję ratunkową podczas II wojny światowej.", "Steven Spielberg", 39.99m, "Szeregowiec Ryan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}
