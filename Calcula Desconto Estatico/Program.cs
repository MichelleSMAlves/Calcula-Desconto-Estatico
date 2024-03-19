// See https://aka.ms/new-console-template for more information

using System;

public class DescontoCalculadora
{
    // Método estático para calcular o desconto
    public static double CalcularDesconto(double precoOriginal, double percentualDesconto)
    {
        if (precoOriginal < 0 || percentualDesconto < 0 || percentualDesconto > 100)
        {
            throw new ArgumentException("O preço original e o percentual de desconto devem ser números positivos e o percentual de desconto não pode ser superior a 100.");
        }

        double desconto = (precoOriginal * percentualDesconto) / 100;
        double precoComDesconto = precoOriginal - desconto;
        return precoComDesconto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        double precoOriginal = 300.0;
        double percentualDesconto = 15.0;

        // Chamando o método estático para calcular o desconto
        double precoComDesconto = DescontoCalculadora.CalcularDesconto(precoOriginal, percentualDesconto);

        Console.WriteLine($"Preço original: R${precoOriginal}");
        Console.WriteLine($"Percentual de desconto: {percentualDesconto}%");
        Console.WriteLine($"Preço com desconto: R${precoComDesconto}");
    }
}