using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public LevelManager levelManager;
    
    public GameObject michael;
    public GameObject norman;
    public GameObject clara;

    public GameObject niceDay;
    public GameObject yeah;
    public GameObject run;
    public GameObject nooo;
    public GameObject saveHer;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(4);
        niceDay.gameObject.GetComponent<Transform>().position = new Vector2(3f, 2f);
        yield return new WaitForSeconds(4);
        niceDay.gameObject.GetComponent<Transform>().position = new Vector2(3f, 20f);
        yeah.gameObject.GetComponent<Transform>().position = new Vector2(-2f, 2f);
        yield return new WaitForSeconds(4);
        yeah.gameObject.GetComponent<Transform>().position = new Vector2(-2f, 20f);
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(7f, 0f);
        yield return new WaitForSeconds(1);
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        run.gameObject.GetComponent<Transform>().position = new Vector2(3f, 2f);
        yield return new WaitForSeconds(2);
        run.gameObject.GetComponent<Transform>().position = new Vector2(3f, 20f);
        norman.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 0f);
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(7f, 0f);
        yield return new WaitForSeconds(1);
        norman.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-7f, 0f);
        clara.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-7f, 0f);
        yield return new WaitForSeconds(4);
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        clara.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        nooo.gameObject.GetComponent<Transform>().position = new Vector2(4.5f, 2f);
        yield return new WaitForSeconds(3);
        nooo.gameObject.GetComponent<Transform>().position = new Vector2(4.5f, 20f);
        yield return new WaitForSeconds(1);
        saveHer.gameObject.GetComponent<Transform>().position = new Vector2(0f, 0f);
        yield return new WaitForSeconds(5);
        levelManager.LoadLevel("Main");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
