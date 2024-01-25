using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrågesportScript : MonoBehaviour
{


    public TextMeshProUGUI frågeText; //Text för frågerutan
    public TextMeshProUGUI[] svarText = new TextMeshProUGUI[3]; //Text för Svar knappar
    
    public TextMeshProUGUI dialog;
    public GameObject dialogBox;
    
    public GameObject QuizUI;

    public KeyManager KeyManager;

    private int[] rättSvar = { 1, 2, 3 };  //Rätt svar för fråga 1,2,3

    int index = 0;
    bool quizEnded;



    // Start is called before the first frame update
    void Start()
    {
        fråga(index);
    }

    private void Update()
    {
        if( quizEnded)
        {
            //reset om man gör om quizet
            index = 0;
            quizEnded = false; 

            dialogBox.SetActive(true);
            QuizUI.SetActive(false);
        }
    }

    public void svar1()
    {
        Debug.Log("Svarat: 1");
        if (rättSvar[index] == 1)
        {
            Debug.Log("Rätt svar");
            fråga(++index);
        }
        else felSvar();
    }
    public void svar2()
    {
        Debug.Log("Svarat: 2");
        if (rättSvar[index] == 2)
        {
            Debug.Log("Rätt svar");
            fråga(++index);
        }
        else felSvar();
    }
    public void svar3()
    {
        Debug.Log("Svarat: 3");
        if (rättSvar[index] == 3)
        {
            Debug.Log("Rätt svar");
            fråga(++index);
        }
        else felSvar();
    }
    
    void fråga(int i)
    {
        switch (i)
        {
            case 0: fråga1(); break;
            case 1: fråga2(); break;
            case 2: fråga3(); break;
            case 3: allaRätt(); break;
            default: break;
        }
    }

    void fråga1() 
    {
        Debug.Log("fråga 1");
        frågeText.text = "Här är första frågan.";
        svarText[0].text = "Svar alternativ 1";
        svarText[1].text = "Svar alternativ 2";
        svarText[2].text = "Svar alternativ 3";
    }

    void fråga2() 
    {
        Debug.Log("Fråga 2");
        frågeText.text = "Här är andra frågan.";
        svarText[0].text = "Svar alternativ 1";
        svarText[1].text = "Svar alternativ 2";
        svarText[2].text = "Svar alternativ 3";
    }

    void fråga3() 
    {
        Debug.Log("Fråga 3");
        frågeText.text = "Här är tredje frågan.";
        svarText[0].text = "Svar alternativ 1";
        svarText[1].text = "Svar alternativ 2";
        svarText[2].text = "Svar alternativ 3";
    }

    void allaRätt()
    {
        Debug.Log("Du vann frågesporten");
        fråga(0);
        dialog.text = "Grattis! Du klarade frågesporten, du får en nyckel av mig.";
        quizEnded = true;
        // Keys++
        if (!ObtainedHelenKey()) // om inte redan fått den
        {
            GainHelenKey();
            KeyManager.addKey();
        }
        
    }

    void felSvar()
    {
        Debug.Log("Du torska frågesporten");
        dialog.text = "Fel svar! Du kan försöka igen om du vill...";
        fråga(0);
        quizEnded = true;
    }


    private bool ObtainedHelenKey()
    {
        if (PlayerPrefs.GetInt("HelenKey") == 1)
        { return true; }
        else { return false; }
    }

    private void GainHelenKey()
    {
        PlayerPrefs.SetInt("HelenKey", 1);
    }
}
