using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject EtoInteract;
    bool IsInRange;
    public KeyManager KeyManager;

    

    // Update is called once per frame
    void Update()
    {
        EtoInteract.SetActive(IsInRange);


        if (IsInRange && Input.GetKeyDown(KeyCode.E))
        {
            
            Debug.Log("Key Interact");
            KeyManager.addKey();

            EtoInteract.SetActive(false);
            gameObject.SetActive(false);
            
        }
    }


    //Key in range?
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            Debug.Log("Key in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsInRange = false;
            Debug.Log("Key NOT in range");
        }
    }
}