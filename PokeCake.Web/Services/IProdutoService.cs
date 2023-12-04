using PokeCake.Models.DTOs;

namespace PokeCake.Web.Services;

public interface IProdutoService
{
    Task<IEnumerable<ProdutoDto>> GetProdutos();
    Task<ProdutoDto> GetProduto(int id);

    Task<IEnumerable<CategoriaDto>> GetCategorias();
    Task<IEnumerable<ProdutoDto>> GetProdutosPorCategoria(int categoriaId);
}
