using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{

    private float speed = 6.0f;
    public Rigidbody2D rb;
    Vector2 movePos;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive == true)
        {
            movePos.x = Input.GetAxis("Player_1_Horizontal");
            movePos.y = Input.GetAxis("Player_1_Vertical");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movePos * speed * Time.deltaTime);
    }
}

