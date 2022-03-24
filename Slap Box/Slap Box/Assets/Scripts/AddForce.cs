using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    Rigidbody2D rb;
    private float push = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * push);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
