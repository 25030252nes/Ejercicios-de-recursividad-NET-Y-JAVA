using System;
using Recursividad.Logica;

Console.WriteLine("Metodos recursivos");
Console.WriteLine("\n\n calcular factorial de 5");
Recursividades oRecursividades = new Recursividades();
int resultado = oRecursividades.CalcularFactorial(5);
Console.WriteLine("Factorial de 5 es:" + resultado);

Console.WriteLine("\n--- 1. Contar Vocales ---");
string texto = "Hola Mundo";
int cantidadVocales = oRecursividades.vocales(texto);
Console.WriteLine($"La cantidad de vocales en '{texto}' es: {cantidadVocales}");

Console.WriteLine("\n--- 2. Suma de dígitos en secuencia ---");
int[] secuencia = { 123, 99, 456, 801, 23 };
int mayorNumero = 0;
int mayorSuma = -1;

foreach (int num in secuencia)
{
    int sumaActual = oRecursividades.SumaDigitos(num);
    Console.WriteLine($"El número {num} tiene una suma de dígitos de: {sumaActual}");

    if (sumaActual > mayorSuma)
    {
        mayorSuma = sumaActual;
        mayorNumero = num;
    }
}
Console.WriteLine($"El número con la mayor suma de dígitos es: {mayorNumero} (Suma: {mayorSuma})");

Console.WriteLine("\n--- 3. Suma de primeros n números ---");
int n = 5;
int sumaTotal = oRecursividades.SumarNumeros(n);
Console.WriteLine($"La suma de los primeros {n} números enteros es: {sumaTotal}");