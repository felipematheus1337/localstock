using Localstockk.Data.DTOs;
using Localstockk.ValueObjects;

namespace Localstockk.Services
{
    public class BusinessService
    {
        private readonly IProdutoService _produtoService;

        public BusinessService(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public void ObterOp(int op)
        {
            switch (op)
            {
                case 1:
                    CreateProduto();
                    break;
                case 2:
                    GetProduto();
                    break;
                case 3:
                    RemoveProduto();
                    break;
                case 4:
                    ListarTodos();
                    break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public void CreateProduto()
        {
            Console.WriteLine("Digite o nome do produto: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite a descrição do produto: ");
            string description = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            decimal value = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo do produto: 1 para Eletrônico, 2 para Artesanal");
            ProductType tipo = GetProductType(int.Parse(Console.ReadLine()));

            var dto = new ProdutoCreateDto(name, description, value, quantidade, tipo);
            _produtoService.Create(dto);

            Console.WriteLine("Produto criado com sucesso!");
        }

        public void GetProduto()
        {
            Console.Write("Digite o ID do produto: ");
            int id = int.Parse(Console.ReadLine());

            var produto = _produtoService.GetOne(id);

            if (produto == null)
                Console.WriteLine("Produto não encontrado.");
            else
                Console.WriteLine($"Produto: {produto.Name} - {produto.Value:C}");
        }

        public void ListarTodos()
        {
            var produtos = _produtoService.GetAll();

            foreach (var p in produtos)
                Console.WriteLine($"{p.Name} - {p.Value:C}");
        }

        public void RemoveProduto()
        {
            Console.Write("Digite o ID do produto que deseja remover: ");
            int id = int.Parse(Console.ReadLine());

            _produtoService.Remove(id);

            Console.WriteLine("Produto removido.");
        }

        private ProductType GetProductType(int t)
        {
            return t switch
            {
                1 => ProductType.HouseHould,
                2 => ProductType.Handmade,
                _ => throw new InvalidDataException("Tipo inválido.")
            };
        }
    }
}
