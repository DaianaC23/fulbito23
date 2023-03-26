using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{

    public GameObject optionsPanel, mainmenuPanel, gameOverPanel, scorePanel, game;
    

    public void GameStart()
    {
        Time.timeScale = 1;
        mainmenuPanel.SetActive(false);
        game.SetActive(true);        
    }
    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
        game.SetActive(false);

    }

    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
        game.SetActive(true);

    }

    public void ScoreOptions()
    {
        scorePanel.SetActive(true);
        game.SetActive(false);

    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        mainmenuPanel.SetActive(true);
        game.SetActive(false);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
