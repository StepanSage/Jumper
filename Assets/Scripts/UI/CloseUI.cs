using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private Animator[] _closeAnimation;
    [SerializeField] private string[] _nameAnimationClose;
    [SerializeField] private float _speedAmimation;

    private StartGames _startGames;
    private float i;

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
                StartCoroutine("SpeedAnimaton");
            }
            else
            {
                _closeAnimation[i].Play(_nameAnimationClose[i]);
            }
            
        }
    }

    IEnumerator SpeedAnimaton()
    {
        yield return new WaitForSeconds(_speedAmimation);
        _startGames.StateGame(true);
    }
}
