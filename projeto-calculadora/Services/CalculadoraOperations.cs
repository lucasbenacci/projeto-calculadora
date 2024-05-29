namespace projeto_calculadora.Services;

public class CalculadoraOperations
{
    public int addition(int n1, int n2)
    {
        return n1 + n2;
    }
    
    public int subtraction(int n1, int n2)
    {
        return n1 - n2;
    }
    
    public int multiplication(int n1, int n2)
    {
        return n1 * n2;
    }
    
    public int division(int n1, int n2)
    {
        return n1 / n2;
    }

    public List<string> historico()
    {
        return new List<string>();
    }
}