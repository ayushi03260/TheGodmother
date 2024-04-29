using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changeAmt : MonoBehaviour
{
    //public TMP_Text mcText;
    public static int manaMCamt = GameManager.manaMCamt;
    public static int oppAmttotal = GameManager.oppAmount;
    // Start is called before the first frame update
    void Start()
    {
        updateMcText.amount = manaMCamt;
        Debug.Log(manaMCamt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void healAmt(int amount)
    {
        manaMCamt += amount;
        Debug.Log(manaMCamt.ToString());

        updateMcText.amount = manaMCamt;
    }
    public void oppAmtdamage(int amount)
    {
        oppAmttotal -= amount;
        oppAmt.oppAmount = oppAmttotal;
    }
    public void check()
    {
        int bscore = LogicScript.playerScore;
    }

    // public int getManaMCamt() { return manaMCamt; }
}
