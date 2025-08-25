public class Factorial {
    public static int factorial(int n) {
        if (n < 0) return -1; // Factorial no definido para numeros negativos
        if (n == 0) return 1; // Caso base: 0! = 1
        return n * factorial(n - 1);
    }
}