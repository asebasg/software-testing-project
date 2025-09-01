import pytest
import sys
sys.path.append('.')
from utils.factorial import factorial

def test_factorial_zero():
    """Prueba que el factorial de 0 es 1 usando pytest"""
    assert factorial(0) == 1

def test_factorial_five():
    """Prueba que el factorial de 5 es 120 usando pytest"""
    assert factorial(5) == 120

def test_factorial_negative():
    """Prueba que el factorial de un número negativo devuelve -1 usando pytest"""
    assert factorial(-1) == -1

# Ejecutar con: pytest tests/factorial_pytest.py -v
# El flag -v muestra resultados detallados
