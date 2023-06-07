using Xunit.Abstractions;

namespace RomanNumbers.Test;

public class RomanNumberTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public RomanNumberTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Theory(DisplayName = "ETANT DONNE le chiffre <nombreUnités> " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens <nombreUnités> fois I")]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void TestUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var résultatAttendu = new string(Enumerable.Repeat('I', (int)nombreUnités).ToArray());
        Assert.Equal(résultatAttendu, nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 4 " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens IV")]
    public void TestQuatre()
    {
        const uint chiffreArabe = 4;
        
        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);
        
        Assert.Equal("IV", nombreRomain);
    }

    [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 5 et 8 " +
                         "QUAND je le convertis en nombres romains " +
                         "ALORS j'obtiens V plus <(nombreUnités-5)> fois I")]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    public void TestCinqPlusUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);
        
        var suiteDeI = new string('I', (int) nombreUnités - 5);
        Assert.Equal("V" + suiteDeI, nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 9 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens IX")]
    public void TestNeuf()
    {
        const uint chiffreArabe = 9;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("IX", nombreRomain);
    }

    [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 10 et 13 " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens V plus <(nombreUnités-10)> fois I")]
    [InlineData(10)]
    [InlineData(11)]
    [InlineData(12)]
    [InlineData(13)]
    public void TestDixPlusUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var suiteDeI = new string('I', (int)nombreUnités - 10);
        _testOutputHelper.WriteLine(suiteDeI);
        Assert.Equal("X" + suiteDeI, nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 14 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens XIV")]
    public void TestQuatorze()
    {
        const uint chiffreArabe = 14;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("XIV", nombreRomain);
    }

    [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 15 et 18 " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens V plus <(nombreUnités-5)> fois I")]
    [InlineData(15)]
    [InlineData(16)]
    [InlineData(17)]
    [InlineData(18)]
    public void TestQuinzePlusUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var suiteDeI = new string('I', (int)nombreUnités - 15);
        _testOutputHelper.WriteLine(suiteDeI);
        Assert.Equal("XV" + suiteDeI, nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 19 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens XIX")]
    public void TestDixNeuf()
    {
        const uint chiffreArabe = 19;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("XIX", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 20 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens XX")]
    public void TestVingt()
    {
        const uint chiffreArabe = 20;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("XX", nombreRomain);
    }
}