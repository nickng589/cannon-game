using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score singleton;
    private int m_CurScore;

    #region Initialization
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        } else if (singleton != this)
        {
            Destroy(gameObject);
        }
        m_CurScore = 0;
    }
    #endregion

    #region Scoring
    public void IncreaseScore(int amount)
    {
        m_CurScore += amount;
        Debug.Log("we in boys");
        Debug.Log(m_CurScore);
    }

    private void UpdateHighScore()
    {
        if ((m_CurScore > PlayerPrefs.GetInt("HS")) || (!PlayerPrefs.HasKey("HS")))
        {
            PlayerPrefs.SetInt("HS", m_CurScore);

        }
        Debug.Log("player prefs val "+PlayerPrefs.GetInt("HS"));
    }
    #endregion

    #region Destruction
    private void OnDisable()
    {
        UpdateHighScore();
    }
    #endregion
}
