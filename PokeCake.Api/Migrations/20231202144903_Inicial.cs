using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokeCake.Api.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Icone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Icone", "Nome" },
                values: new object[,]
                {
                    { 1, "fa-solid fa-dragon", "Pokémon" },
                    { 2, "fa-solid fa-tree-palm", "Animal Crossing" },
                    { 3, "fa-solid fa-gamepad-modern", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NomeUsuario" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Jeniffer" },
                    { 3, "Samir" }
                });

            migrationBuilder.InsertData(
                table: "Carrinhos",
                columns: new[] { "Id", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "Descricao", "Imagem", "Nome", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Cupcake de massa tradicional, decorado com o Pokémon Squirtle.", "/imagens/pokemon/poke-squirtle.png", "CupCake Squirtle", 12.5m, 1 },
                    { 2, 1, "Cupcake de massa tradicional, decorado com o Pokémon Espeon.", "/imagens/pokemon/poke-espeon.png", "CupCake Espeon", 12.5m, 1 },
                    { 3, 1, "Cupcake de massa tradicional, decorado com o Pokémon Greninja.", "/imagens/pokemon/poke-greninja.png", "CupCake Greninja", 12.5m, 1 },
                    { 4, 1, "Cupcake de massa tradicional, decorado com o Pokémon Gyarados.", "/imagens/pokemon/poke-gyarados.png", "CupCake Gyarados", 12.5m, 1 },
                    { 5, 1, "Cupcake de massa tradicional, decorado com o Pokémon Lugia.", "/imagens/pokemon/poke-lugia.png", "CupCake Lugia", 12.5m, 1 },
                    { 6, 1, "Cupcake de massa tradicional, decorado com o Pokémon Mew.", "/imagens/pokemon/poke-mew.png", "CupCake Mew", 12.5m, 1 },
                    { 7, 1, "Cupcake de massa tradicional, decorado com o Pokémon Pikachu.", "/imagens/pokemon/poke-pikachu.png", "CupCake Pikachu", 12.5m, 1 },
                    { 8, 1, "Cupcake de massa tradicional, decorado com o Pokémon Suicune.", "/imagens/pokemon/poke-suicune.png", "CupCake Suicune", 12.5m, 1 },
                    { 9, 1, "Cupcake de massa tradicional, decorado com o Pokémon Xerneas.", "/imagens/pokemon/poke-xerneas.png", "CupCake Xerneas", 12.5m, 1 },
                    { 10, 1, "Cupcake de massa tradicional, decorado com o Pokémon Snorlax.", "/imagens/pokemon/poke-snorlax.png", "CupCake Snorlax", 12.5m, 1 },
                    { 11, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-animalCrossing.jpg", "CupCake Animal Crossing", 15.5m, 1 },
                    { 12, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-casa.jpg", "CupCake Animal Crossing - Casa", 15.5m, 1 },
                    { 13, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-folha.jpg", "CupCake Animal Crossing - Folha", 15.5m, 1 },
                    { 14, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-ilha.jpg", "CupCake Animal Crossing - Ilha", 15.5m, 1 },
                    { 15, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-isabelle.jpg", "CupCake Animal Crossing - Isabelle", 15.5m, 1 },
                    { 16, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-loja.jpg", "CupCake Animal Crossing - Loja", 15.5m, 1 },
                    { 17, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-personagem.jpg", "CupCake Animal Crossing - Personagem", 15.5m, 1 },
                    { 18, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-personagens.jpg", "CupCake Animal Crossing - Personagens", 15.5m, 1 },
                    { 19, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-pesca.jpg", "CupCake Animal Crossing - Pesca", 15.5m, 1 },
                    { 20, 2, "Cupcake de massa tradicional, decorado com o tema Animal Crossing.", "/imagens/animalCrossing/ac-tom.jpg", "CupCake Animal Crossing - Tom Nook", 15.5m, 1 },
                    { 21, 3, "Cupcake de massa tradicional, decorado com o tema game Digimon.", "/imagens/game/game-digimon.jpg", "CupCake Digimon", 20.5m, 1 },
                    { 22, 3, "Cupcake de massa tradicional, decorado com o tema game Final Fantasy VII.", "/imagens/game/game-finalfantasy.jpg", "CupCake Final Fantasy VII", 20.5m, 1 },
                    { 23, 3, "Cupcake de massa tradicional, decorado com o tema game Harvest Moon.", "/imagens/game/game-harvestmoon.jpg", "CupCake Harvest Moon", 20.5m, 1 },
                    { 24, 3, "Cupcake de massa tradicional, decorado com o tema game Kirby.", "/imagens/game/game-kirby.jpg", "CupCake Kirby", 20.5m, 1 },
                    { 25, 3, "Cupcake de massa tradicional, decorado com o tema game Minecraft.", "/imagens/game/game-minecraft.jpg", "CupCake Minecraft", 20.5m, 1 },
                    { 26, 3, "Cupcake de massa tradicional, decorado com o tema game Ori and The Blind Forest.", "/imagens/game/game-ori.jpg", "CupCake Ori and The Blind Forest", 20.5m, 1 },
                    { 27, 3, "Cupcake de massa tradicional, decorado com o tema game Resident Evil.", "/imagens/game/game-resident.jpg", "CupCake Resident Evil", 20.5m, 1 },
                    { 28, 3, "Cupcake de massa tradicional, decorado com o tema game Stardew Valley.", "/imagens/game/game-stardewvalley.jpg", "CupCake Stardew Valley", 20.5m, 1 },
                    { 29, 3, "Cupcake de massa tradicional, decorado com o tema game Mario - Yoshi.", "/imagens/game/game-yoshi.jpg", "CupCake Mario - Yoshi", 20.5m, 1 },
                    { 30, 3, "Cupcake de massa tradicional, decorado com o tema game Zelda.", "/imagens/game/game-zelda.jpg", "CupCake Zelda", 20.5m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_CarrinhoId",
                table: "CarrinhoItens",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ProdutoId",
                table: "CarrinhoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
