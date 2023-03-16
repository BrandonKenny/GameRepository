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

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            velocity.y = 0;
            print("W and S");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 8;
            print("W");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -8;
            print("S");
        }
        else
        {
            velocity.y = 0;
            print("NONE");
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            velocity.x = 0;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -8;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity.x = 8;
        }
        else
        {
            velocity.x = 0;
        }
        
        this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
