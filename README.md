# agenda-mvc

Sistema simples de agenda de contatos desenvolvido em ASP.NET Core MVC, utilizando Entity Framework Core com banco de dados em memória.

## Funcionalidades

- Listar contatos
- Criar novo contato
- Editar contato existente
- Visualizar detalhes de um contato
- Excluir contato

## Estrutura do Projeto

- **Controllers/ContatoController.cs**: Controlador principal, responsável pelas operações CRUD dos contatos.
- **Models/Contato.cs**: Modelo da entidade Contato, com os campos: Nome, Telefone, Email e Ativo.
- **Context/AgendaContext.cs**: Contexto do Entity Framework, configurado para usar banco de dados em memória.
- **Views/Contato/**: Páginas para listar, criar, editar, visualizar e excluir contatos.
- **Views/Shared/**: Layout e página de erro compartilhada.

## Tecnologias Utilizadas

- .NET 9.0
- ASP.NET Core MVC
- Entity Framework Core (InMemory)
- C#

## Como Executar

1. **Pré-requisitos**:
   - [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) ou superior instalado.

2. **Clonar o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/agenda-mvc.git
   cd agenda-mvc
   ```

3. **Restaurar dependências**:
   ```bash
   dotnet restore
   ```

4. **Executar o projeto**:
   ```bash
   dotnet run
   ```

5. Acesse no navegador: `https://localhost:5001` ou `http://localhost:5000`

## Observações

- O projeto utiliza banco de dados em memória, ou seja, os dados são perdidos ao reiniciar a aplicação.
- Ideal para fins de estudo e demonstração de CRUD com ASP.NET Core MVC.

## Estrutura da Entidade Contato

```csharp
public class Contato : Entity
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public bool Ativo { get; set; }
}
```

## Licença

Este projeto está sob a licença MIT.