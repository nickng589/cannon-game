using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void Awake()
    {
        return;
    }

    #region StartButton
    public void Play()
	{
        SceneManager.LoadScene("Game-Screen");
	}
    #endregion

    #region Reset HighScore
    public void Restart()
	{
        SceneManager.LoadScene("Game-Screen");
    }
    #endregion

    #region Quit Game
    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}

