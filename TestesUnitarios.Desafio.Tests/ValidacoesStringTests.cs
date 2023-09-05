using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var result = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        var result = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var result = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(result);
    }

    //TODO: Corrigir a anotação [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var result = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(result);
    }
}
