using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitFogo : MonoBehaviour
{

    private float speed = 2f;



    Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        GetComponent<BitFogo>().enabled= true;
        GetComponent<CircleCollider2D>().isTrigger = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * speed;
        }

        if (GameManager.collisionWithCE == true && GameManager.pontos <= 45)
        {
            GetComponent<CircleCollider2D>().isTrigger = true;
            GetComponent<BitFogo>().enabled = false;
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CE"))
        {
            GameManager.collisionWithCE = true;
        }
    }

}
