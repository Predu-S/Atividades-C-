using Atvd02.Models;


List<string> clientes = new List<string>();
string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
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
            string cliente = Console.ReadLine();
            clientes.Add(cliente);
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            string busca = Console.ReadLine();

            if (clientes.Contains(busca))
            {
                Console.WriteLine($"O cliente {busca} foi encontrado");
            }
            else
            {
                Console.WriteLine($"O cliente {busca} não foi encontrado");
            }
            break;

        case "3":
            Console.WriteLine("Apagamento de cliente");
            string apaga = Console.ReadLine();
            if (clientes.Contains(apaga))
            {
                clientes.Remove(apaga);  // Aqui, use 'apaga' em vez de 'Console.ReadLine()'
                Console.WriteLine($"O cliente {apaga} foi excluído com sucesso");
            }
            else
            {
                Console.WriteLine($"O cliente {apaga} não foi encontrado");
            }
            break;

        case "4":
            Console.WriteLine("Encerramento");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("Programa encerrado");
