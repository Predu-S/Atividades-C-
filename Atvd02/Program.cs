string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":    
            Console.WriteLine("Apagamento de cliente");
            break;

        case "4":    
            Console.WriteLine("Encerramento");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("Programa encerrado");