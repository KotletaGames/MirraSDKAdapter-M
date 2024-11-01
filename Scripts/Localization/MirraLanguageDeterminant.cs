using KotletaGames.ArchitectureCoreModule;
using romanlee17.MirraGames;

public class MirraLanguageDeterminant : RealLanguageDeterminantBase
{
    public override LanguageType DeterminateRealLanguage()
    {
        romanlee17.MirraGames.Interfaces.LanguageType language = MirraSDK.Language.Current;
        return language switch
        {
            romanlee17.MirraGames.Interfaces.LanguageType.Russian => LanguageType.Russian,
            romanlee17.MirraGames.Interfaces.LanguageType.English => LanguageType.English,
            romanlee17.MirraGames.Interfaces.LanguageType.Turkish => LanguageType.Turkish,
            romanlee17.MirraGames.Interfaces.LanguageType.Chinese => LanguageType.Chinese,
            romanlee17.MirraGames.Interfaces.LanguageType.Japanese => LanguageType.Japanese,
            romanlee17.MirraGames.Interfaces.LanguageType.Italian => LanguageType.Italian,
            romanlee17.MirraGames.Interfaces.LanguageType.Indonesian => LanguageType.Indonesian,
            romanlee17.MirraGames.Interfaces.LanguageType.Hindi => LanguageType.Hindi,
            romanlee17.MirraGames.Interfaces.LanguageType.French => LanguageType.French,
            romanlee17.MirraGames.Interfaces.LanguageType.German => LanguageType.German,
            romanlee17.MirraGames.Interfaces.LanguageType.Portuguese => LanguageType.Portuguese,
            romanlee17.MirraGames.Interfaces.LanguageType.Spanish => LanguageType.Spanish,
            _ => LanguageType.Russian
        };
    }
}