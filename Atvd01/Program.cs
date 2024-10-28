using ExemploFundamentos.Models;


Calculadora calc = new Calculadora();
Console.WriteLine("Digite dois números: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int escolha = Convert.ToInt32(Console.ReadLine());
while(escolha != 0)
{
    Console.WriteLine("Digite qual é o ")
    switch
    {
        case 1:
        calc.Somar(x,y);
        break;
        case 2:
        calc.Subtrair(x,y);
        break;
        case 3:
        calc.Multiplicar(x,y);
    }
}

    
























/*Console.WriteLine("Digite uma letra, caro usuário: ");
string letra = Console.ReadLine();

switch(letra) {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma Vogal");
        break;
}
*/












/*int quantidadeEmEstoque = 10;
Console.WriteLine($"Digite a quantidade que deseja comprar: ");
int quantidadeCompra = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"É possível realizar a compra? {quantidadeEmEstoque >= quantidadeCompra}");

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada!!");
}
else
{
    Console.WriteLine($"Desculpe. Não temos a quantidade ({quantidadeCompra}) desejada.");
}
*/



