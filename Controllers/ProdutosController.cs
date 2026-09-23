using GestaoPedidos.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoPedidos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500.00m,
                QuantidadeEstoque = 10
            },
            new Produto
            {
                Id = 2,
                Nome = "Mouse",
                Preco = 120.00m,
                QuantidadeEstoque = 25
            }
        };

        return Ok(produtos);
    }
}