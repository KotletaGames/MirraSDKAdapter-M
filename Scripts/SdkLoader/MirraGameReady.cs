using KotletaGames.ArchitectureCoreModule;
using UnityEngine;
using Zenject;

public class MirraGameReady : MonoBehaviour
{
    [Inject] private IAnalyticsGameStats _analyticsGame;

    private void Start()
    {
        _analyticsGame.GameIsReady();
        _analyticsGame.GameplayStart();
    }
}