using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject collisionObject;
    public int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D basketball)
    {
        if (count == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            count--;
        }
    }
}
