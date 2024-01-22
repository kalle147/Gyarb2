using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScript : MonoBehaviour
{

    public KeyManager KeyManager;
    public void resetGame()
    {

        KeyManager.keys = 0;
       
        PlayerPrefs.SetInt("HamadaKey", 0);
        PlayerPrefs.SetInt("HelenKey", 0);
        PlayerPrefs.SetInt("MazeKey", 0);
        PlayerPrefs.Save();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
