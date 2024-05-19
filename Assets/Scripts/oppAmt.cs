using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oppAmt : MonoBehaviour
{
    // Start is called before the first frame update
    //public TMP_Text mcText;
    public TMP_Text oppText;
    //public static int amount;
    public static int oppAmount;
    //public GameManager script = new GameManager();
    // Start is called before the first frame update
    void Start()
    {
        //mcText.text = "100";
        oppText.text = "100";
    }

    // Update is called once per frame
    void Update()
    {
        //int mcAmt = script.manaMCamt;
        //mcText.text = amount.ToString();
        oppText.text = oppAmount.ToString();
        //Debug.Log(amount.ToString());
        if (oppAmount < 1)
        {
            SceneManager.LoadScene(5);
            //oppAmount = 100;
        }
    }
}
