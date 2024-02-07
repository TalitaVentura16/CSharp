/// <summary>
/// O jogo da forca, o objetivo desse programa eh que o usuario consiga advinhar a palavra antes do bonequinho morrer
/// </summary>

using System;
using System.Collections.Generic;
class Jogo
{
    class PalavraDica
    {
        public string Palavra { get; set; }
        public string Dica { get; set; }
    }   

    //Lista de palavras e dicas
    static List<PalavraDica> palavrasEDicas = new List<PalavraDica>
    {
        new PalavraDica { Palavra = "Azul", Dica = "Cor do céu em um dia claro" },
        new PalavraDica { Palavra ="computador", Dica = "Dispositivo eletrônico" }, 
        new PalavraDica { Palavra ="gelo seco", Dica = "CO2(s)" },
        new PalavraDica { Palavra ="refrigerante", Dica = "Bebida gaseificada" },
        new PalavraDica { Palavra ="janela", Dica = "Parte da casa" },
        new PalavraDica { Palavra ="karl marx", Dica = "Lider Comunista" },
        new PalavraDica { Palavra = "breaking bad", Dica = "Série de Televisão" }
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
        int indice = random.Next(0, palavrasEDicas.Count);
        palavraSecreta = palavrasEDicas[indice].Palavra;
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

        //Funcao para advinhar uma letra
        static void AdivinharLetra()
        {
        // Dica para a palavra secreta
        Console.WriteLine("Atenção! A dica para a palavra Secreta é: " + palavrasEDicas.Find(x => x.Palavra == palavraSecreta)?.Dica);

        // Solicitar uma letra ao jogador
        Console.WriteLine("Digite uma letra: ");
        char letra = Console.ReadKey().KeyChar;

        if (letra != ' ' && !Char.IsLetter(letra))
        {
            Console.WriteLine("\nPor favor, digite uma letra válida.");
            AdivinharLetra();
            return;
        }

        bool acertou = false;
        for (int i = 0; i < palavraSecreta.Length; i++)
        {
            if (Char.ToLower(palavraSecreta[i]) == Char.ToLower(letra))
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

    static string DesenhaBonequinho()
    {
        // Exiba a representação do bonequinho de acordo com os erros
        string[] partesDoBonequinho = { "", cabeca, tronco, bracoEsquerdo, bracoDireito, pernaEsquerda, pernaDireita};
        string bonequinho = "";

        for (int i = 0; i < erros; i++) // Corrigido aqui
        {
            bonequinho += partesDoBonequinho[i] + "\n";
        }
        return bonequinho;
    }

    // O objetivo dessa funcao eh obter informacoes sobre o jogador

    static string nomeJogador;

    static void introducao ()
    {

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

        static void fimJogo ()
    {
        string textoFinal = "\nUm grito agudo irrompe pela sala sombria, enquanto um vento gélido percorre cada centímetro do seu corpo. \n" + 
        "Sombras negras emergem das profundezas da escuridão, envolvendo seus braços e pernas. Gradualmente \n" +
        $"o mundo ao seu redor desvanece em total escuridão. Enfim, {nomeJogador}, o jogo acabou e o mundo ao seu redor \n" +
        "chegou ao fim...\n";

        Console.WriteLine(textoFinal);
    } 
      
    static void Jogar ()
    {
        Console.WriteLine(forca);
        introducao();   
        EscolherPalavraAleatoria();

        while (erros <7 && palavraEscondida.Contains("_"))
        {
            Console.WriteLine(DesenhaBonequinho());
            ExibePalavraEscondida();
            AdivinharLetra();
        }
        
        Console.WriteLine(DesenhaBonequinho());      
        ExibirPalavraEscondida();

        if (erros >= 7)
        {
            fimJogo();
            Console.WriteLine(gameOver);
            Console.WriteLine($"Atenção! A palavra era: {palavraSecreta}");
        }
        else
        {
            Console.WriteLine("Parabéns! Você ganhou!\n");
            Console.WriteLine(vitoria);
        }
    }

    static void Main()
    {
        Jogar();
    }
}