using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outro : MonoBehaviour
{
    public LevelManager levelManager;

    public GameObject michael;
    public GameObject norman;
    public GameObject clara;

    public GameObject defeated;
    public GameObject home;

    public GameObject startSound;

    public float rotateSpeed;
    public Vector3 rotateDirection = new Vector3();
    public float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        startSound.GetComponent<AudioSource>().Play();
        StartCoroutine(OutroSequence());
    }

    IEnumerator OutroSequence()
    {
        yield return new WaitForSeconds(3);
        defeated.gameObject.GetComponent<Transform>().position = new Vector2(-3f, 1f);

        yield return new WaitForSeconds(4);
        defeated.gameObject.GetComponent<Transform>().position = new Vector2(0f, 20f);

        yield return new WaitForSeconds(1);
        StartCoroutine(RotateMichael());
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -3f);

        yield return new WaitForSeconds(4);
        michael.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        yield return new WaitForSeconds(1);
        clara.gameObject.GetComponent<Animator>().SetInteger("ClaraState", 1);
        norman.gameObject.GetComponent<Animator>().SetInteger("NormanState", 2);
        clara.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 0f);
        norman.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-3f, 0f);

        yield return new WaitForSeconds(2);
        clara.gameObject.GetComponent<Animator>().SetInteger("ClaraState", 0);
        norman.gameObject.GetComponent<Animator>().SetInteger("NormanState", 0);
        clara.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        norman.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        yield return new WaitForSeconds(1);
        home.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1f);

        yield return new WaitForSeconds(4);
        home.gameObject.GetComponent<Transform>().position = new Vector2(0f, 20f);

        yield return new WaitForSeconds(1);
        clara.gameObject.GetComponent<Animator>().SetInteger("ClaraState", 1);
        norman.gameObject.GetComponent<Animator>().SetInteger("NormanState", 1);
        clara.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 0f);
        norman.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 0f);

        yield return new WaitForSeconds(4);
        clara.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        norman.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        yield return new WaitForSeconds(1);
        levelManager.LoadLevel("Win");
    }

    IEnumerator RotateMichael()
    {
        while (count <= 448)
        {
            count += 2;
            michael.transform.rotation = Quaternion.Euler(0f, 0f, count);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
