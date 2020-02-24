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
        if ((m_CurScore > PlayerPrefs.GetInt("HighScore")) || (!PlayerPrefs.HasKey("HighScore")))
        {
           PlayerPrefs.SetInt("HighScore", m_CurScore);
        } 
    }
    #endregion

    #region Destruction
    private void OnDisable()
    {
        IncreaseScore(0);
    }
    #endregion
}
