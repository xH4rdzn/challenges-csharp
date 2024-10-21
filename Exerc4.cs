namespace Fundamentos;

public class Exerc4
{
    public static void exerc4()
    {
        string input;
        Console.WriteLine("Digite uma ou mais palavras:");
        input = Console.ReadLine();
        string inputSemEspaco = input.Replace(" ", "");
        Console.WriteLine("A palavra/todas as palavras inseridas possuem: " + inputSemEspaco.Length + " caracteres");
    }
}
