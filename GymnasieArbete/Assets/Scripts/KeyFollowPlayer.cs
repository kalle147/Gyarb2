using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyFollowPlayer : MonoBehaviour
{
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;

    float speed1 = 0.1f;
    float speed2 = 0.09f;
    float speed3 = 0.081f;


    public GameObject player;

    public KeyManager KeyManager;


    private void FixedUpdate()
    {
        if (KeyManager.keys >= 1)
        {
            key1.transform.position = Vector2.MoveTowards(key1.transform.position, player.transform.position, speed1);
            key1.SetActive(true);
        }
        if (KeyManager.keys >= 2)
        {
            key2.transform.position = Vector2.MoveTowards(key2.transform.position, key1.transform.position, speed2);
            key2.SetActive(true);
        }
        if (KeyManager.keys >= 3)
        {
            key3.transform.position = Vector2.MoveTowards(key3.transform.position, key2.transform.position, speed3);
            key3.SetActive(true);
        }
    }
}
