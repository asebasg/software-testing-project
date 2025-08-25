def factorial(n):
    """
    Calcula el factorial de un número
    Args:
        n (int): Número para calcular el factorial
    Returns:
        int: Factorial del número, o -1 si es negativo
    """
    if n < 0:
        return -1  # Factorial no definido para números negativos
    if n == 0:
        return 1  # Caso base: 0! = 1
    return n * factorial(n - 1)
