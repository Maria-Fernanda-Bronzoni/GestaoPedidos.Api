using GestaoPedidos.Api.Models;

namespace GestaoPedidos.Api.Repositories;

public interface IProdutoRepository
{
    Task<List<Produto>> ObterTodosAsync();

    Task<Produto?> ObterPorIdAsync(int id);

    Task AdicionarAsync(Produto produto);

    Task AtualizarAsync(Produto produto);

    Task RemoverAsync(Produto produto);
}