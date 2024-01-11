using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDialog : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
        

    }
}
