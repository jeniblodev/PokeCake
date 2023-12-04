using PokeCake.Models.DTOs;

namespace PokeCake.Web.Services;

public interface IGerenciaCarrinhoItensLocalStorageService
{
    Task<List<CarrinhoItemDto>> GetCollection();
    Task SaveCollection(List<CarrinhoItemDto> carrinhoItensDto);
    Task RemoveCollection();
}
