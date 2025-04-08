using Localstockk.Data.Repositories;
using Localstockk.Mappings;
using Localstockk.Services;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
         var produtoService = InitializeDependencyInjections();

        int i = 0;

        while (i != 0)
        {

        }



    }


    private static IProdutoService  InitializeDependencyInjections()
    {
        var services = new ServiceCollection();

        services.AddAutoMapper(typeof(ProdutoProfile));

        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoService, ProdutoService>();

        var serviceProvider = services.BuildServiceProvider();


        return serviceProvider.GetRequiredService<IProdutoService>();


    }
}
