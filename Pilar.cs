using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilar : MonoBehaviour
{
    public GameManager manager;
    private float speed = 2; 

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -4.1f)
        {
            Destroy(this.gameObject);
        }
    }
}
