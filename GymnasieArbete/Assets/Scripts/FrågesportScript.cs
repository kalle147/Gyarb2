using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrågesportScript : MonoBehaviour
{


    public TextMeshProUGUI frågeText; //Text för frågerutan
    public TextMeshProUGUI[] svarText = new TextMeshProUGUI[3]; //Text för Svar knappar

    //private bool[] rättSvar = new bool[3];  

    private int[] rättSvar = { 1, 2, 3 };  //Rätt svar för fråga 1,2,3


    int[] dittSvar = new int[3];

    int index = 0;




    // Start is called before the first frame update
    void Start()
    {
        fråga(index);
    }
 
    public void svar1()
    {
        Debug.Log("Svarat: 1");
        dittSvar[index] = 1;
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
        dittSvar[index] = 2;
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
        dittSvar[index] = 3;
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

        // Keys++
    }

    void felSvar()
    {
        Debug.Log("Du torska frågesporten");
        index = 0;
    }

}
