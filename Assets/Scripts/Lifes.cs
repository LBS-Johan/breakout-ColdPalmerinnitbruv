using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Lives <= 0)
        {
            LoadGameOverScene();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Bottom Wall"))
        {

            LoseLife();
            livesContainer.transform.GetChild(Lives - 1).gameObject.SetActive(false);

           

           


        }
    }


    public void LoseLife()
    {
        Lives--;
    }

    void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }
    
    
       

        
        
            

        
    

    

}
