using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifes : MonoBehaviour
{
    Rigidbody2D rb;
    int Lives = 3;
    public GameObject livesContainer;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Bottom Wall"))
        {

            if(Lives <= 0)
            {
                GameOver();
            }
            else
            {
                Lives--;
                livesContainer.transform.GetChild(Lives-1).gameObject.SetActive(false);
            }


        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
    }


}
