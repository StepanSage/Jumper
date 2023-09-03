using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrePointMainMenu : MonoBehaviour
{
    [SerializeField] private CloseUI _closeUI;
    [SerializeField] private DetectsClicks _detectsClicks;
    [SerializeField] private AnimationFade _animationFade;

    private void Start()
    {
        _detectsClicks.Initialization(_closeUI, _animationFade);
    }
}
