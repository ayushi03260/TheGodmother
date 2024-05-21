using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;
//using System;

public class updateMcText : MonoBehaviour
{
    public TMP_Text mcText;
    public TMP_Text oppText;
    public TMP_Text useText;
    public static int amount;

    public bool updatedAmount = false;

    //public static bool mcAlive = true;
    //int randAmt;
    //public static int oppAmount;
    //public GameManager script = new GameManager();
    // Start is called before the first frame update
    void Start()
    {
        mcText.text = "100";
        //amount = 100;
        //oppText.text = "100";
        //mcAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //int mcAmt = script.manaMCamt;
        Debug.Log(amount);
        if (amount > 0)
        {
            mcText.text = amount.ToString();
            //int randAmt = oppchosen();
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "fightingScene" && updatedAmount == false)
            {
                Invoke("function", 5f);
                updatedAmount = true;
            }
        }
        else if(amount < 1)
        {

            //GameManager.manaMCamt = 100;
            //mcAlive = false;
            amount = 100;
            SceneManager.LoadScene(5);
            Debug.Log(amount);
            Debug.Log(GameManager.manaMCamt);
        }
        /*
        if (!isAlive())
        {
            SceneManager.LoadScene(5);
        }
        */
        //oppText.text = oppAmount.ToString();
        //Debug.Log(amount.ToString());
    }
    public int oppchosen()
    {
        int[] oppAmount = new int[] {-5};
        return oppAmount[Random.Range(0,1)];
    }

    void function()
    {
        int[] oppAmount = new int[] {-5, -10, -15, -20 };
        int randAmt = oppAmount[Random.Range(0, 4)];
        useText.text = "Opp used " + randAmt.ToString();
        
        Debug.Log(amount);
        changeAmt.subtractAmt(randAmt);
        //SleepTimeout(5);
        //randAmt = 0;
        //mcText.text = amount.ToString();
    }
    /*
    public static bool isAlive()
    {
        if (GameManager.oppAmount < 0)
        {
            //manaMCamt = 100;
            return false;
        }
        return true;
    }
    */
}
