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
    }
}

