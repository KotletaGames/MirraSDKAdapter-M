using romanlee17.MirraGames;

namespace KotletaGames.ArchitectureCoreModule
{
    public class MirraPlatformTypeProvider : PlatformTypeProviderBase
    {
        /*
        public override PlatformType PlatformType => MirraSDK.Device.IsMobile switch
        {
            true => PlatformType.Mobile,
            false => PlatformType.Desktop,
        };
        */

        public override PlatformType PlatformType
        {
            get
            {
                if (MirraSDK.Device.IsMobile == true)
                {
                    return PlatformType.Mobile;
                }
                else
                {
                    return PlatformType.Desktop;
                }
            }
        }
    }
}