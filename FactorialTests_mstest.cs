using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass] // Atributo que indica que esta clase contiene pruebas
public class FactorialTests_mstest
{
    [TestMethod] // Atributo que indica que este método es una prueba
    public void TestFactorialZero()
    {
        // Arrange: Preparar los datos de prueba
        int input = 0;
        int expected = 1;
        
        // Act: Ejecutar la función bajo prueba
        int result = Factorial.Calculate(input);
        
        // Assert: Verificar el resultado
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestFactorialFive()
    {
        // Prueba que el factorial de 5 es 120
        Assert.AreEqual(120, Factorial.Calculate(5));
    }

    [TestMethod]
    public void TestFactorialNegative()
    {
        // Prueba que números negativos devuelven -1
        Assert.AreEqual(-1, Factorial.Calculate(-1));
    }
}

// Ejecutar con: dotnet test
// Requiere archivo .csproj con referencia a MSTest
