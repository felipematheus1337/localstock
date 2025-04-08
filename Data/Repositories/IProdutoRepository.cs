using Localstockk.Domain;

namespace Localstockk.Data.Repositories
{
    public interface IProdutoRepository
    {
        Produto ObterPorId(int id);
        Produto Create(Produto produto);
        IEnumerable<Produto> ObterTodos();
        void Atualizar(Produto produto);
        void Remover(int id);
        void SaveChanges();
    }
}
