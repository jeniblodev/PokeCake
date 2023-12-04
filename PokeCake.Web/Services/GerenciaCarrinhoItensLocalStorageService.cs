using Blazored.LocalStorage;
using PokeCake.Models.DTOs;

namespace PokeCake.Web.Services;

public class GerenciaCarrinhoItensLocalStorageService : IGerenciaCarrinhoItensLocalStorageService
{
    private const string key = "CarrinhoItemCollection";

    private readonly ILocalStorageService localStorageService;
    private readonly ICarrinhoCompraService carrinhoCompraService;

    public GerenciaCarrinhoItensLocalStorageService(ILocalStorageService localStorageService, ICarrinhoCompraService produtoService)
    {
        this.localStorageService = localStorageService;
        this.carrinhoCompraService = produtoService;
    }

    public async Task<List<CarrinhoItemDto>> GetCollection()
    {
        return await this.localStorageService.GetItemAsync<List<CarrinhoItemDto>>(key)
               ?? await AddCollection();
    }

    public async Task RemoveCollection()
    {
        await this.localStorageService.RemoveItemAsync(key);
    }

    public async Task SaveCollection(List<CarrinhoItemDto> carrinhoItensDto)
    {
        await this.localStorageService.SetItemAsync(key, carrinhoItensDto);
    }

    private async Task<List<CarrinhoItemDto>> AddCollection()
    {
        var carrinhoCompraCollection = await this.carrinhoCompraService.GetItens(UsuarioLogado.UsuarioId);
        if (carrinhoCompraCollection != null)
        {
            await localStorageService.SetItemAsync(key, carrinhoCompraCollection);
        }
        return carrinhoCompraCollection;
    }
}
