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
        if (PlayerPrefs.HasKey("HighScore"))
        {
            m_HighScore.text = m_Default.Replace("$S", PlayerPrefs.GetInt("HighScore").ToString());
        } else
        {
            PlayerPrefs.SetInt("HighScore", 0);
            m_HighScore.text = m_Default.Replace("$S", "0");
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        UpdateHS();
    }
    #endregion


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

