using System;
using System.Globalization;
using Dalamud.Game;
using Dalamud.Utility;
using TextToTalk.Resources;

namespace TextToTalk.Localization;

public sealed class Localizer
{
    public Localizer(ClientLanguage language)
    {
        SetLanguage(language);
    }

    public CultureInfo Culture { get; private set; } = CultureInfo.InvariantCulture;
    public ClientLanguage GameDataLanguage { get; private set; }

    public static ClientLanguage ResolveLanguage(ClientLanguage clientLanguage, string uiLanguage,
        CultureInfo systemUiCulture)
    {
        if (string.Equals(uiLanguage, systemUiCulture.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase))
        {
            return clientLanguage;
        }

        return uiLanguage.ToLowerInvariant() switch
        {
            "ja" => ClientLanguage.Japanese,
            "de" => ClientLanguage.German,
            "fr" => ClientLanguage.French,
            _ => ClientLanguage.English,
        };
    }

    public void SetUiLanguage(ClientLanguage clientLanguage, string uiLanguage, CultureInfo systemUiCulture) =>
        SetLanguage(ResolveLanguage(clientLanguage, uiLanguage, systemUiCulture));

    private void SetLanguage(ClientLanguage language)
    {
        GameDataLanguage = language;
        Culture = CultureInfo.GetCultureInfo(language.ToCode());
        Strings.Culture = Culture;
    }

    public string Get(string key) =>
        Strings.ResourceManager.GetString(key, Culture) ?? $"[{key}]";

    public string Format(string template, params object?[] args) =>
        string.Format(Culture, template, args);
}
