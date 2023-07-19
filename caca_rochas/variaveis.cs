using System;

class Jogo
{
    void MensagemBoasVindas()
    {
        Console.WriteLine(@"
█▄▄ █▀▀ █▀▄▀█ ▄▄ █░█ █ █▄░█ █▀▄ █▀█   ▄▀█ █▀█   █▀▄▀█ █░█ █▄░█ █▀▄ █▀█   █▀▄ ▄▀█ █▀   █▀█ █▀█ █▀▀ █░█ ▄▀█ █▀ █
█▄█ ██▄ █░▀░█ ░░ ▀▄▀ █ █░▀█ █▄▀ █▄█   █▀█ █▄█   █░▀░█ █▄█ █░▀█ █▄▀ █▄█   █▄▀ █▀█ ▄█   █▀▄ █▄█ █▄▄ █▀█ █▀█ ▄█ ▄");
    }

    static void Main(string[] args)
    {
        Jogo jogo = new Jogo();
        jogo.MensagemBoasVindas();

        Console.WriteLine("Bem-vindo ao mundo das rochas, meu destemido guerreiro!");
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();

        Console.WriteLine("Agora, informe o seu gênero: guerreiro, guerreira ou guerreire.");
        string genero = Console.ReadLine().ToLower();

        switch (genero)
        {
            case "guerreiro":
                Console.WriteLine($"Bem-vindo, guerreiro {nome}!");
                break;
            case "guerreira":
                Console.WriteLine($"Bem-vinda, guerreira {nome}!");
                break;
            case "guerreire":
                Console.WriteLine($"Bem-vinde, guerreire {nome}!");
                break;
            default:
                Console.WriteLine($"Gênero não reconhecido para {nome}.");
                break;
        }
    }
}
