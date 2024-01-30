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

    static string sinopse = "Caro {nomeJogador}, em meio à escuridão sufocante, seus olhos se abrem para uma sala sem janelas,\n" +
    "onde a luz vacilante de uma vela dança nas paredes, pintando sombras que parecem se mover. Sua única \n" +
    "esperança de escapar deste pesadelo é decifrar a palavra secreta, guardiã da chave que liberta a única \n" +
    "porta deste lugar sinistro. Mas cuidado... cada erro alimenta as sombras famintas que espreitam nas \n" +
    "trevas, prontas para devorar sua chance de sobrevivência... \n";


    // Funcao para escolher uma palavra aleatoria
    static string palavraAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(0, palavras.Count);
        return palavras[indice];
    }

    static void DesenhaBonequinho(int erro) 
    {
        Console.WriteLine(erro >= 1 ? "0" : " ");
        Console.WriteLine(erro >= 2 ? "|" : " ");
        Console.WriteLine(erro >= 3 ? "/" : " ");
        Console.WriteLine(erro >= 4 ? "\\" : " ");
        Console.WriteLine(erro >= 5 ? "//" : " ");
        Console.WriteLine(erro >= 6 ? "\\" : " ");
    }


    // O objetivo dessa funcao eh obter informacoes sobre o jogador
    static void infoJogador ()
    {
        string nomeJogador;

        // Para obter o nome do jogador
        Console.WriteLine("\nQual o seu nome, jogador?");
        nomeJogador = Console.ReadLine();

    }      
    static void Jogar ()
    {
        Console.WriteLine(forca);
        infoJogador();
        Console.WriteLine(sinopse);
    }

    static void Main()
    {
        Jogar();
    }
}