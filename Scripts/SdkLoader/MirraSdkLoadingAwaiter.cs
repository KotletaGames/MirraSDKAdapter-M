using Cysharp.Threading.Tasks;
using KotletaGames.ArchitectureCoreModule;

public class MirraSdkLoadingAwaiter : SdkLoadingAwaiterBase
{
    public override async UniTask InitializeAdapter()
    {
        await UniTask.CompletedTask;
    }
}
