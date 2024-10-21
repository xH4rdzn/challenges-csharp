namespace Fundamentos;

public class Exerc1
{
    public static void exerc1()
    {
        Console.Write("Olá, digite seu nome: ");
        string nome = Console.ReadLine();
        string resultado = $"Olá, {nome}! Seja muito bem-vindo!";
        Console.WriteLine(resultado);
    }
}
