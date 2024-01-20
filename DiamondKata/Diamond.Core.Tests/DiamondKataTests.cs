using FluentAssertions;

namespace Diamond.Core.Tests;

public class DiamondKataTests
{
    [Fact]
    public void GivenServiceInstance_WhenInputIsA_ThenResultShouldBeSingleLine()
    {
        // Arrange

        var sut = new DiamondKata();

        // Act

        var kata = sut.GetDiamondKata("A");
        var lines = GetLines(kata);

        // Assert

        _ = lines.Should().ContainSingle();
        _ = lines[0].Should().Be("A");
    }

    [Fact]
    public void GivenServiceInstance_WhenInputIsB_ThenResultShouldBe3Lines()
    {
        // Arrange

        var sut = new DiamondKata();

        // Act

        var kata = sut.GetDiamondKata("B");
        var lines = GetLines(kata);

        // Assert

        _ = lines.Should().HaveCount(3);
        _ = lines[0].Should().Be(" A ");
        _ = lines[1].Should().Be("B B");
        _ = lines[2].Should().Be(" A ");
    }

    [Fact]
    public void GivenServiceInstance_WhenInputIsC_ThenResultShouldBe5Lines()
    {
        // Arrange

        var sut = new DiamondKata();

        // Act

        var kata = sut.GetDiamondKata("C");
        var lines = GetLines(kata);

        // Assert

        _ = lines.Should().HaveCount(5);
        _ = lines[0].Should().Be("  A  ");
        _ = lines[1].Should().Be(" B B ");
        _ = lines[2].Should().Be("C   C");
        _ = lines[3].Should().Be(" B B ");
        _ = lines[4].Should().Be("  A  ");
    }

    [Fact]
    public void GivenServiceInstance_WhenInputIsZ_ThenResultShouldBe51Lines()
    {
        // Arrange

        var sut = new DiamondKata();

        // Act

        var kata = sut.GetDiamondKata("Z");
        var lines = GetLines(kata);

        // Assert

        _ = lines.Should().HaveCount(51);
        _ = lines[00].Should().Be("                         A                         ");
        _ = lines[01].Should().Be("                        B B                        ");
        _ = lines[02].Should().Be("                       C   C                       ");
        _ = lines[03].Should().Be("                      D     D                      ");
        _ = lines[04].Should().Be("                     E       E                     ");
        _ = lines[05].Should().Be("                    F         F                    ");
        _ = lines[06].Should().Be("                   G           G                   ");
        _ = lines[07].Should().Be("                  H             H                  ");
        _ = lines[08].Should().Be("                 I               I                 ");
        _ = lines[09].Should().Be("                J                 J                ");
        _ = lines[10].Should().Be("               K                   K               ");
        _ = lines[11].Should().Be("              L                     L              ");
        _ = lines[12].Should().Be("             M                       M             ");
        _ = lines[13].Should().Be("            N                         N            ");
        _ = lines[14].Should().Be("           O                           O           ");
        _ = lines[15].Should().Be("          P                             P          ");
        _ = lines[16].Should().Be("         Q                               Q         ");
        _ = lines[17].Should().Be("        R                                 R        ");
        _ = lines[18].Should().Be("       S                                   S       ");
        _ = lines[19].Should().Be("      T                                     T      ");
        _ = lines[20].Should().Be("     U                                       U     ");
        _ = lines[21].Should().Be("    V                                         V    ");
        _ = lines[22].Should().Be("   W                                           W   ");
        _ = lines[23].Should().Be("  X                                             X  ");
        _ = lines[24].Should().Be(" Y                                               Y ");
        _ = lines[25].Should().Be("Z                                                 Z");
        _ = lines[26].Should().Be(" Y                                               Y ");
        _ = lines[27].Should().Be("  X                                             X  ");
        _ = lines[28].Should().Be("   W                                           W   ");
        _ = lines[29].Should().Be("    V                                         V    ");
        _ = lines[30].Should().Be("     U                                       U     ");
        _ = lines[31].Should().Be("      T                                     T      ");
        _ = lines[32].Should().Be("       S                                   S       ");
        _ = lines[33].Should().Be("        R                                 R        ");
        _ = lines[34].Should().Be("         Q                               Q         ");
        _ = lines[35].Should().Be("          P                             P          ");
        _ = lines[36].Should().Be("           O                           O           ");
        _ = lines[37].Should().Be("            N                         N            ");
        _ = lines[38].Should().Be("             M                       M             ");
        _ = lines[39].Should().Be("              L                     L              ");
        _ = lines[40].Should().Be("               K                   K               ");
        _ = lines[41].Should().Be("                J                 J                ");
        _ = lines[42].Should().Be("                 I               I                 ");
        _ = lines[43].Should().Be("                  H             H                  ");
        _ = lines[44].Should().Be("                   G           G                   ");
        _ = lines[45].Should().Be("                    F         F                    ");
        _ = lines[46].Should().Be("                     E       E                     ");
        _ = lines[47].Should().Be("                      D     D                      ");
        _ = lines[48].Should().Be("                       C   C                       ");
        _ = lines[49].Should().Be("                        B B                        ");
        _ = lines[50].Should().Be("                         A                         ");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("0")]
    [InlineData("12")]
    [InlineData("A12")]
    [InlineData("Welcome")]
    [InlineData("a")]
    [InlineData("z")]
    public void GivenServiceInstance_WhenInvalidInputPassed_ThenResultShouldBeEmptyString(string input)
    {
        // Arrange

        var sut = new DiamondKata();

        // Act

        var actual = sut.GetDiamondKata(input);

        // Assert

        _ = actual.Should().BeEmpty();
    }

    private static string[] GetLines(string kata)
    {
        if (string.IsNullOrWhiteSpace(kata))
        {
            return [];
        }

        return kata.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
    }
}