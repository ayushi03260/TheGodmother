using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
//using System;

public class updateMcText : MonoBehaviour
{
    public TMP_Text mcText;
    public TMP_Text oppText;
    public TMP_Text useText;
    public static int amount;
    int randAmt;
    //public static int oppAmount;
    //public GameManager script = new GameManager();
    // Start is called before the first frame update
    void Start()
    {
        mcText.text = "100";
        //oppText.text = "100";
    }

    // Update is called once per frame
    void Update()
    {
        //int mcAmt = script.manaMCamt;
        if (amount > 0)
        {
            mcText.text = amount.ToString();
            randAmt = oppchosen();

            Invoke("function", 5f);

        }
        
        //oppText.text = oppAmount.ToString();
        //Debug.Log(amount.ToString());
    }
    public int oppchosen()
    {
        int[] oppAmount = new int[] {-5, 0};
        return oppAmount[Random.Range(0,1)];
    }

    void function()
    {
        useText.text = "Opp used " + randAmt.ToString();
        
        Debug.Log(amount + randAmt);
        randAmt = 0;
        //mcText.text = amount.ToString();
    }

}
