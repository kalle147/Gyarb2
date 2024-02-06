using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public TextMeshProUGUI keyCount;

    public int keys;


    // Start is called before the first frame update
    void Start()
    {
        keys = PlayerPrefs.GetInt("keys", 0);
        Debug.Log("Keys from last scene: " + keys);
    }

    private void Update()
    {
        keyCount.text = keys.ToString();
        PlayerPrefs.SetInt("keys", keys);
    }

    public void addKey()
    {
        Debug.Log("AddKey function");
        Debug.Log("test, nycklar innan"+ keys);

        if(keys <= 2) keys++;

        Debug.Log("test, nycklar efter" + keys);
    }
}
