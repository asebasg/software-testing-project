import unittest
from utils.factorial import factorial

class TestFactorial(unittest.TestCase):
    def test_factorial_zero(self):
        """Prueba que el factorial de 0 es 1"""
        self.assertEqual(factorial(0), 1)

    def test_factorial_five(self):
        """Prueba que el factorial de 5 es 120"""
        self.assertEqual(factorial(5), 120)

    def test_factorial_negative(self):
        """Prueba que el factorial de un número negativo devuelve -1"""
        self.assertEqual(factorial(-1), -1)

if __name__ == '__main__':
    unittest.main()
