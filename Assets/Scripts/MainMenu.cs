using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    private string m_Default;

    [SerializeField]
    private Text m_HighScore;
    private Text m_CurrentScore;

    public void Awake()
    {
        m_Default = m_HighScore.text;
    }

    private void Start()
    {
        UpdateHS();
    }

    #region High Score
    private void UpdateHS()
    {
        Debug.Log("updating");
        if (PlayerPrefs.HasKey("HS"))
        {
            Debug.Log("we have value");
            m_HighScore.text = m_Default.Replace("$S", PlayerPrefs.GetInt("HS").ToString());
        } else
        {
            PlayerPrefs.SetInt("HS", 0);
            m_HighScore.text = m_Default.Replace("$S", "0");
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("HS", 0);
        UpdateHS();
    }
    #endregion


    #region StartButton
    public void Play()
	{
        SceneManager.LoadScene("Cannon-Game");
	}
    #endregion

    #region Reset HighScore
    public void Restart()
	{
        SceneManager.LoadScene("Cannon-Game");
    }
    #endregion

    #region Quit Game
    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    #region Load Main Menu
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start-Screen");
    }
    #endregion
}

