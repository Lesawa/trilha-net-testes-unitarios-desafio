using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //*OK IMPLEMENTADO*

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        // Assert
        Assert.False(resultado);
    }

    //*OK IMPLEMENTADO*
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //*OK* IMPLEMENTADO)

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //*OK IMPLEMENTADO*
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaRetornar = 9;
        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        //*OK IMPLEMENTADO*
        Assert.Equal(numeroParaRetornar, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //*OK IMPLEMENTADO*

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaRetornar = -8;
        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //*OK IMPLEMENTADO*
        Assert.Equal(numeroParaRetornar, resultado);
    }
}
