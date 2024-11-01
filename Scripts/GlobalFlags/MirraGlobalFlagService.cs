using KotletaGames.ArchitectureCoreModule;
using romanlee17.MirraGames;

public class MirraGlobalFlagService : GlobalFlagServiceBase
{
    public override bool GetBoolean(string key, bool defaultValue = false)
    {
        return MirraSDK.Flags.GetBool(key, defaultValue);
    }

    public override int GetInteger(string key, int defaultValue = 0)
    {
        return MirraSDK.Flags.GetInt(key, defaultValue);
    }

    public override float GetSingle(string key, float defaultValue = 0)
    {
        return MirraSDK.Flags.GetFloat(key, defaultValue);
    }

    public override string GetString(string key, string defaultValue = "")
    {
        return MirraSDK.Flags.GetString(key, defaultValue);
    }
}
