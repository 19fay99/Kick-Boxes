using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    public float speed = 10.0f;
    public Rigidbody2D rb;
    Vector2 movePos;


    // Update is called once per frame
    void Update()
    {
        movePos.x = Input.GetAxis("Player_2_Horizontal");
        movePos.y = Input.GetAxis("Player_2_Vertical");

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("Player 2 Action");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movePos * speed * Time.deltaTime);
    }
}

