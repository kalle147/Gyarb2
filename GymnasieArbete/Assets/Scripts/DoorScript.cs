using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
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
            if(KeyManager.keys == 3)
            {
                EtoInteract.SetActive(false);
                gameObject.SetActive(false);
            } else
            {
                //dialogruta du har inte tillräckligt med nycklar
                Debug.Log("Not enough keys");
            }
        }
    }

    // dörr in range?
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
