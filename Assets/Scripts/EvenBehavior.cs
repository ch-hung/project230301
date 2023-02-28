using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
