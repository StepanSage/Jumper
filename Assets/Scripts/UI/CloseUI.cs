using System.Collections;
using UnityEngine;

public class CloseUI : MonoBehaviour, IServiceLocator
{
    [SerializeField] private Animator[] _closeAnimation;
    [SerializeField] private string[] _nameAnimationClose;
    [SerializeField] private float _speedAmimation;

    private StartGames _startGames;
    private float i;

    private void Start()
    {
        _startGames = ServiceLocator.current.Get<StartGames>();
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
