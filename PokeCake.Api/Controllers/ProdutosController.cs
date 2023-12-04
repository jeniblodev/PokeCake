using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeCake.Api.Entities;
using PokeCake.Api.Mappings;
using PokeCake.Api.Repositories;
using PokeCake.Models.DTOs;

namespace PokeCake.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutosController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetProdutos()
    {
        try
        {
            var produtos = await _produtoRepository.GetProdutos();
            if (produtos is null)
            {
                return NotFound();
            } else
            {
                var produtoDtos = produtos.ConverterProdutosParaDto();
                return Ok(produtoDtos);
            }
        }
        catch (Exception)
        {

            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProdutoDto>> GetProduto(int id)
    {
        try
        {
            var produto = await _produtoRepository.GetProduto(id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado.");
            }
            else
            {
                var produtoDto = produto.ConverterProdutoParaDto();
                return Ok(produtoDto);
            }
        }
        catch (Exception)
        {

            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
        }
    }

    [HttpGet]
    [Route("{categoriaId}/GetProdutosPorCategoria")]
    public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetProdutoPorCategoria(int categoriaId)
    {
        try
        {
            var produtos = await _produtoRepository.GetProdutosPorCategoria(categoriaId);
            var produtosDto = produtos.ConverterProdutosParaDto();
            return Ok(produtosDto);
        }
        catch (Exception)
        {

            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
        }
    }

    [HttpGet]
    [Route("GetCategorias")]
    public async Task<ActionResult<IEnumerable<CategoriaDto>>> GetCategorias()
    {
        try
        {
            var categorias = await _produtoRepository.GetCategorias();
            var categoriasDto = categorias.ConverterCategoriasParaDto();
            return Ok(categoriasDto);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
        }
    }
}
