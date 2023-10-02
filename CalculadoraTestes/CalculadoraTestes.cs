using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    /*
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {

    // Arrange -> preparar
    int num1 = 5;
    int num2 = 10;
    
    // Act -> fazer
    int resultado = _calc.somar(num1, num2);

    // Assert -> validar
    Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Given
        int numero = 4;
        // When
        bool resultado = _calc.EhPar(numero);
        // Then
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        // Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }


    [Theory]
    [InlineData(new int[] {2, 4, 6, 8})]
    
    public void DeveVerificarSeOsNumerosDoArraySaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
    */


    public CalculadoraImp construirClasse()
    {
        string data = "01/10/2023";
        CalculadoraImp calc = new CalculadoraImp("01/10/2023"); 
        return calc;
    }

    [Fact]
    public void Test1()
    {
        CalculadoraImp calc = construirClasse();

        int resultado = calc.somar(1, 2);

        Assert.Equal(3, resultado);
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (3, 2, 1)]
    [InlineData (9, 5, 4)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.mutiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraImp calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}