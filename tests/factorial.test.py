import unittest
from utils.factorial import factorial

class TestFactorial(unittest.TestCase):
    def test_factorial_zero(self):
        self.assertEqual(factorial(0), 1) # El factorial de 0 es 1

    def test_factorial_five(self):
        self.assertEqual(factorial(5), 120) # El factorial de 5 es 120 (5 x 4 x 3 x 2 x 1)

    def test_factorial_negative(self):
        self.assertEqual(factorial(-1), -1) # El factorial de un numero negativo no esta definido, retorna -1

if __name__ == '__main__':
    unittest.main()
