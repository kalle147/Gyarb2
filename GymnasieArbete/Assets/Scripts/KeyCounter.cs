using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCounter : MonoBehaviour
{

    public TextMeshProUGUI tmp;

    //public int Keys = 0;
    public static int KeyStatic;   

    int transfer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void addKey()
    {
        KeyStatic++;
    }

    // Update is called once per frame
    void Update()
    {

        //KeyStatic = Keys;
        tmp.text = KeyStatic.ToString();



    }

    public void LoadSceneAndKeepValue()
    {
        //transfer = Keys;
        //KeyCounter.Keys = Keys;
    }

}
