using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelenDialouge : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public string[] lines = new string[5];
    public float textspeed = 1;

    private int index = 0;

    
    
    //Questions
    private string q1 = "Fråga 1: ...";
    private string q2 = "Fråga 2: ...";
    private string q3 = "Fråga 3: ...";



    // Start is called before the first frame update
    void Start()
    {
        
        

        textMesh.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textMesh.text == lines[index]) //click - nästa text
            {
                NextLine();
            }
            else //click -> skriv all text dirr
            {
                StopAllCoroutines();
                textMesh.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());


    }

    IEnumerator TypeLine()
    {
        //skriver bokstav för bokstav

        foreach (char c in lines[index].ToCharArray())
        {
            textMesh.text += c;
            yield return new WaitForSeconds(textspeed);
        }

    }


    void NextLine()
    {
        if (index < lines.Length - 1) // om det finns fler lines
        {
            //nästa line
            index++;
            textMesh.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            //Slut
            gameObject.SetActive(false);
        }
    }

}
