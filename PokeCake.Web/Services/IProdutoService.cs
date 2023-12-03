using PokeCake.Models.DTOs;

namespace PokeCake.Web.Services;

public interface IProdutoService
{
    Task<IEnumerable<ProdutoDto>> GetProdutos();
    Task<ProdutoDto> GetProduto(int id);
}
