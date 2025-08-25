using System;

public class Factorial
{
    /// <summary>
    /// Calcula el factorial de un número
    /// </summary>
    /// <param name="n">Número para calcular el factorial</param>
    /// <returns>Factorial del número, o -1 si es negativo</returns>
    public static int Calculate(int n)
    {
        if (n < 0) return -1; // Factorial no definido para números negativos
        if (n == 0) return 1; // Caso base: 0! = 1
        return n * Calculate(n - 1);
    }
}
