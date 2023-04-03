using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject player;
    public PlayerScript playerScript;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject combatPrefab;
    public float attackRadius;
    public LayerMask enemy;
    private bool isAttacking;

    public GameObject projectileSound;
    public GameObject swordSound;
    public GameObject swordHit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = player.gameObject.GetComponent<Transform>().position;
        Vector2 firePosition = firePoint.gameObject.GetComponent<Transform>().position;
        Quaternion playerRotation = player.gameObject.GetComponent<Transform>().rotation;
        Quaternion fireRotation = firePoint.gameObject.GetComponent<Transform>().rotation;
        
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            firePosition.x = playerPosition.x + 1;
            firePosition.y = playerPosition.y + 1;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, 45f));
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            firePosition.x = playerPosition.x - 1;
            firePosition.y = playerPosition.y + 1;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, 135f));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            firePosition.x = playerPosition.x + 1;
            firePosition.y = playerPosition.y - 1;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, -45f));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            firePosition.x = playerPosition.x - 1;
            firePosition.y = playerPosition.y - 1;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, -135f));
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            firePosition.x = playerPosition.x;
            firePosition.y = playerPosition.y + 1;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, 90f));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            firePosition.x = playerPosition.x;
            firePosition.y = playerPosition.y - 1;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, -90f));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            firePosition.x = playerPosition.x + 1;
            firePosition.y = playerPosition.y;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            firePosition.x = playerPosition.x - 1;
            firePosition.y = playerPosition.y;
            firePoint.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(new Vector3(0f, 0f, 180f));
        }
        firePoint.gameObject.GetComponent<Transform>().position = firePosition;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            projectileSound.GetComponent<AudioSource>().Play();
        }
        
        isAttacking = Physics2D.OverlapCircle(firePoint.position, attackRadius, enemy);

        if (Input.GetKeyDown(KeyCode.LeftControl) && isAttacking)
        {
            Instantiate(combatPrefab, firePoint.position, firePoint.rotation);
            swordHit.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl) && !isAttacking)
        {
            swordSound.GetComponent<AudioSource>().Play();
        }

    }

    void OnCollisionEnter2D(Collision2D basketball)
    {
        Destroy(gameObject);
    }

}