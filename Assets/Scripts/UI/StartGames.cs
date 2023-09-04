using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGames : MonoBehaviour
{
    [SerializeField] private GameObject _startGame;
    public void Initialization()
    {
       
    }

    public void StateGame(bool state)
    {
      _startGame.SetActive(state);
    }




}
