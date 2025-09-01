# Guía de Pruebas Unitarias - Múltiples Lenguajes

## JavaScript/TypeScript (Jest)

**Archivo**: `tests/math.test.ts`, `tests/factorial.test.ts`  
**Ejecutar**: `npx jest`

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
**Ejecutar**: `py -m unittest tests/factorial_unittest.py -v`
**Ejectutar con error**: `py tests/factorial.test.py` (con errores intencionales)

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
**Ejecutar**: `py -m pytest tests/factorial_pytest.py -v`
**Ejectutar con error**: `py -m pytest tests/factorial.test.py -v` (con errores intencionales)

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
**Ejecutar**:

- Desde VSCode con la extensión Java instalada.
- O manualmente desde CMD (tras configurar PATH para javac y java):

```bash
javac -d bin -cp ".;path/to/junit.jar" utils/factorial.java tests/factorial.test.java
java -cp ".;bin;path/to/junit.jar" org.junit.runner.JUnitCore FactorialTest
```

## C# (xUnit y MSTest)

**Archivos**: `FactorialTests_xunit.cs`, `FactorialTests_mstest.cs`  
**Ejecutar**: `dotnet test` (requiere instalación de .NET SDK)

## Comandos de Ejecución

### Python

```bash
# unittest
py -m unittest tests/factorial_unittest.py -v

# pytest
py -m pytest tests/factorial_pytest.py -v
```

### JavaScript/TypeScript

```bash
npx jest
```

### Java

```bash
# Desde VSCode con extensión Java
# O manualmente:
javac -d bin -cp ".;path/to/junit.jar" utils/factorial.java tests/factorial.test.java
java -cp ".;bin;path/to/junit.jar" org.junit.runner.JUnitCore FactorialTest
```

### C#

```bash
dotnet test
```

## Estructura AAA (Arrange-Act-Assert)

Todas las pruebas siguen el patrón:

1. **Arrange**: Preparar datos de entrada
2. **Act**: Ejecutar la función bajo prueba
3. **Assert**: Verificar el resultado
