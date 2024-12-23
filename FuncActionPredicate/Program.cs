using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Exemplo de uso de Func<T, TResult>
        Func<int, int, int> somar = (a, b) => a + b;
        int resultadoSoma = somar(5, 3);
        Console.WriteLine($"Resultado da soma: {resultadoSoma}");

        // Exemplo de uso de Action<T>
        Action<string> imprimirMensagem = mensagem => Console.WriteLine($"Mensagem: {mensagem}");
        imprimirMensagem("Olá, Mundo!");

        // Exemplo de uso de Predicate<T>
        Predicate<int> ePar = numero => numero % 2 == 0;
        bool resultadoPar = ePar(4);
        Console.WriteLine($"O número 4 é par? {resultadoPar}");

        // Mais exemplos de uso de Func<T, TResult>, Action<T> e Predicate<T> juntos
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Usando Func para transformar uma lista de números
        Func<int, int> duplicar = numero => numero * 2;
        List<int> numerosDuplicados = numeros.ConvertAll(new Converter<int, int>(duplicar));
        Console.WriteLine("Números duplicados:");
        numerosDuplicados.ForEach(n => Console.WriteLine(n));

        // Usando Action para executar uma ação em cada item da lista
        Action<int> imprimirNumero = numero => Console.WriteLine($"Número: {numero}");
        Console.WriteLine("Imprimindo números originais:");
        numeros.ForEach(imprimirNumero);

        // Usando Predicate para filtrar a lista
        Predicate<int> maiorQueTres = numero => numero > 3;
        List<int> numerosMaioresQueTres = numeros.FindAll(maiorQueTres);
        Console.WriteLine("Números maiores que três:");
        numerosMaioresQueTres.ForEach(n => Console.WriteLine(n));
    }
}
