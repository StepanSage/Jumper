using UnityEngine;

public class DetectsClicks : MonoBehaviour
{
    private CloseUI _clouseUI;
    private AnimationFade _animationFade;

    private void Start()
    {
        _clouseUI = ServiceLocator.current.Get<CloseUI>();
        _animationFade = ServiceLocator.current.Get<AnimationFade>();
    }
    private void OnMouseDown()
    {
        _clouseUI.CloseUIAnimation();
        _animationFade.Close();
    }
}
