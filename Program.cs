Console.WriteLine("Digite uma letra");

switch (Console.ReadLine())
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine("Vogal");
    break;

    default:
    Console.WriteLine("Não é uma vogal");
    break;
}




































// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }

// else if(possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
// }
