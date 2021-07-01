using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{

    private float speed = -0.035f;

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);

        if (transform.position.x <= -7)
        {
            Destroy(gameObject);
            GeraChao.chaoGerado--;
        }
    }

    
}
