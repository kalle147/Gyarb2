using UnityEngine;
using UnityEngine.SceneManagement;
public class BossController : MonoBehaviour
{
    public PlayerController player;
    private float spacebarTapsPerSecond;
    public float defaultBossCPS = 6f;
    private float currentBossCPS;
    private float timer;

    void Start()
    {
        currentBossCPS = defaultBossCPS;
        timer = 0f;
    }

    void Update()
    {
        spacebarTapsPerSecond = player.spacebarTapsPerSecond;

        if (spacebarTapsPerSecond > 0)
        {
            timer += Time.deltaTime;

            if (timer >= 5f)
            {
                Debug.Log("Boss defeated!");
                // byt scene till death scene
                
                timer = 0f;
                
            }
        }
        else
        {
            timer = 0f;
        }
    }

    public void ClickButton()
    {
        Debug.Log("Boss CPS: " + currentBossCPS);
    }
}
