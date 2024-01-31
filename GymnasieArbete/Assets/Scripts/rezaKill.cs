using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class rezaKill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
        if (other.tag == "Player")
        {
            Debug.Log("Reza tog din röv");
            SceneManager.LoadSceneAsync("DeathScreen");
        }
    }
}
