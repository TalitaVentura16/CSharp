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


    static string bemVindo =
    "░▄░█░░░▄▀▀▀▀▀▄░░░█░▄░\n" +
    "▄▄▀▄░░░█─▀─▀─█░░░▄▀▄▄\n" +
    "░░░░▀▄▒▒▒▒▒▒▒▒▒▄▀░░░░\n" +
    "░░░░░█────▀────█░░░░░\n" +
    "░░░░░█────▀────█░░░░░ \n";

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

    

    static void Jogar ()
    {
        Console.WriteLine("Bem-Vindo ao jogo da Forca!");
        Console.WriteLine(bemVindo); 
        Console.WriteLine(gameOver);
        Console.WriteLine(vitoria);
    }

    static void Main()
    {
        Jogar();
    }

}
