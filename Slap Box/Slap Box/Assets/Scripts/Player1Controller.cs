using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{

    private float speed = 6.0f;
    public Rigidbody2D rb;
    Vector2 movePos;
    

    // Update is called once per frame
    void Update()
    {
        movePos.x = Input.GetAxis("Player_1_Horizontal");
        movePos.y = Input.GetAxis("Player_1_Vertical");

        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Player 1 Action");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movePos * speed * Time.deltaTime);
    }
}

