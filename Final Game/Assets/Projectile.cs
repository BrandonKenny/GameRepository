using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //Vector2 velocity = this.gameObject.GetComponent<Rigidbody2D>().velocity;
        rb.velocity = transform.right * Speed;
        //this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D basketball)
    {
        Destroy(gameObject);
    }
}
