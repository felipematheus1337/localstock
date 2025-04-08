using Localstockk.Data;
using Localstockk.Data.Repositories;
using Localstockk.Mappings;
using Localstockk.Services;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = InitializeDependencyInjections();

        var businessService = serviceProvider.GetRequiredService<BusinessService>();

        int op = -1;

        while (op != 0)
        {
            Console.WriteLine("\nDigite a operação que deseja:");
            Console.WriteLine("1 - Criar Produto");
            Console.WriteLine("2 - Buscar Produto por ID");
            Console.WriteLine("3 - Remover");
            Console.WriteLine("4 - Listar Todos");
            Console.WriteLine("0 - Sair");

            op = int.Parse(Console.ReadLine());

            businessService.ObterOp(op); // passa o controle pra sua lógica de negócio
        }
    }

    static ServiceProvider InitializeDependencyInjections()
    {
        var services = new ServiceCollection();

        services.AddAutoMapper(typeof(ProdutoProfile));
        services.AddDbContext<ApplicationContext>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<BusinessService>();

        return services.BuildServiceProvider();
    }
}
