using UnityEngine;
using UnityEngine.SceneManagement;

public class mapMovement : MonoBehaviour
{
    public int num;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up*Time.deltaTime*num);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * num);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * num);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * num);
        }
    }

    private void OnTriggerEnter2D(Collider2D opp)
    {

        if (opp.gameObject.CompareTag("opp"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(0);
        }
    }

}
