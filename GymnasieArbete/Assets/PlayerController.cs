using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public BossController boss;
    private List<float> spacebarTaps = new List<float>();
    public float spacebarTapsPerSecond;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RegisterSpacebarTaps();

            boss.ClickButton();
        }

        UpdateSpacebarTapsPerSecond();

        Debug.Log("Spacebar Taps Per Second: " + spacebarTapsPerSecond);
    }

    void RegisterSpacebarTaps()
    {
       
        spacebarTaps.Add(Time.timeSinceLevelLoad);
    }

    void UpdateSpacebarTapsPerSecond()
    {
        spacebarTaps.RemoveAll(tapTime => tapTime <= Time.timeSinceLevelLoad - 1);

        spacebarTapsPerSecond = spacebarTaps.Count;
    }
}
