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

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;

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

        if (this.gameObject.GetComponent<Transform>().position.z == 20)
        {
            velocity.x = 0;
            velocity.y = 0;
        }

        this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;

        //Hearts
        if (playerHealth == 5)
        {
            heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y, -2f);
            heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y, -2f);
            heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y, -2f);
            heart4.transform.position = new Vector3(heart4.transform.position.x, heart4.transform.position.y, -2f);
            heart5.transform.position = new Vector3(heart5.transform.position.x, heart5.transform.position.y, -2f);
        }
        if (playerHealth == 4)
        {
            heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y, -2f);
            heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y, -2f);
            heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y, -2f);
            heart4.transform.position = new Vector3(heart4.transform.position.x, heart4.transform.position.y, -2f);
            heart5.transform.position = new Vector3(heart5.transform.position.x, heart5.transform.position.y, 2f);
        }
        if (playerHealth == 3)
        {
            heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y, -2f);
            heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y, -2f);
            heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y, -2f);
            heart4.transform.position = new Vector3(heart4.transform.position.x, heart4.transform.position.y, 2f);
            heart5.transform.position = new Vector3(heart5.transform.position.x, heart5.transform.position.y, 2f);
        }
        if (playerHealth == 2)
        {
            heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y, -2f);
            heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y, -2f);
            heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y, 2f);
            heart4.transform.position = new Vector3(heart4.transform.position.x, heart4.transform.position.y, 2f);
            heart5.transform.position = new Vector3(heart5.transform.position.x, heart5.transform.position.y, 2f);
        }
        if (playerHealth == 1)
        {
            heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y, -2f);
            heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y, 2f);
            heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y, 2f);
            heart4.transform.position = new Vector3(heart4.transform.position.x, heart4.transform.position.y, 2f);
            heart5.transform.position = new Vector3(heart5.transform.position.x, heart5.transform.position.y, 2f);
        }
        if (playerHealth == 0)
        {
            heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y, 2f);
            heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y, 2f);
            heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y, 2f);
            heart4.transform.position = new Vector3(heart4.transform.position.x, heart4.transform.position.y, 2f);
            heart5.transform.position = new Vector3(heart5.transform.position.x, heart5.transform.position.y, 2f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Debug.Log("Collide with walls");
        }
        else if (collision.gameObject.tag == "Hearts")
        {
            if (playerHealth < 5)
            {
                playerHealth++;
            }
            Debug.Log("Collide with hearts");
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
