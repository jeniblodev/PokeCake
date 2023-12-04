using Blazored.LocalStorage;
using PokeCake.Models.DTOs;

namespace PokeCake.Web.Services;

public class GerenciaProdutosLocalStorageService : IGerenciaProdutosLocalStorageService
{
    private const string key = "ProdutoCollection";
    private readonly ILocalStorageService localStorageService;
    private readonly IProdutoService produtoService;

    public GerenciaProdutosLocalStorageService(ILocalStorageService localStorageService, IProdutoService produtoService)
    {
        this.localStorageService = localStorageService;
        this.produtoService = produtoService;
    }

    public async Task<IEnumerable<ProdutoDto>> GetCollection()
    {
        return await localStorageService.GetItemAsync<IEnumerable<ProdutoDto>>(key) ?? await AddCollection();
    }

    public async Task RemoveCollection()
    {
        await localStorageService.RemoveItemAsync(key);
    }

    private async Task<IEnumerable<ProdutoDto>> AddCollection()
    {
        var produtoCollection = await this.produtoService.GetProdutos();
        if (produtoCollection != null)
        {
            await localStorageService.SetItemAsync(key, produtoCollection);
        }
        return produtoCollection;
    }
}
