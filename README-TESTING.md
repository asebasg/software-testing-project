# Guía de Pruebas Unitarias - Múltiples Lenguajes

## JavaScript/TypeScript (Jest)

**Archivo**: `tests/math.test.ts`
**Ejecutar**: `npm test` o `jest`

```javascript
// Importar la función a probar
import { sum } from "../utils/math";

// describe() agrupa pruebas relacionadas
describe("sum", () => {
  // it() define una prueba individual
  it("should return the sum of two numbers", () => {
    // expect() verifica el resultado esperado
    expect(sum(2, 3)).toBe(5);
  });
});
```

## Python (unittest)

**Archivo**: `tests/factorial_unittest.py`
**Ejecutar**: `python -m unittest discover -s tests`

```python
import unittest
from utils.factorial import factorial

# Heredar de unittest.TestCase
class TestFactorial(unittest.TestCase):
    # Los métodos de prueba deben empezar con 'test_'
    def test_factorial_zero(self):
        # self.assertEqual() verifica igualdad
        self.assertEqual(factorial(0), 1)
```

## Python (pytest)

**Archivo**: `tests/factorial_pytest.py`
**Ejecutar**: `pytest tests/factorial_pytest.py -v`

```python
import pytest
from utils.factorial import factorial

# Las funciones de prueba pueden tener cualquier nombre
def test_factorial_zero():
    # assert verifica la condición directamente
    assert factorial(0) == 1
```

## Java (JUnit)

**Archivo**: `tests/factorial.test.java`
**Ejecutar**: `mvn test` o desde IDE

```java
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;

public class FactorialTest {
    @Test // Anotación que indica método de prueba
    public void testFactorialZero() {
        assertEquals(1, Factorial.factorial(0));
    }
}
```

## C# (xUnit)

**Archivo**: `FactorialTests_xunit.cs`
**Ejecutar**: `dotnet test`

```csharp
using Xunit;

public class FactorialTests_xunit {
    [Fact] // Atributo para métodos de prueba
    public void TestFactorialZero() {
        Assert.Equal(1, Factorial.Calculate(0));
    }
}
```

## C# (MSTest)

**Archivo**: `FactorialTests_mstest.cs`
**Ejecutar**: `dotnet test`

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass] // Atributo para clases de prueba
public class FactorialTests_mstest {
    [TestMethod] // Atributo para métodos de prueba
    public void TestFactorialZero() {
        Assert.AreEqual(1, Factorial.Calculate(0));
    }
}
```

## Comandos de Ejecución

### Python

```bash
# unittest
python -m unittest discover -s tests

# pytest
pytest tests/ -v
```

### Java

```bash
# Con Maven
mvn test

# Compilación manual
javac -d bin utils/*.java tests/*.java
java -cp "bin;path/to/junit.jar" org.junit.runner.JUnitCore FactorialTest
```

### C#

```bash
dotnet test
```

### JavaScript/TypeScript

```bash
npm test
# o
jest
```

## Estructura AAA (Arrange-Act-Assert)

Todas las pruebas siguen el patrón:

1. **Arrange**: Preparar datos de entrada
2. **Act**: Ejecutar la función bajo prueba
3. **Assert**: Verificar el resultado
