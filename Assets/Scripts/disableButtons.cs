using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disableButtons : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    // Start is called before the first frame update
    void Start()
    {
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (LogicScript.playerScore > 4)
        {
            button2.gameObject.SetActive(true);
        }
        if (LogicScript.playerScore > 9)
        {
            button3.gameObject.SetActive(true);
        }
        if (LogicScript.playerScore > 14)
        {
            button4.gameObject.SetActive(true);
        }

        if (Snake.snakeScore > 4)
        {
            button2.gameObject.SetActive(true);
        }
        if (Snake.snakeScore > 9)
        {
            button3.gameObject.SetActive(true);
        }
        if (Snake.snakeScore > 14)
        {
            button4.gameObject.SetActive(true);
        }

    }
}
