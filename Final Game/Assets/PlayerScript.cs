using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Animator animator;
    public int playerFlipped = 0;
    public LayerMask enemy;
    public GameObject player;
    public GameObject red;
    public LevelManager levelManager;

    public int playerHealth = 5;
    
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
            animator.SetInteger("NormanState", 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 8;
            animator.SetInteger("NormanState", 3);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -8;
            animator.SetInteger("NormanState", 4);
        }
        else
        {
            velocity.y = 0;
            animator.SetInteger("NormanState", 0);
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            velocity.x = 0;
            animator.SetInteger("NormanState", 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -8;
            playerFlipped = 1;
            animator.SetInteger("NormanState", 2);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity.x = 8;
            playerFlipped = 0;
            animator.SetInteger("NormanState", 1);
        }
        else
        {
            velocity.x = 0;

        }

        this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Debug.Log("Collide with walls");
        }
        else
        {
            StartCoroutine(levelManager.RedShow());
            playerHealth--;
            if (playerHealth <= 0)
            {
                StartCoroutine(levelManager.Death());
            }
        }
    }
}
