using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBoss : MonoBehaviour
{
    public GameObject player;
    private bool isInPlayerRange = false;
    public LayerMask playerLayer;
    private float playerRange = 7;
    public int snowBossHealth = 20;
    public Animator animator;
    public GameObject projectilePrefab;
    private bool hasStarted = false;
    public LevelManager levelManager;

    public Transform attackOrigin;
    public Transform attack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
