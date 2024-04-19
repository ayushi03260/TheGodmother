using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public int manaMCamt = 100;
    public int manaOppamt = 100;
    public TMP_Text manaMC;

    //public OnButtonClick onButtonClick;
    void Start()
    {
        if(manaMC != null)
        {
            manaMC.text = manaMCamt.ToString();
        }
    }
    /*void Update()
    {
        manaMC.text = manaMC.ToString();
    }*/
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void healAMT(int amt)
    {
        manaMCamt += amt;
        manaMC.text = manaMCamt.ToString();
        Debug.Log(manaMCamt);
        manaMC.text = manaMCamt.ToString();

    }
    public void substractScore(int subAmt)
    {
        manaMCamt -= subAmt;
        manaMC.text = manaMCamt.ToString();
    }
}
