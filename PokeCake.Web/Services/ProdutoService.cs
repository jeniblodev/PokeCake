using PokeCake.Models.DTOs;
using System.Net.Http.Json;

namespace PokeCake.Web.Services;

public class ProdutoService : IProdutoService
{
    public HttpClient _httpClient;
    public ILogger<ProdutoService> _logger;

    public ProdutoService(HttpClient httpClient, ILogger<ProdutoService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<IEnumerable<ProdutoDto>> GetProdutos()
    {
        try
        {
            var produtosDto = await _httpClient.GetFromJsonAsync<IEnumerable<ProdutoDto>>("api/produtos");

            return produtosDto;
        }
        catch (Exception)
        {
            _logger.LogError("Erro ao acessar produtos : api/produtos");
            throw;
        }
    }

    public async Task<ProdutoDto> GetProduto(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/produtos/{id}");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return default(ProdutoDto);
                }
                return await response.Content.ReadFromJsonAsync<ProdutoDto>();
            } else
            {
                var message = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao localizar produto pelo id = {id} - {message}");
                throw new Exception($"StatusCode: {response.StatusCode} - {message}");
            }
        }
        catch (Exception)
        {
            _logger.LogError($"Erro ao localizar produto pelo id = {id}");
            throw;
        }
    }

    public async Task<IEnumerable<CategoriaDto>> GetCategorias()
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/produtos/GetCategorias");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<CategoriaDto>();
                }
                return await response.Content.ReadFromJsonAsync<IEnumerable<CategoriaDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"StatusCode: {response.StatusCode} - {message}");
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    public async Task<IEnumerable<ProdutoDto>> GetProdutosPorCategoria(int categoriaId)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/produtos/{categoriaId}/GetProdutosPorCategoria");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<ProdutoDto>();
                }
                return await response.Content.ReadFromJsonAsync<IEnumerable<ProdutoDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"StatusCode: {response.StatusCode} - {message}");
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
