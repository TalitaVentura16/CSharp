/// <summary>
/// O jogo da forca, o objetivo desse programa eh que o usuario consiga advinhar a palavra antes do bonequinho morrer
/// </summary>

using System;
using System.Collections.Generic;
class Jogo
{
    static List<string> palavras = new List<string>
    {
        // Palavras da lista
        "Azul",
        "Computador",
        "Gelo seco",
        "Refrigerante",
        "Janela"
    };

     static string gameOver = 
    "       Fim de Jogo    \n" +
    "       Você Perdeu    \n" +
    "──▄────▄▄▄▄▄▄▄────▄───\n" + 
    "─▀▀▄─▄█████████▄─▄▀▀──\n" +
    "─────██─▀███▀─██──────\n" +
    "───▄─▀████▀████▀─▄────\n" + 
    "─▀█────██▀█▀██────█▀──\n";

    static string vitoria = 
    "       Parabéns! \n  " +
    "     Você Ganhou!!!\n" +
    "──────▄▀▄─────▄▀▄\n" +
    "─────▄█░░▀▀▀▀▀░░█▄\n" +  
    "─▄▄──█░░░░░░░░░░░█──▄▄\n" +
    "█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█\n";

    static string forca =
    " ▄▄▄██▀▀▀▒█████    ▄████  ▒█████     ▓█████▄  ▄▄▄\n " +     
    "   ▒██  ▒██▒  ██▒ ██▒ ▀█▒▒██▒  ██▒   ▒██▀ ██▌▒████▄   \n " + 
    "   ░██  ▒██░  ██▒▒██░▄▄▄░▒██░  ██▒   ░██   █▌▒██  ▀█▄  \n " +
    "▓██▄██▓ ▒██   ██░░▓█  ██▓▒██   ██░   ░▓█▄   ▌░██▄▄▄▄██ \n " +
    " ▓███▒  ░ ████▓▒░░▒▓███▀▒░ ████▓▒░   ░▒████▓  ▓█   ▓██▒\n " +
    " ▒▓▒▒░  ░ ▒░▒░▒░  ░▒   ▒ ░ ▒░▒░▒░     ▒▒▓  ▒  ▒▒   ▓▒█░\n " +
    " ▒ ░▒░    ░ ▒ ▒░   ░   ░   ░ ▒ ▒░     ░ ▒  ▒   ▒   ▒▒ ░\n " +
    " ░ ░ ░  ░ ░ ░ ▒  ░ ░   ░ ░ ░ ░ ▒      ░ ░  ░   ░   ▒   \n " +
    " ░   ░      ░ ░        ░     ░ ░        ░          ░  ░\n " +
    "                                      ░                \n " +
    "  █████▒▒█████   ██▀███   ▄████▄   ▄▄▄       ▐██▌      \n " +
    "▓██   ▒▒██▒  ██▒▓██ ▒ ██▒▒██▀ ▀█  ▒████▄     ▐██▌      \n " +
    "▒████ ░▒██░  ██▒▓██ ░▄█ ▒▒▓█    ▄ ▒██  ▀█▄   ▐██▌      \n " +
    "░▓█▒  ░▒██   ██░▒██▀▀█▄  ▒▓▓▄ ▄██▒░██▄▄▄▄██  ▓██▒      \n " +
    "░▒█░   ░ ████▓▒░░██▓ ▒██▒▒ ▓███▀ ░ ▓█   ▓██▒ ▒▄▄       \n " +
    " ▒ ░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░ ░▒ ▒  ░ ▒▒   ▓▒█░ ░▀▀▒      \n " +
    " ░       ░ ▒ ▒░   ░▒ ░ ▒░  ░  ▒     ▒   ▒▒ ░ ░  ░      \n " +
    " ░ ░   ░ ░ ░ ▒    ░░   ░ ░          ░   ▒       ░      \n " +
    "           ░ ░     ░     ░ ░            ░  ░ ░         \n " +
    "                         ░                             \n " ;

    static string cabeca = 
    "░░░░░░░░░░░░░░░░░░░\n" +
    "░░░░░░░▄▄▄░░░░░░░░░\n" +
    "░░░░░░▐▀█▀▌░░░░░░░░\n" +
    "░░░░░░▐█▄█▌░░░░░░░░\n" +
    "░░░░░░░▀▄▀░░░░░░░░░\n";

