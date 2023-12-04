using PokeCake.Models.DTOs;

namespace PokeCake.Web.Services;

public interface IGerenciaProdutosLocalStorageService
{
    Task<IEnumerable<ProdutoDto>> GetCollection();
    Task RemoveCollection();
}
