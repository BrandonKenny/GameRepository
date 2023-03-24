using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerFlipped = 0;
    
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
        }
        else if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 8;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -8;
        }
        else
        {
            velocity.y = 0;
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            velocity.x = 0;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -8;
            playerFlipped = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity.x = 8;
            playerFlipped = 0;
        }
        else
        {
            velocity.x = 0;
        }
        
        this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
