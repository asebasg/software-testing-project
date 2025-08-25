using Xunit;
using System;

public class FactorialTests_xunit
{
    [Fact] // Atributo que indica que este método es una prueba unitaria
    public void TestFactorialZero()
    {
        // Arrange: Preparar los datos de prueba
        int input = 0;
        int expected = 1;
        
        // Act: Ejecutar la función bajo prueba
        int result = Factorial.Calculate(input);
        
        // Assert: Verificar el resultado
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestFactorialFive()
    {
        // Prueba que el factorial de 5 es 120
        Assert.Equal(120, Factorial.Calculate(5));
    }

    [Fact]
    public void TestFactorialNegative()
    {
        // Prueba que números negativos devuelven -1
        Assert.Equal(-1, Factorial.Calculate(-1));
    }
}

// Ejecutar con: dotnet test
// Requiere archivo .csproj con referencia a xUnit
