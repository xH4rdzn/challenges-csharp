namespace Fundamentos;

public class Exerc3
{
    public static void exerc3()
    {
        string valor1, valor2;

        double a, b, soma, subtracao, multiplicacao, divisao, media;

        Console.Write("Insira o valor para o primeiro valor: ");
        valor1 = Console.ReadLine();
        a = Convert.ToDouble(valor1);
        Console.Write("Insira o valor para o segundo valor: ");
        valor2 = Console.ReadLine();
        b = Convert.ToDouble(valor2);
        soma = Soma(a, b);
        subtracao = Subtracao(a, b);
        multiplicacao = Multiplicacao(a, b);
        divisao = Divisao(a, b);
        media = Media(a, b);
        Console.WriteLine("O resultado da soma é: " + soma);
        Console.WriteLine("O resultado da subtração é: " + subtracao);
        Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
        Console.WriteLine("O resultado da divisão é: " + divisao);
        Console.WriteLine("O média entre os dois valores é: " + media);
        
    }

    static double Soma(double a, double b) { return a + b; }

    static double Subtracao(double a, double b) { return a - b; }

    static double Multiplicacao(double a, double b) { return a * b; }

    static double Divisao(double a, double b) {
        if (b == 0)
        {
            return 0;
        } else
        {
            return a / b;
        }
    }

    static double Media(double a, double b) {
        return (a + b) / 2;
    }
}
