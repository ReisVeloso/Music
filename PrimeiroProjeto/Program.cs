// Screen Sound
//Linguagem fortemente tipada, temos que declarar o tipo de variável.
// Utilizar sempre aspas duplas para escrever as coisas
//Toda instrução deve terminar com ;
//Utiliza-se como padrão o Camel Case -> olaMundoTudoBem
// void é para funções que não retornam nada

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\nBem Vindo!");
};//@ é para arrumar
void opcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite sair para sair");

    Console.Write("\nDigite a sua opção: "); //Aparece a mensagem e na mesma linha executa o ReadLine
    string opcaoEscolhida = Console.ReadLine()!;//
    tratarOpcao(opcaoEscolhida);
};

void tratarOpcao(string op)
{
    switch (op)
    {
        case "1":
            Console.WriteLine($"Você escolheu {op} então vamos registrar uma banda!!!");
            break;

        case "2":
            Console.WriteLine($"Você escolheu {op} então vamos mostrar todas as bandas!!!");
            break;
        case "3":
            Console.WriteLine($"Você escolheu {op} então vamos avaliar uma banda!!!");
            break;
        case "4":
            Console.WriteLine($"Você escolheu {op} então vamos exibir a média de uma banda!!!");
            break;
        case "sair":
            Console.WriteLine($"Obrigado por utilizar nossa aplicação!!!");
            break;
        default:
            Console.WriteLine("Opção inválida, gentileza escolher novamente!");
            opcoesMenu();
            break;
    };
};


ExibirMensagemDeBoasVindas();
opcoesMenu();