    static string tronco =
        "░░░░░░░░░░░░░░░░░░░\n" +
    "░░░░░░░▄▄▄░░░░░░░░░\n" +
    "░░░░░░▐▀█▀▌░░░░░░░░\n" +
    "░░░░░░▐█▄█▌░░░░░░░░\n" +
    "░░░░░░░▀▄▀░░░░░░░░░\n"+
    "░░░░░▄▄▄██▀▀▀▀░░░░░\n" +
    "░░░░░░▄▄▄█░▀▀░░░░░░\n" +
    "░░░░░░▄▄▄▐▌▀▀▀░░░░░\n" +
    "░░░░░░░▄▄░█░▀▀░░░░░\n" +
    "░░░░░░░▄░▀█▀░▀░░░░░\n" +
    "░░░░░░░░▄▄▐▌▄▄░░░░░\n";

    static string bracoEsquerdo =
    "░░░░░░░░░░░░░░░░░░░\n" +
    "░░░░░░░▄▄▄░░░░░░░░░\n" +
    "░░░░░░▐▀█▀▌░░░░░░░░\n" +
    "░░░░░░▐█▄█▌░░░░░░░░\n" +
    "░░░░░░░▀▄▀░░░░░░░░░\n" +
    "░░░░░▄▄▄██▀▀▀▀░░░░░\n" +
    "░░░░█▀▄▄▄█░▀▀░░░░░░\n" +
    "░░░░▌░▄▄▄▐▌▀▀▀░░░░░\n" +
    "░▄░▐░░░▄▄░█░▀▀░░░░░\n" +
    "░▀█▌░░░▄░▀█▀░▀░░░░░\n";


    static string bracoDireito =
    "░░░░░░░░░░░░░▄▐░░░░\n" +
    "░░░░░░░▄▄▄░░▄██▄░░░\n" +
    "░░░░░░▐▀█▀▌░░░░▀█▄░\n" +
    "░░░░░░▐█▄█▌░░░░░░▀█▄\n" +
    "░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀\n" +
    "░░░░░▄▄▄██▀▀▀▀░░░░░\n" +
    "░░░░█▀▄▄▄█░▀▀░░░░░░\n" +
    "░░░░▌░▄▄▄▐▌▀▀▀░░░░░\n" +
    "░▄░▐░░░▄▄░█░▀▀░░░░░\n" +
    "░▀█▌░░░▄░▀█▀░▀░░░░░\n";


    static string pernaEsquerda =
    "░░░░░░░░░░░░░▄▐░░░░\n" +
    "░░░░░░░▄▄▄░░▄██▄░░░\n" +
    "░░░░░░▐▀█▀▌░░░░▀█▄░\n" +
    "░░░░░░▐█▄█▌░░░░░░▀█▄\n" +
    "░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀\n" +
    "░░░░░▄▄▄██▀▀▀▀░░░░░\n" +
    "░░░░█▀▄▄▄█░▀▀░░░░░░\n" +
    "░░░░▌░▄▄▄▐▌▀▀▀░░░░░\n" +
    "░▄░▐░░░▄▄░█░▀▀░░░░░\n" +
    "░▀█▌░░░▄░▀█▀░▀░░░░░\n" +
    "░░░░░░░░▀███▀█▄░░░░\n" +
    "░░░░░░░▐▌▀▄▀▄▀▐░░░░\n" +
    "░░░░░░░▐▀░░░░░░░░░░\n" +
    "░░░░░░░█░░░░░░░░░░░\n" +
    "░░░░░░▐▌░░░░░░░░░░░\n";

    static string pernaDireita =
    "░░░░░░░░░░░░░▄▐░░░░\n" +
    "░░░░░░░▄▄▄░░▄██▄░░░\n" +
    "░░░░░░▐▀█▀▌░░░░▀█▄░\n" +
    "░░░░░░▐█▄█▌░░░░░░▀█▄\n" +
    "░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀\n" +
    "░░░░░▄▄▄██▀▀▀▀░░░░░\n" +
    "░░░░█▀▄▄▄█░▀▀░░░░░░\n" +
    "░░░░▌░▄▄▄▐▌▀▀▀░░░░░\n" +
    "░▄░▐░░░▄▄░█░▀▀░░░░░\n" +
    "░▀█▌░░░▄░▀█▀░▀░░░░░\n" +
    "░░░░░░░░▀███▀█▄░░░░\n" +
    "░░░░░░░▐▌▀▄▀▄▀▐░░░░\n" +
    "░░░░░░░▐▀░░░░░░▐▌░░\n" +
    "░░░░░░░█░░░░░░░░█░░\n" +
    "░░░░░░▐▌░░░░░░░░░█░\n";

