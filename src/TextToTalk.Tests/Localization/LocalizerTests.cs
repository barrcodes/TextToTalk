using System.Globalization;
using TextToTalk.Localization;
using Xunit;

namespace TextToTalk.Tests.Localization;

public class LocalizerTests
{
    [Theory]
    [InlineData("en")]
    [InlineData("fr")]
    [InlineData("de")]
    [InlineData("ja")]
    public void UsesCultureForUiLanguage(string language)
    {
        var localizer = new Localizer(language);

        Assert.Equal(CultureInfo.GetCultureInfo(language), localizer.Culture);
    }

    [Fact]
    public void UsesEnglishResourcesWhenTranslationIsUnavailable()
    {
        var localizer = new Localizer("pt");

        Assert.Equal("TextToTalk Configuration", localizer.Get("ConfigurationTitle"));
    }

    [Fact]
    public void UsesEnumNameForLocalizedChatTypeResource()
    {
        var localizer = new Localizer("it");

        Assert.Equal("Dire", localizer.Get("ChatTypeSay"));
    }

}
