using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject collisionObject;

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
        if (basketball.gameObject.name == collisionObject.name && Input.GetKeyDown(KeyCode.LeftControl))
        {
            Destroy(gameObject);
        }
        Destroy(this.gameObject);
    }
}
