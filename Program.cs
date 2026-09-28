using System.Runtime.CompilerServices;

class Program
{
    static string CadastrarAluno()
    {
        
        Console.WriteLine("Digite o nome do aluno: ");
        string? nomeAluno = Console.ReadLine();
        while (nomeAluno.Length < 1)
        {
            Console.WriteLine("Digite o nome do aluno novamente: ");
            nomeAluno = Console.ReadLine();
        }
        return nomeAluno;

    }

    static double[] LancarNotas()
    {
        double[] notas = new double[3];

        Console.WriteLine("Digite as três notas do aluno: ");
        for (int i = 0; i < 3; i++)
        {
            bool sucessoConversao = false;
            while (!sucessoConversao)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                string nota = Console.ReadLine();
                sucessoConversao = double.TryParse(nota, out notas[i]);

                if (!sucessoConversao)
                {
                    Console.WriteLine("Digite novamente.");
                }
            }
        }
        return notas;
    }

    static double CalcularMedia(double[] notas)
    {
        double somaNotas = 0;

        foreach (double nota in notas)
        {
            somaNotas += nota;
        }   

        return Math.Round(somaNotas / notas.Length, 2);
    }

    static void ExibirSituacao(double mediaAluno, string nomeAluno)
    {
        const double MEDIA_APROVACAO = 7.0;
        const double MEDIA_RECUPERACAO = 5.0;

        if (mediaAluno >= MEDIA_APROVACAO)
        {
            Console.WriteLine("O aluno " + nomeAluno + " foi aprovado com a média " + mediaAluno);
        }
        else if (mediaAluno >= MEDIA_RECUPERACAO)
        {
            Console.WriteLine("O aluno " + nomeAluno + " está de recuperação com a média " + mediaAluno);
        }
        else
        {
            Console.WriteLine("O aluno " + nomeAluno + " está reprovado com a média " + mediaAluno);
        }
    }

    static int Main(string[] args)
    {
        string nomeAluno = "";
        double[] notas = new double[3];

        while (true)
        {
            Console.WriteLine("\n================================================================");
            Console.WriteLine("--------------------- Calculadora de Notas ---------------------");
            Console.WriteLine("---------------------  Escolha uma opção:  ---------------------");
            Console.WriteLine("--------------------- 1 - Cadastrar Aluno  ---------------------");
            Console.WriteLine("--------------------- 2 - Lançar Notas     ---------------------");
            Console.WriteLine("--------------------- 3 - Calcular Média   ---------------------");
            Console.WriteLine("--------------------- 4 - Sair             ---------------------");
            Console.WriteLine("================================================================");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    nomeAluno = CadastrarAluno();
                    Console.WriteLine("\nAluno " + nomeAluno + " adicionado!");
                    break;
                case "2":
                    notas = LancarNotas();
                    Console.WriteLine("\nNotas lançadas!");
                    break;
                case "3":
                    double mediaAluno = CalcularMedia(notas);
                    Console.WriteLine("\nMédia calculada!");
                    ExibirSituacao(mediaAluno, nomeAluno);
                    break;
                case "4":
                    return 1;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente!\n");
                    break;

            }
        }
    }
}