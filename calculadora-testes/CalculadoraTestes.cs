namespace calculadora_testes;
using projeto_calculadora.Services;

public class CalculadoraTestes
{
    private CalculadoraOperations _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraOperations();
    }
    
    [Fact]
    public void Somar5e5Retornar10()
    {
        int n1 = 5;
        int n2 = 5;

        int result = _calc.addition(n1, n2);
        
        Assert.Equal(10, result);
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 10, 15)]
    public void TesteSomar(int n1, int n2, int result)
    {

        int resultCalc = _calc.addition(n1, n2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrair(int n1, int n2, int result)
    {

        int resultCalc = _calc.subtraction(n1, n2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(10, 5, 50)]
    public void TesteMultiplicar(int n1, int n2, int result)
    {

        int resultCalc = _calc.multiplication(n1, n2);
        
        Assert.Equal(result, resultCalc);
    }
    
    [Theory]
    [InlineData(50, 2, 25)]
    [InlineData(100, 2, 50)]
    public void TesteDividir(int n1, int n2, int result)
    {

        int resultCalc = _calc.division(n1, n2);
        
        Assert.Equal(result, resultCalc);
    }
}