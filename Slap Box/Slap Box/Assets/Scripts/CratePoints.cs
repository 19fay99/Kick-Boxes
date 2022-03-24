using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePoints : MonoBehaviour
{

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.name == "GreenShip")
        {
            gameManager.UpdateP1Score(1);
            Destroy(gameObject);
        }

        if(collision.transform.name == "PurpleShip")
        {
            gameManager.UpdateP2Score(1);
            Destroy(gameObject);
        }
    }
}
