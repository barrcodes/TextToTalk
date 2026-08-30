using System.Globalization;
using Dalamud.Game;
using TextToTalk.Localization;
using Xunit;

namespace TextToTalk.Tests.Localization;

public class LocalizerTests
{
    [Theory]
    [InlineData(ClientLanguage.English, "en")]
    [InlineData(ClientLanguage.French, "fr")]
    [InlineData(ClientLanguage.German, "de")]
    [InlineData(ClientLanguage.Japanese, "ja")]
    public void UsesCultureForClientLanguage(ClientLanguage language, string expectedCulture)
    {
        var localizer = new Localizer(language);

        Assert.Equal(CultureInfo.GetCultureInfo(expectedCulture), localizer.Culture);
    }

    [Fact]
    public void UsesEnglishResourcesWhenTranslationIsUnavailable()
    {
        var localizer = new Localizer(ClientLanguage.French);

        Assert.Equal("Volume", localizer.Get("Volume"));
    }

    [Fact]
    public void UsesClientLanguageWhenDalamudUsesSystemLanguage()
    {
        var language = Localizer.ResolveLanguage(ClientLanguage.Japanese, "en", CultureInfo.GetCultureInfo("en-US"));

        Assert.Equal(ClientLanguage.Japanese, language);
    }

    [Theory]
    [InlineData("ja", ClientLanguage.Japanese)]
    [InlineData("de", ClientLanguage.German)]
    [InlineData("fr", ClientLanguage.French)]
    [InlineData("es", ClientLanguage.English)]
    public void UsesDalamudLanguageWhenItOverridesSystemLanguage(string uiLanguage, ClientLanguage expectedLanguage)
    {
        var language = Localizer.ResolveLanguage(ClientLanguage.Japanese, uiLanguage, CultureInfo.GetCultureInfo("en-US"));

        Assert.Equal(expectedLanguage, language);
    }
}
