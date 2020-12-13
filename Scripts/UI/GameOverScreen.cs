using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _gameOverScreen;

    private void OnEnable()
    {
        _player.IsTimeRunOut += EnableScreen;
    }

    private void OnDisable()
    {
        _player.IsTimeRunOut -= EnableScreen;
    }

    private void EnableScreen()
    {
        _gameOverScreen.SetActive(true);        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);        
    }

    public void ExitGame() 
    {
        Application.Quit();
    }

}
