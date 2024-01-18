using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HamadaUIScript : MonoBehaviour
{

    public GameObject UIText;
    public GameObject UIText2;

    public GameObject EtoInteract;

    public GameObject RobotCarried;
    public GameObject RobotFinal;
    public robot robot;

    public bool Pratat;
    public bool IsInRange;

    public KeyManager KeyManager;

    bool keyFromHamada;

    // Update is called once per frame
    void Update()
    {
        EtoInteract.SetActive(IsInRange);
        

        if (IsInRange)
        {
            if (Input.GetKeyDown(KeyCode.E) && !robot.PickedUp)
            {
                Debug.Log("Pratning med Hamada");

                UIText.SetActive(true);
                Pratat = true;
            } else if(Input.GetKeyDown(KeyCode.E) && robot.PickedUp)
            {
                RobotFinal.SetActive(true);
                RobotCarried.SetActive(false);
                UIText2.SetActive(true);

                
                if (keyFromHamada == false) // gör så den kommer ihåg genom olika scenes
                {
                    keyFromHamada = true;
                    KeyManager.addKey();
                }
                    
                    
                    
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            Debug.Log("Player is in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            IsInRange = false;
            Debug.Log("Player is NOT in range");
        }
    }

}