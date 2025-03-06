using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Start_data2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Explosive scenes, high energy, and intense stunts.", "Action" },
                    { 2, "Designed to make the audience laugh.", "Comedy" },
                    { 3, "Focuses on emotional and relational development.", "Drama" },
                    { 4, "Intended to scare and create suspense.", "Horror" },
                    { 5, "Futuristic themes, advanced technology, and space travel.", "Science Fiction" },
                    { 6, "Magical worlds, mythical creatures, and epic adventures.", "Fantasy" },
                    { 7, "Exciting and suspenseful, often involving crime or espionage.", "Thriller" },
                    { 8, "Factual storytelling and real-life events.", "Documentary" },
                    { 9, "Love stories with emotional connections.", "Romance" },
                    { 10, "Movies created with animated characters and stories.", "Animation" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Post-apocalyptic action-packed film.", "George Miller", 19.99m, "Mad Max: Fury Road" },
                    { 2, 2, "Comedy about a bachelor party gone wrong.", "Todd Phillips", 14.99m, "The Hangover" },
                    { 3, 3, "Classic mafia drama.", "Francis Ford Coppola", 24.99m, "The Godfather" },
                    { 4, 4, "Horror based on real paranormal investigations.", "James Wan", 12.99m, "The Conjuring" },
                    { 5, 5, "A sci-fi adventure through space and time.", "Christopher Nolan", 22.99m, "Interstellar" },
                    { 6, 6, "Fantasy adventure about a young wizard.", "Chris Columbus", 18.99m, "Harry Potter and the Sorcerer’s Stone" },
                    { 7, 7, "A thriller about dreams within dreams.", "Christopher Nolan", 21.99m, "Inception" },
                    { 8, 8, "Stunning nature documentary.", "Alastair Fothergill", 29.99m, "Planet Earth" },
                    { 9, 9, "Epic romance set on the ill-fated ship.", "James Cameron", 19.99m, "Titanic" },
                    { 10, 10, "Classic animated film about talking toys.", "John Lasseter", 14.99m, "Toy Story" },
                    { 11, 1, "Action film set in a high-rise building.", "John McTiernan", 17.99m, "Die Hard" },
                    { 12, 2, "Teen comedy about friendship.", "Greg Mottola", 13.99m, "Superbad" },
                    { 13, 3, "Drama about a man’s extraordinary life journey.", "Robert Zemeckis", 16.99m, "Forrest Gump" },
                    { 14, 4, "Horror classic featuring Freddy Krueger.", "Wes Craven", 10.99m, "A Nightmare on Elm Street" },
                    { 15, 5, "Sci-fi neo-noir about artificial intelligence.", "Denis Villeneuve", 23.99m, "Blade Runner 2049" },
                    { 16, 6, "Fantasy epic set in Middle-earth.", "Peter Jackson", 25.99m, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 17, 7, "Thriller about a serial killer.", "David Fincher", 20.99m, "Se7en" },
                    { 18, 8, "True crime documentary series.", "Moira Demos", 27.99m, "Making a Murderer" },
                    { 19, 9, "Romantic drama based on Nicholas Sparks’ novel.", "Nick Cassavetes", 15.99m, "The Notebook" },
                    { 20, 10, "Animated adventure about an ogre’s journey.", "Andrew Adamson", 14.49m, "Shrek" }
                });
        }
    }
}
