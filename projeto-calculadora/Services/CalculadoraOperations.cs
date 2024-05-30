namespace projeto_calculadora.Services;

public class CalculadoraOperations
{
    private List<string> listahistorico = new List<string>();

    public int addition(int n1, int n2)
    {
        int res = n1 + n2;
        listahistorico.Insert(0, "Res: " +res);
        return res;
    }
    
    public int subtraction(int n1, int n2)
    {
        int res = n1 - n2;
        listahistorico.Insert(0, "Res: " +res);
        return res;
    }
    
    public int multiplication(int n1, int n2)
    {
        int res = n1 * n2;
        listahistorico.Insert(0, "Res: " +res);
        return res;
    }
    
    public int division(int n1, int n2)
    {
        int res = n1 / n2;
        listahistorico.Insert(0, "Res: " +res);
        return res;
    }

    public List<string> historico()
    {
        listahistorico.RemoveRange(3, listahistorico.Count - 3);
        return listahistorico;
    }
}