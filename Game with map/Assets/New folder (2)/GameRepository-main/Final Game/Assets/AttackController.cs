using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public GameObject player;
    public PlayerScript playerScript;
    public GameObject bulletPrefab;
    public Transform attackOrigin;
    public Transform attackCenter;
    public GameObject combatPrefab;
    public float attackRadius = 0.2f;
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
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, attackOrigin.position, attackCenter.rotation);
            Debug.Log("Fired");
        }

        isAttacking = Physics2D.OverlapCircle(attackOrigin.position, attackRadius, enemy);

        if (Input.GetKeyDown(KeyCode.LeftControl) && isAttacking)
        {
            Instantiate(combatPrefab, attackOrigin.position, attackOrigin.rotation);
            swordHit.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl) && !isAttacking)
        {
            swordSound.GetComponent<AudioSource>().Play();
        }

    }

}