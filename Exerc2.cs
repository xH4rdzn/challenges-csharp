namespace Fundamentos;

public class Exerc2
{
    public static void exerc2()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine(nomeCompleto);
    }
}
