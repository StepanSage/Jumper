using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private Animator[] _closeAnimation;
    [SerializeField] private string[] _nameAnimationClose;

    private StartGames _startGames;

    public void Initialization(StartGames startGames)
    {
        _startGames = startGames;
    }

    public void CloseUIAnimation()
    {
        for (int i = 0; i < _closeAnimation.Length; i++)
        {
            if (_nameAnimationClose[i] == "-")
            {
                _closeAnimation[i].enabled = true;
            }
            else if (_nameAnimationClose[i] == "startGames")
            {
                _startGames.StateGame(true);
            }
            else
            {
                _closeAnimation[i].Play(_nameAnimationClose[i]);
            }
            
        }
    }
}
