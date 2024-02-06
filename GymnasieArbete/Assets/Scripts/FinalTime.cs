using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalTime : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    void Start()
    {
        int minutes = Mathf.FloorToInt(PlayerPrefs.GetFloat("timer") / 60);
        int seconds = Mathf.FloorToInt(PlayerPrefs.GetFloat("timer") % 60);

        timerText.text = "Your time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
