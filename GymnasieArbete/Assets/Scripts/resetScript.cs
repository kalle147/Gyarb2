using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScript : MonoBehaviour
{

    public KeyManager KeyManager;
    public void resetGame()
    {

        KeyManager.keys = 0;
        PlayerPrefs.SetInt("keys", 0);
        PlayerPrefs.SetInt("HamadaKey", 0);
        PlayerPrefs.SetInt("HelenKey", 0);
        PlayerPrefs.SetInt("MazeKey", 0);
        PlayerPrefs.SetFloat("timer", 0);
        PlayerPrefs.Save();


        Debug.Log("Total keys: "+ PlayerPrefs.GetInt("keys"));
        Debug.Log("Hamada key: " + PlayerPrefs.GetInt("HamadaKey"));
        Debug.Log("Helen key: " + PlayerPrefs.GetInt("HelenKey"));
        Debug.Log("Maze key: " + PlayerPrefs.GetInt("MazeKey"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
