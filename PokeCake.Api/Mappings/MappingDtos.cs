using PokeCake.Api.Entities;
using PokeCake.Models.DTOs;

namespace PokeCake.Api.Mappings;

public static class MappingDtos
{
    public static IEnumerable<CategoriaDto> ConverterCategoriasParaDto(this IEnumerable<Categoria> categorias)
    {
        return (from categoria in categorias
                select new CategoriaDto
                {
                    Id = categoria.Id,
                    Nome = categoria.Nome,
                    Icone = categoria.Icone
                }).ToList();
    }

    public static IEnumerable<ProdutoDto> ConverterProdutosParaDto(this IEnumerable<Produto> produtos)
    {
        return (from produto in produtos
                select new ProdutoDto
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    Imagem = produto.Imagem,
                    Preco = (decimal)produto.Preco,
                    Quantidade = produto.Quantidade,
                    CategoriaId = produto.CategoriaId,
                    CategoriaNome = produto.Categoria.Nome
                }).ToList();
    }

    public static IEnumerable<CarrinhoItemDto> ConverterCarrinhoItensParaDto(this IEnumerable<CarrinhoItem> carrinhoItens, IEnumerable<Produto> produtos)
    {
        return (from carrinhoItem in carrinhoItens
                join produto in produtos
                on carrinhoItem.ProdutoId equals produto.Id
                select new CarrinhoItemDto
                {
                    Id = carrinhoItem.Id,
                    ProdutoId = carrinhoItem.ProdutoId,
                    ProdutoNome = produto.Nome,
                    ProdutoDescricao = produto.Descricao,
                    ProdutoImagem = produto.Imagem,
                    Preco = (decimal)produto.Preco,
                    CarrinhoId = carrinhoItem.CarrinhoId,
                    Quantidade = carrinhoItem.Quantidade,
                    PrecoTotal = (decimal)produto.Preco * carrinhoItem.Quantidade

                }).ToList();
    }

    public static CarrinhoItemDto ConverterCarrinhoItemParaDto(this CarrinhoItem carrinhoItem, Produto produto)
    {
        return new CarrinhoItemDto
                {
                    Id = carrinhoItem.Id,
                    ProdutoId = carrinhoItem.ProdutoId,
                    ProdutoNome = produto.Nome,
                    ProdutoDescricao = produto.Descricao,
                    ProdutoImagem = produto.Imagem,
                    Preco = (decimal)produto.Preco,
                    CarrinhoId = carrinhoItem.CarrinhoId,
                    Quantidade = carrinhoItem.Quantidade,
                    PrecoTotal = (decimal)produto.Preco * carrinhoItem.Quantidade

                };
    }
}
