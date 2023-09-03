using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private Animator[] _closeAnimation;
    [SerializeField] private string[] _nameAnimationClose;


    public void CloseUIAnimation()
    {
        for (int i = 0; i < _closeAnimation.Length; i++)
        {
            if (_nameAnimationClose[i] == "-")
            {
                _closeAnimation[i].enabled = true;
            }
            else
            {
                _closeAnimation[i].Play(_nameAnimationClose[i]);
            }
            
        }
    }
}
