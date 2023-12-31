﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokeCake.Api.Context;

#nullable disable

namespace PokeCake.Api.Migrations
{
    [DbContext(typeof(PokeCakeContext))]
    partial class PokeCakeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PokeCake.Api.Entities.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Carrinhos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 3,
                            UsuarioId = 3
                        });
                });

            modelBuilder.Entity("PokeCake.Api.Entities.CarrinhoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CarrinhoItens", (string)null);
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icone = "fa-solid fa-dragon",
                            Nome = "Pokémon"
                        },
                        new
                        {
                            Id = 2,
                            Icone = "fa-solid fa-tree-palm",
                            Nome = "Animal Crossing"
                        },
                        new
                        {
                            Id = 3,
                            Icone = "fa-solid fa-gamepad-modern",
                            Nome = "Video Games"
                        });
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Squirtle.",
                            Imagem = "/imagens/pokemon/poke-squirtle.png",
                            Nome = "CupCake Squirtle",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Espeon.",
                            Imagem = "/imagens/pokemon/poke-espeon.png",
                            Nome = "CupCake Espeon",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Greninja.",
                            Imagem = "/imagens/pokemon/poke-greninja.png",
                            Nome = "CupCake Greninja",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Gyarados.",
                            Imagem = "/imagens/pokemon/poke-gyarados.png",
                            Nome = "CupCake Gyarados",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Lugia.",
                            Imagem = "/imagens/pokemon/poke-lugia.png",
                            Nome = "CupCake Lugia",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Mew.",
                            Imagem = "/imagens/pokemon/poke-mew.png",
                            Nome = "CupCake Mew",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Pikachu.",
                            Imagem = "/imagens/pokemon/poke-pikachu.png",
                            Nome = "CupCake Pikachu",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Suicune.",
                            Imagem = "/imagens/pokemon/poke-suicune.png",
                            Nome = "CupCake Suicune",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Xerneas.",
                            Imagem = "/imagens/pokemon/poke-xerneas.png",
                            Nome = "CupCake Xerneas",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 1,
                            Descricao = "Cupcake de massa tradicional, decorado com o Pokémon Snorlax.",
                            Imagem = "/imagens/pokemon/poke-snorlax.png",
                            Nome = "CupCake Snorlax",
                            Preco = 12.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-animalCrossing.jpg",
                            Nome = "CupCake Animal Crossing",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-casa.jpg",
                            Nome = "CupCake Animal Crossing - Casa",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 13,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-folha.jpg",
                            Nome = "CupCake Animal Crossing - Folha",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 14,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-ilha.jpg",
                            Nome = "CupCake Animal Crossing - Ilha",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 15,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-isabelle.jpg",
                            Nome = "CupCake Animal Crossing - Isabelle",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 16,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-loja.jpg",
                            Nome = "CupCake Animal Crossing - Loja",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 17,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-personagem.jpg",
                            Nome = "CupCake Animal Crossing - Personagem",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 18,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-personagens.jpg",
                            Nome = "CupCake Animal Crossing - Personagens",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 19,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-pesca.jpg",
                            Nome = "CupCake Animal Crossing - Pesca",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 20,
                            CategoriaId = 2,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema Animal Crossing.",
                            Imagem = "/imagens/animalCrossing/ac-tom.jpg",
                            Nome = "CupCake Animal Crossing - Tom Nook",
                            Preco = 15.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 21,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Digimon.",
                            Imagem = "/imagens/game/game-digimon.jpg",
                            Nome = "CupCake Digimon",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 22,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Final Fantasy VII.",
                            Imagem = "/imagens/game/game-finalfantasy.jpg",
                            Nome = "CupCake Final Fantasy VII",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 23,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Harvest Moon.",
                            Imagem = "/imagens/game/game-harvestmoon.jpg",
                            Nome = "CupCake Harvest Moon",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 24,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Kirby.",
                            Imagem = "/imagens/game/game-kirby.jpg",
                            Nome = "CupCake Kirby",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 25,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Minecraft.",
                            Imagem = "/imagens/game/game-minecraft.jpg",
                            Nome = "CupCake Minecraft",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 26,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Ori and The Blind Forest.",
                            Imagem = "/imagens/game/game-ori.jpg",
                            Nome = "CupCake Ori and The Blind Forest",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 27,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Resident Evil.",
                            Imagem = "/imagens/game/game-resident.jpg",
                            Nome = "CupCake Resident Evil",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 28,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Stardew Valley.",
                            Imagem = "/imagens/game/game-stardewvalley.jpg",
                            Nome = "CupCake Stardew Valley",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 29,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Mario - Yoshi.",
                            Imagem = "/imagens/game/game-yoshi.jpg",
                            Nome = "CupCake Mario - Yoshi",
                            Preco = 20.5m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = 30,
                            CategoriaId = 3,
                            Descricao = "Cupcake de massa tradicional, decorado com o tema game Zelda.",
                            Imagem = "/imagens/game/game-zelda.jpg",
                            Nome = "CupCake Zelda",
                            Preco = 20.5m,
                            Quantidade = 1
                        });
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomeUsuario = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            NomeUsuario = "Jeniffer"
                        },
                        new
                        {
                            Id = 3,
                            NomeUsuario = "Samir"
                        });
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Carrinho", b =>
                {
                    b.HasOne("PokeCake.Api.Entities.Usuario", null)
                        .WithOne("Carrinho")
                        .HasForeignKey("PokeCake.Api.Entities.Carrinho", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PokeCake.Api.Entities.CarrinhoItem", b =>
                {
                    b.HasOne("PokeCake.Api.Entities.Carrinho", "Carrinho")
                        .WithMany("Itens")
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeCake.Api.Entities.Produto", "Produto")
                        .WithMany("Itens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrinho");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Produto", b =>
                {
                    b.HasOne("PokeCake.Api.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Carrinho", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Produto", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("PokeCake.Api.Entities.Usuario", b =>
                {
                    b.Navigation("Carrinho");
                });
#pragma warning restore 612, 618
        }
    }
}
