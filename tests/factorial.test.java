import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;

public class FactorialTest {
    @Test
    public void testFactorialZero() {
        assertEquals(1, Factorial.factorial(0));
    }

    @Test
    public void testFactorialFive() {
        assertEquals(120, Factorial.factorial(5));
    }

    @Test
    public void testFactorialNegative() {
        assertEquals(-1, Factorial.factorial(-1));
    }
}
