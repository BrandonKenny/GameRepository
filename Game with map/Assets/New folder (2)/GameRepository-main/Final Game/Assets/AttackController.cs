using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    public Transform attackOrigin;
    public Transform attackCenter;

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
        }
    }
}