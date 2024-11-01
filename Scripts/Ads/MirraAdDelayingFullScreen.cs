using KotletaGames.ArchitectureCoreModule;
using romanlee17.MirraGames;

public class MirraAdDelayingFullScreen : AdDelayingFullScreenBase
{
    private readonly VolumeChanger _volumeChanger;

    public MirraAdDelayingFullScreen(IAdDelayingFullScreen adDelayingFullScreen, IInputActivity inputActivity, AdFullScreenPanel adFullScreenPanel, VolumeChanger volumeChanger) : base(adDelayingFullScreen, inputActivity, adFullScreenPanel)
    {
        _volumeChanger = volumeChanger;
    }

    protected override bool IsInterstitialVisible => MirraSDK.Ads.IsInterstitialVisible;

    protected override void DisableParametres()
    {
        _volumeChanger.MemorizeVolume();
        _volumeChanger.ReduceVolumeWithoutSave();
    }

    protected override void EnableParametres()
    {
        _volumeChanger.RecoverVolume();
    }

    protected override void InvokeInterstitial()
    {
        MirraSDK.Ads.InvokeInterstitial();
    }
}