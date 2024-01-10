using System;

class Jogo
{
    void MensagemBoasVindas()
    {
        Console.WriteLine(@"
█▄▄ █▀▀ █▀▄▀█ ▄▄ █░█ █ █▄░█ █▀▄ █▀█   ▄▀█ █▀█   █▀▄▀█ █░█ █▄░█ █▀▄ █▀█   █▀▄ ▄▀█ █▀   █▀█ █▀█ █▀▀ █░█ ▄▀█ █▀ █
█▄█ ██▄ █░▀░█ ░░ ▀▄▀ █ █░▀█ █▄▀ █▄█   █▀█ █▄█   █░▀░█ █▄█ █░▀█ █▄▀ █▄█   █▄▀ █▀█ ▄█   █▀▄ █▄█ █▄▄ █▀█ █▀█ ▄█ ▄");
    }

    void EscolherCaminho()
    {
        Console.WriteLine("\nVocê está diante de duas cavernas misteriosas. Uma delas leva ao caminho da aventura e a outra ao caminho do conhecimento.");
        Console.WriteLine("Qual caverna você escolhe explorar? Digite 1 ou 2:");
        
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine("Você escolheu a Caverna da Aventura!");
            // Aqui você pode prosseguir com uma historia de aventura.
            Console.WriteLine("Prepare-se para enfrentar perigos desconhecidos e desvendar mistérios emocionantes!\n");
        }
        else if (escolha == "2")
        {
            Console.WriteLine("Você escolheu a Caverna do Conhecimento!");
            // Aqui você pode prosseguir com uma historia mais focada em conhecimento e desafios intelectuais.
            Console.WriteLine("Prepare-se para aprender conceitos geológicos complexos e enfrentar enigmas intrigantes!\n");
        }
        else
        {
            Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2 para prosseguir.");
            EscolherCaminho(); // Caso a escolha seja invalida, chama a funcao novamente para nova tentativa.
        }
    }
    void ExibirSinopse()
    {
        Console.WriteLine("**\"As Crônicas da Geologia Fantástica\"**");
        Console.WriteLine("Em um mundo mágico onde as rochas escondem segredos ancestrais e a terra pulsa com energia desconhecida, você é um destemido aventureiro em busca de conhecimento e aventura. Neste reino encantado, a Geologia é uma ciência poderosa e os minerais possuem propriedades místicas.");
        Console.WriteLine("A jornada começa quando você descobre um antigo livro que narra a lenda das rochas mágicas, capazes de conceder habilidades inimagináveis aos seus portadores. Inspirado pela ideia de desvendar os segredos ocultos sob a superfície da Terra, você parte em busca dessas pedras preciosas, enfrentando perigos e desafios pelo caminho.");
        Console.WriteLine("Ao longo da sua jornada, você encontrará criaturas místicas da geologia, como o Gigante de Granito, o Dragão do Diamante e o Elemental da Rocha, que protegem os tesouros geológicos com fúria e astúcia. Para obter o poder das rochas mágicas, você precisará compreender as características geológicas únicas de cada região e enfrentar testes de habilidade e conhecimento.");
        Console.WriteLine("No seu percurso, você encontrará sábios geólogos que compartilharão seu vasto conhecimento sobre a terra e suas formações. Aprenderá sobre os processos da geomorfologia, a história geológica do mundo e a influência dos minerais na magia dessa terra encantada.");
        Console.WriteLine("Aventuras emocionantes, amizades inesperadas e descobertas surpreendentes aguardam você nas Crônicas da Geologia Fantástica. Aprenda a interpretar pistas geológicas para desvendar enigmas antigos e enfrentar desafios épicos. Prove-se como um verdadeiro aventureiro da geologia e desvende o destino místico que aguarda aqueles que entendem os segredos da Terra.");
        Console.WriteLine("Neste mundo de magia e conhecimento, apenas os mais corajosos e sábios geólogos serão capazes de alcançar o poder supremo das rochas mágicas e desvendar a verdadeira essência da Geologia Fantástica!");
    }


    static void Main(string[] args)
    {
        Jogo jogo = new Jogo();
        jogo.MensagemBoasVindas();

        Console.WriteLine("Bem-vindo ao mundo das rochas, meu destemido aventureiro!");
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();

        Console.WriteLine("Agora, informe o seu gênero: 1 - aventureiro, 2 - aventureira.");
        string genero = Console.ReadLine().ToLower();

        switch (genero)
        {
            case "1":
                Console.WriteLine($"Bem-vindo {nome}!");
                break;
            case "2":
                Console.WriteLine($"Bem-vinda {nome}!");
                break;
            default:
                Console.WriteLine($"Gênero não reconhecido para {nome}.");
                break;
        }
        Console.WriteLine("\nAgora, vamos conhecer a história do jogo:");
        jogo.ExibirSinopse();
    }
}
