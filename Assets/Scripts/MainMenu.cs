using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    #region StartButton
    private void Play()
	{
        SceneManageer.LoadScene("Cannon-Game");
	}
    #endregion

    #region Reset HighScore
    private void Reset()
	{

	}
    #endregion
}

