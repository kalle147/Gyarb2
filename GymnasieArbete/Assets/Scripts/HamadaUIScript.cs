using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HamadaUIScript : MonoBehaviour
{

    public GameObject UIText;
    public GameObject EtoInteract;
    
    //private bool Pratat;
    public bool IsInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EtoInteract.SetActive(IsInRange);



        if (IsInRange)
        {
            if (Input.GetKeyDown(KeyCode.E)/*&& !Pratat*/)
            {
                Debug.Log("Pratning med Hamada");

                UIText.SetActive(true);
                //Pratat = true;
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