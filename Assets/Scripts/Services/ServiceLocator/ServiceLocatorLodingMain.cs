using UnityEngine;

public class ServiceLocatorLodingMain : MonoBehaviour
{
    [SerializeField] private StartGames _startGames;
    [SerializeField] private CloseUI _CloseUI;
    [SerializeField] private AnimationFade _animationFade;
    
    public void Initiallize()
    {
        ServiceLocator.Initiallization();

        ServiceLocator.current.Register<StartGames>(_startGames);
        ServiceLocator.current.Register<CloseUI>(_CloseUI);
        ServiceLocator.current.Register<AnimationFade>(_animationFade);
    }

    private void Awake()
    {
        Initiallize();
    }
}
