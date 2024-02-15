using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BossController : MonoBehaviour
{
    public PlayerController player;
    private float spacebarTapsPerSecond;
    public float defaultBossCPS = 6f;
    private float currentBossCPS;
    private float timer;

    private int bossClicks = 0; 

    public TextMeshProUGUI playerCPS;
    public TextMeshProUGUI bossCPS;

    void Start()
    {
        currentBossCPS = defaultBossCPS;
        timer = 0f;
    }

    void Update()
    {

        timer += Time.deltaTime;
        spacebarTapsPerSecond = player.spacebarTapsPerSecond;

        //  boss cps över tid
        if (timer > 1f) bossClicks = 0;
        if (timer > 7f) bossClicks = 1;
        if (timer > 9f) bossClicks = 2;
        if (timer > 10f) bossClicks = 3;
        if (timer > 11f) bossClicks = 4;
        if (timer > 12f) bossClicks = 5;
        if (timer > 14f) bossClicks = 5;


        //displayar boss o player cps på UI
        playerCPS.text = "Your cps: " + spacebarTapsPerSecond.ToString();
        bossCPS.text = "Boss cps: " + bossClicks.ToString();

        if(spacebarTapsPerSecond < bossClicks) // om bossen e snabbare torskar du
        {
            SceneManager.LoadScene(7); // loose
        }

        if (timer >= 15f) // om du klarat dig i 15 sek vinner du
        {
            Debug.Log("Boss defeated!");
            SceneManager.LoadScene(8); // win
        }



        /*
        // man vinner om man har 6+ i cps när det gått 8 sek
        

        if (spacebarTapsPerSecond > 6) // om 6+ cps
        {
            timer += Time.deltaTime;

            if (timer >= 8f) // om det gått 8 sek
            {
                Debug.Log("Boss defeated!");
                // byt scene till win scene
                
                timer = 0f;

                SceneManager.LoadScene(8); // win
            }
        }
        else // om under 6 cps
        {
            timer += Time.deltaTime;

            if(timer >= 8f) // om det gått 8 sek
            {
                timer = 0f;
                SceneManager.LoadScene(7); // loose
            }
        }
        */
    }

    public void ClickButton()
    {
        Debug.Log("Boss CPS: " + currentBossCPS);
    }
}
