// Testar as APIs
//Minimal APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//Minimal API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Lista de produtos
List<Produto> produtos = new List<Produto>
{     new Produto("Camiseta Básica", 19.99m, "S"),
      new Produto("Calça Jeans", 49.99m, "M"),
      new Produto("Tênis Esportivo", 89.99m, "40"),
      new Produto("Jaqueta de Couro", 129.99m, "L"),
      new Produto("Óculos de Sol", 39.99m, "Único"),
      new Produto("Relógio Digital", 159.99m, "Único"),
      new Produto("Mochila Escolar", 45.99m, "M"),
      new Produto("Boné Ajustável", 15.99m, "Único"),
      new Produto("Camisa de Manga Longa", 34.99m, "XL"),
      new Produto("Tênis Casual", 69.99m, "42"),
};

//Endpoints - Funcionalidade
//Request/Requisição - URL e o método/verbo HTTP
app.MapGet("/", () => "API de Produtos!");

// GET: http://localhost:5117/produto/listar 

app.MapGet("/produto/listar", () => {
    return produtos;
}); 

// POST: http://localhost:5117/produto/cadastrar 
app.MapGet("/produto/listar/cadastrar/{nome}", () => {
    produtos produto = new produtos();
    produto.Nome = ;
    produtos.Add(produto);
    return produtos;
});

app.MapGet("/segundafuncionalidade", () => "Segunda Funcionalidade");

app.MapGet("/retornarfuncionalidade", () => 

{ 
    dynamic endereço = new {
        rua = "Praça Osorio",
        numero = 125,
    };
    return endereço;

});
// Criar novas Funcionalidades/ Endpoints para receber dados 
// - Pelo URL da requisição 
// - Corpo da requisiçao 
// Guarda--r as informações em uma lista

app.Run();

Produto produto = new Produto();
produto.preco = 78883;
// produto.setPreco(8800);
Console.WriteLine("Preço: " + produto.preco);
// Console.WriteLine("Preço: " + get.Preco());
