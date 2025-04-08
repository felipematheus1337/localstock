# 📦 LocalStock - Sistema de Gerenciamento de Produtos

## 🔍 Visão Geral
Sistema de gerenciamento de produtos desenvolvido em C# com:
- Arquitetura em camadas
- Entity Framework Core + SQL Server
- Interface via console application

## 🚀 Começando

### Pré-requisitos
- .NET 6.0+
- SQL Server ou Docker
- Git (opcional)

### Instalação
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/localstock.git
   cd localstock

# Configure a conexão:

# Edite a connection string em ApplicationContext.cs
## Execute as migrações:
dotnet ef database update

## Inicie o sistema:
dotnet run
🏗️ Estrutura do Código
Camada	Descrição
Domain/	Entidades do negócio
Data/	Acesso a dados e repositórios
Services/	Lógica de negócio
Mappings/	Configurações do AutoMapper


🛠️ Funcionalidades
// Exemplo de operações disponíveis
public interface IProdutoService
{
    ProdutoDto Create(ProdutoCreateDto dto);
    IEnumerable<ProdutoDto> GetAll();
    ProdutoDto GetOne(int id);
    void Remove(int id);
    void Update(ProdutoUpdateDto dto);
}
📊 Fluxo Principal
Configura DI Container

Inicia menu interativo

Processa operações:

Create/Read/Update/Delete

Listagem completa

💾 Persistência
Entity Framework Core

SQL Server

Repository Pattern

🔧 Dependências
xml
Copy
<!-- Principais pacotes NuGet -->
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.*"/>
<PackageReference Include="AutoMapper" Version="12.0.*"/>
Run HTML
🧪 Testando

Execute via console:
dotnet run
