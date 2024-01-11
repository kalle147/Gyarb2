using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class HelenUIScript : MonoBehaviour
{
    

    public GameObject QuizUI;
    public GameObject EtoInteract;

    //private bool Pratat;
    public bool IsInRange;



    

    // Update is called once per frame
    void Update()
    {




        EtoInteract.SetActive(IsInRange);
        if (IsInRange/*&& !Pratat*/)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interact med Helen");
                
                QuizUI.SetActive(true);
                //Pratat = true;
            }
        }



    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            Debug.Log("Helen - Player in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = false;
            Debug.Log("Helen - Player NOT in range");
        }
    }


}
