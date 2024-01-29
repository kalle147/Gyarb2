using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySceneManager : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadSceneAsync("Map1");
    }
}
