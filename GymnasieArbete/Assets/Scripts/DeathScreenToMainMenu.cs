using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenToMainMenu : MonoBehaviour
{
    public void changeSceneToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
