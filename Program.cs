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

    static float[] LancarNotas()
    {
        float[] notas = new float[3];

        Console.WriteLine("Digite as três notas do aluno: ");
        for (int i = 0; i < 3; i++)
        {
            bool sucessoConversao = false;
            while (!sucessoConversao)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                string nota = Console.ReadLine();
                sucessoConversao = float.TryParse(nota, out notas[i]);

                if (!sucessoConversao)
                {
                    Console.WriteLine("Digite novamente.");
                }
            }
        }
        return notas;
    }

    static void CalcularMedia()
    {

    }

    static int Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("================================================================");
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
                    string nomeAluno = CadastrarAluno();
                    break;
                case "2":
                    float[] notas = LancarNotas();
                    break;
                case "3":

                case "4":
                    return 1;
                default:
                    Console.WriteLine("Opção inválida, tente novamente!\n");
                    break;

            }
        }
    }
}