using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int manaMCamt = 100;
    public static int oppAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        updateMcText.amount = manaMCamt;
        oppAmt.oppAmount = oppAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
