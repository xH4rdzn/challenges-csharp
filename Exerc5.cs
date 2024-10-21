using System.Text.RegularExpressions;

namespace Fundamentos;

public class Exerc5
{
    public static void exerc5()
    {   
        
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();
        bool verificaPlaca = VerificaPlaca(placa);
        Console.WriteLine(verificaPlaca ? "Verdadeiro" : "Falso");
    }


    static bool VerificaPlaca(string placa)
    {
        if (placa.Length != 7) return false;

        string pattern = @"^[a-zA-Z]{3}\d{4}$";
        return Regex.IsMatch(placa, pattern);

    }
}
