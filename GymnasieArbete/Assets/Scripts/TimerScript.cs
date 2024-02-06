using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("timer", (PlayerPrefs.GetFloat("timer") + Time.deltaTime));

        int minutes = Mathf.FloorToInt(PlayerPrefs.GetFloat("timer") / 60);
        int seconds = Mathf.FloorToInt(PlayerPrefs.GetFloat("timer") % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
