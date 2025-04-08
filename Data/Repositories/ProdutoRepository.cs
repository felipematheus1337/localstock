
using Localstockk.Domain;

namespace Localstockk.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;

        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Produto ObterPorId(int id) => _context.Produtos.Find(id);

        public IEnumerable<Produto> ObterTodos() => _context.Produtos.ToList();

        public void Adicionar(Produto produto) => _context.Produtos.Add(produto);

        public void Atualizar(Produto produto) => _context.Produtos.Update(produto);

        public void Remover(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto != null)
                _context.Produtos.Remove(produto);
        }

        public void SaveChanges() => _context.SaveChanges();

        public Produto Create(Produto produto)
        {
            var entityEntry =  _context.Produtos.Add(produto);
            _context.SaveChanges();
            return entityEntry.Entity;

        }
    }
}
