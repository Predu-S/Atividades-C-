using ExemploFundamentos.Models;


Calculadora calc = new Calculadora();
Console.WriteLine("Digite dois números: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int operacoes;
string continuar = "s";
while(continuar == "s")
{
    Console.WriteLine("Digite o que você deseja fazer:");
    operacoes = Convert.ToInt32(Console.ReadLine());

    
    switch(operacoes)
    {
        case 1:
        calc.Somar(x,y);
        break;

        case 2:
        calc.Subtrair(x,y);
        break;

        case 3:
        calc.Multiplicar(x,y);
        break;

        case 4:
        calc.Dividir(x,y);
        break;

        default:
        Console.WriteLine("Você escolheu a opção errada");
        break;
    }
    Console.WriteLine($"Deseja continuar com os seguintes números: {x} e {y}?");
    string EscolhaNumeros = Console.ReadLine();
    switch(EscolhaNumeros)
    {
        case "n":
        Console.WriteLine("Escolha dois números:");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        break;

        case "s":
        break;

        default:
        Console.WriteLine($"Você escolheu {EscolhaNumeros}, porém não existe dentre as opções."+ "\n" +"Escolha novamente:");
        EscolhaNumeros = Console.ReadLine();
        break;
    }
    Console.WriteLine("Você deseja continuar?" + "\n" + " s ou n.");
    continuar = Console.ReadLine();


    
}
Console.WriteLine("Você finalizou a calculadora.");
    



























