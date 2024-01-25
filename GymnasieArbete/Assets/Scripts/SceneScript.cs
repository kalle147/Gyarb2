using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void playGame()
    {
        resetGame();
        SceneManager.LoadSceneAsync("Map1");
    }

    public void resetGame()
    {

        PlayerPrefs.SetInt("keys", 0);
        PlayerPrefs.SetInt("HamadaKey", 0);
        PlayerPrefs.SetInt("HelenKey", 0);
        PlayerPrefs.SetInt("MazeKey", 0);
        PlayerPrefs.Save();

    }


    public void quitGame()
    {
        Application.Quit();
    }


}
