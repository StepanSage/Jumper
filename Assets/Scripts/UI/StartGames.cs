using UnityEngine;

public class StartGames : MonoBehaviour, IServiceLocator
{
    [SerializeField] private GameObject _startGame;

    public void StateGame(bool state)
    {
      _startGame.SetActive(state);
    }
}
