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
    
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        manaMC.text = manaMCamt.ToString();
    }
    public void healAMT(int amt)
    {
        manaMCamt -= amt;
        //manaMC.text = manaMCamt.ToString();
        
    }
}
