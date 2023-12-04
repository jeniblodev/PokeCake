using Microsoft.EntityFrameworkCore;
using PokeCake.Api.Entities;

namespace PokeCake.Api.Context;

public class PokeCakeContext : DbContext
{
    public PokeCakeContext(DbContextOptions<PokeCakeContext> options) : base(options)
    {
    }

    public DbSet<Carrinho>? Carrinhos { get; set;}
    public DbSet<CarrinhoItem>? CarrinhoItens { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //incluindo categorias no banco
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 1,
            Nome = "Pokémon",
            Icone = "fa-solid fa-dragon"
        });

        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 2,
            Nome = "Animal Crossing",
            Icone = "fa-solid fa-tree-palm"
        });

        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 3,
            Nome = "Video Games",
            Icone = "fa-solid fa-gamepad-modern"
        });

        

        //incluindo produtos
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 1,
            Nome = "CupCake Squirtle",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Squirtle.",
            Imagem = "/imagens/pokemon/poke-squirtle.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 2,
            Nome = "CupCake Espeon",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Espeon.",
            Imagem = "/imagens/pokemon/poke-espeon.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 3,
            Nome = "CupCake Greninja",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Greninja.",
            Imagem = "/imagens/pokemon/poke-greninja.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 4,
            Nome = "CupCake Gyarados",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Gyarados.",
            Imagem = "/imagens/pokemon/poke-gyarados.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 5,
            Nome = "CupCake Lugia",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Lugia.",
            Imagem = "/imagens/pokemon/poke-lugia.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 6,
            Nome = "CupCake Mew",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Mew.",
            Imagem = "/imagens/pokemon/poke-mew.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 7,
            Nome = "CupCake Pikachu",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Pikachu.",
            Imagem = "/imagens/pokemon/poke-pikachu.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 8,
            Nome = "CupCake Suicune",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Suicune.",
            Imagem = "/imagens/pokemon/poke-suicune.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 9,
            Nome = "CupCake Xerneas",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Xerneas.",
            Imagem = "/imagens/pokemon/poke-xerneas.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 10,
            Nome = "CupCake Snorlax",
            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Snorlax.",
            Imagem = "/imagens/pokemon/poke-snorlax.png",
            Preco = 12.50,
            Quantidade = 1,
            CategoriaId = 1
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 11,
            Nome = "CupCake Animal Crossing",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-animalCrossing.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 12,
            Nome = "CupCake Animal Crossing - Casa",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-casa.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 13,
            Nome = "CupCake Animal Crossing - Folha",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-folha.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 14,
            Nome = "CupCake Animal Crossing - Ilha",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-ilha.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 15,
            Nome = "CupCake Animal Crossing - Isabelle",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-isabelle.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 16,
            Nome = "CupCake Animal Crossing - Loja",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-loja.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 17,
            Nome = "CupCake Animal Crossing - Personagem",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-personagem.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 18,
            Nome = "CupCake Animal Crossing - Personagens",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-personagens.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 19,
            Nome = "CupCake Animal Crossing - Pesca",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-pesca.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 20,
            Nome = "CupCake Animal Crossing - Tom Nook",
            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
            Imagem = "/imagens/animalCrossing/ac-tom.jpg",
            Preco = 15.50,
            Quantidade = 1,
            CategoriaId = 2
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 21,
            Nome = "CupCake Digimon",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Digimon.",
            Imagem = "/imagens/game/game-digimon.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 22,
            Nome = "CupCake Final Fantasy VII",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Final Fantasy VII.",
            Imagem = "/imagens/game/game-finalfantasy.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 23,
            Nome = "CupCake Harvest Moon",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Harvest Moon.",
            Imagem = "/imagens/game/game-harvestmoon.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 24,
            Nome = "CupCake Kirby",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Kirby.",
            Imagem = "/imagens/game/game-kirby.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 25,
            Nome = "CupCake Minecraft",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Minecraft.",
            Imagem = "/imagens/game/game-minecraft.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 26,
            Nome = "CupCake Ori and The Blind Forest",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Ori and The Blind Forest.",
            Imagem = "/imagens/game/game-ori.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 27,
            Nome = "CupCake Resident Evil",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Resident Evil.",
            Imagem = "/imagens/game/game-resident.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 28,
            Nome = "CupCake Stardew Valley",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Stardew Valley.",
            Imagem = "/imagens/game/game-stardewvalley.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 29,
            Nome = "CupCake Mario - Yoshi",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Mario - Yoshi.",
            Imagem = "/imagens/game/game-yoshi.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 30,
            Nome = "CupCake Zelda",
            Descricao = "Cupcake de massa tradicional, decorado com o tema game Zelda.",
            Imagem = "/imagens/game/game-zelda.jpg",
            Preco = 20.50,
            Quantidade = 1,
            CategoriaId = 3
        });



        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 1,
            NomeUsuario = "Admin"
        });
        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 2,
            NomeUsuario = "Jeniffer"
        });
        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 3,
            NomeUsuario = "Samir"
        });



        modelBuilder.Entity<Carrinho>().HasData(new Carrinho
        {
            Id = 1,
            UsuarioId = 1
        });
        modelBuilder.Entity<Carrinho>().HasData(new Carrinho
        {
            Id = 2,
            UsuarioId = 2
        });
        modelBuilder.Entity<Carrinho>().HasData(new Carrinho
        {
            Id = 3,
            UsuarioId = 3
        });

    }
}
