using System.Globalization;

namespace Fundamentos;

public class Exerc6
{
    public static void exerc6()
    {
        string op;
        int opcao = 0;
        do
        {
            Console.WriteLine("\nEscolha como quer que a data seja exibida: ");
            Console.WriteLine("1 - Formato Completo");
            Console.WriteLine("2- Apenas a data no formato dd/mm/yyyy");
            Console.WriteLine("3- Apenas a hora, no formato 24h");
            Console.WriteLine("4- A data com o mês por extenso.");
            Console.WriteLine("0- Sair");
            op = Console.ReadLine();
            opcao = Convert.ToInt32(op);

            switch(opcao)
            {
                case 1: 
                    { 
                        DateTime diaCompleto = DateTime.Now;
                        Console.WriteLine();
                        Console.WriteLine(diaCompleto.ToString("F", new CultureInfo("pt-BR")));
                    }
                    break;
                case 2: 
                    {
                        DateTime dia = DateTime.UtcNow;
                        string diaFormatado = $"{dia.Day}/{dia.Month}/{dia.Year}";
                        Console.WriteLine();
                        Console.WriteLine(diaFormatado.ToString(new CultureInfo("pt-BR")));
                    }
                    break;
                case 3: 
                    {
                        DateTime hora = DateTime.Now;
                        string horaFormatada = hora.ToString("t", new CultureInfo("pt-BR"));
                        Console.WriteLine();
                        Console.WriteLine(horaFormatada);
                    }
                    break;
                case 4: 
                    {
                        DateTime agora = DateTime.UtcNow;
                        string agoraFormatado = agora.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));
                        Console.WriteLine();
                        Console.WriteLine(agoraFormatado);
                    }
                    break;
                case 0:
                    {
                        Console.WriteLine("Encerrando...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção Invalida. Tente Novamente!");
                    }
                    break;
            }
        }
        while (opcao != 0);
    }
}
