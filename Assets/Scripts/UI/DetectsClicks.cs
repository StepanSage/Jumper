using UnityEngine;

public class DetectsClicks : MonoBehaviour
{
    private CloseUI _clouseUI;
    private AnimationFade _animationFade;

    public void Initialization(CloseUI closeUI, AnimationFade animationFade)
    {
        _clouseUI = closeUI;
        _animationFade = animationFade;
    }
    private void OnMouseDown()
    {
        _clouseUI.CloseUIAnimation();
        _animationFade.Close();
    }
}