    // Definicao das variaveis
    static string palavraSecreta;
    static string palavraEscondida; 
    static int erros = 0;

    
    // Funcao para escolher uma palavra aleatoria
    static void EscolherPalavraAleatoria()
    {
        // para que a palavra seja escolhida de modo aleatorio
        Random random = new Random();
        int indice = random.Next(0, palavras.Count);
        palavraSecreta = palavras[indice];
        InicializarPalavraEscondida();
    }

    static void InicializarPalavraEscondida()
    {
        // nova palavra escondida 
        palavraEscondida = new string('_', palavraSecreta.Length);
    }

    static void ExibePalavraEscondida ()
    {   
        // Para que a palavra seja exibida de modo "invisivel"
        Console.WriteLine(palavraEscondida);
    }

    static void ExibirPalavraEscondida()
    {
        // para exibir a palavra seja exibida de "  "
        char letra = Console.ReadKey().KeyChar;

        // Verifique se a letra existe na palavra secreta
        bool acertou = false;
        for (int i = 0; i < palavraSecreta.Length; i++)
        {
            if (palavraSecreta[i] == letra)
            {
                palavraEscondida = palavraEscondida.Substring(0, i) + letra + palavraEscondida.Substring(i + 1);
                acertou = true;
            }
        }

        if (!acertou)
        {
            erros++;
        }
    }

        static void AdivinharLetra()
    {
        // Obtenha a letra do jogador (pode ser melhorado para tratar inputs inválidos)
        Console.WriteLine("Digite uma letra:");
        char letra = Console.ReadKey().KeyChar;

        // Verifique se a letra está na palavra secreta
        bool acertou = false;
        for (int i = 0; i < palavraSecreta.Length; i++)
        {
            if (palavraSecreta[i] == letra)
            {
                palavraEscondida = palavraEscondida.Substring(0, i) + letra + palavraEscondida.Substring(i + 1);
                acertou = true;
            }
        }

        if (!acertou)
        {
            erros++;
        }
    }

    static void DesenhaBonequinho()
    {
        // Exiba a representação do bonequinho de acordo com os erros
        Console.WriteLine(erros >= 1 ? "  " : " ");
        Console.WriteLine(erros >= 2 ? cabeca : " ");
        Console.WriteLine(erros >= 3 ? tronco : " ");
        Console.WriteLine(erros >= 4 ? bracoEsquerdo : " ");
        Console.WriteLine(erros >= 5 ? bracoDireito : " ");
        Console.WriteLine(erros >= 6 ? pernaEsquerda : " ");
        Console.WriteLine(erros >= 7 ? pernaDireita : " ");

    }

    // O objetivo dessa funcao eh obter informacoes sobre o jogador
    static void introducao ()
    {
        string nomeJogador;

        // Para obter o nome do jogador
        Console.WriteLine("\nQual o seu nome, jogador?");
        nomeJogador = Console.ReadLine();

        // Para que a sinopse seja introduzida
        string sinopse = "Você acaba de acordar em meio à escuridão sufocante, seus olhos se abrem para uma sala sem janelas,\n" +
        "onde a luz vacilante de uma vela dança nas paredes, pintando sombras que parecem se mover. Sua única\n" +
        "esperança de escapar deste pesadelo é decifrar a palavra secreta, guardiã da chave que liberta a única\n" +
        $"porta deste lugar sinistro. Mas cuidado {nomeJogador}... cada erro alimenta as sombras famintas que espreitam nas\n" +
        "trevas, prontas para devorar sua chance de sobrevivência...";

        Console.WriteLine(sinopse);
    }    
    
    static void Jogar ()
    {
        Console.WriteLine(forca);
        introducao();   
        EscolherPalavraAleatoria();

        while (erros <8 && palavraEscondida.Contains("_"))
        {
            Console.Clear();
            DesenhaBonequinho();
            ExibePalavraEscondida();
            AdivinharLetra();
        }
        Console.Clear();
        Console.WriteLine(forca);
        DesenhaBonequinho();
        ExibirPalavraEscondida();

        if (erros >= 7)
        {
            Console.WriteLine(gameOver);
            Console.WriteLine($"Atenção! A palavra era: {palavraSecreta}");
        }
        else
        {
            Console.WriteLine(vitoria);
        }
    }

    static void Main()
    {
        Jogar();
    }
}