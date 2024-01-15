using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour
{
    public GameObject EtoInteract;
    public HamadaUIScript hamadaUIScript;
    public GameObject carryRobot;



    bool IsInRange;
    bool pratat;
    public bool PickedUp;


    // Update is called once per frame
    void Update()
    {
        EtoInteract.SetActive(IsInRange);



        if (IsInRange && hamadaUIScript.Pratat)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Robot Interact");
                PickedUp = true;

                carryRobot.SetActive(true);
                EtoInteract.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            Debug.Log("Robot in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = false;
            Debug.Log("Robot NOT in range");
        }
    }
}
