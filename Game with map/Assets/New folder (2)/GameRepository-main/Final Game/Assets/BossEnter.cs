using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnter : MonoBehaviour
{
    public GameObject plains;
    public GameObject snow;
    public GameObject forest;
    public GameObject desert;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plains == null && snow == null && forest == null && desert == null)
        {
            Destroy(gameObject);
        }
    }
}
