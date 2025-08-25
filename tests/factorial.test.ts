import { factorial } from "../utils/factorial";

describe('factorial', () => {
    it('should return 1 for 0', () => {
        expect(factorial(0)).toBe(1); // Espera que el resultado sea 0 al momento de operar 1 x 0
    });

    it('should return 120 for 5', () => {
        expect(factorial(5)).toBe(120); // Espera que el resultado sea 120 al momento de operar 5 x 4 x 3 x 2 x 1
    });

    it('should return -1 for negative numbers', () => {
        expect(factorial(-1)).toBe(-1); // Espera que el resultado sea -1 al momento de operar con numeros negativos
    });
});