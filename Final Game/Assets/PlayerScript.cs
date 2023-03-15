using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = this.gameObject.GetComponent<Rigidbody2D>().velocity;
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -8;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = 8;
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 8;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -8;
        }
        this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
