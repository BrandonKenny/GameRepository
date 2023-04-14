using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject michael;
    public GameObject player;
    public GameObject clara;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        print("E");
        yield return new WaitForSeconds(5);
        print("EE");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
