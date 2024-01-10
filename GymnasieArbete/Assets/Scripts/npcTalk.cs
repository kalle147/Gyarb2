using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class npcTalk : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public string[] lines;
    public float textspeed;

    private int index = 0;

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
            if (textMesh.text == lines[index])
            {
                NextLine();
            }
            else
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
        if (index < lines.Length - 1)
        {
            index++;
            textMesh.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
