using PokeCake.Api.Entities;

namespace PokeCake.Api.Repositories;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetProdutos();
    Task<Produto> GetProduto(int id);
    Task<IEnumerable<Produto>> GetProdutosPorCategoria(int id);
    Task<IEnumerable<Categoria>> GetCategorias();
}
