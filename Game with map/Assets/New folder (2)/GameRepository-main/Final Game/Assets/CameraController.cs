using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    //PREVIEW MODE
    //float xChange1 = 12.82f;
    //float xChange2 = 11.61f;
    //float xChange3 = 10.4f;
    //float xChange4 = 9.19f;
    //float xChange5 = 7.98f;
    float yChange1 = 6.19f;
    float yChange2 = 7.4f;
    //BUILD MODE
    float xChange1 = 10.56f;
    float xChange2 = 9.35f;
    float xChange3 = 8.14f;
    float xChange4 = 6.93f;
    float xChange5 = 5.72f;
    float xChange6 = 10.56f;
    float xChange7 = 9.35f;
    float xChange8 = 8.14f;
    float xChange9 = 6.93f;
    float xChange10 = 5.72f;

    public GameObject heart1;
    public GameObject heartempty1;

    public GameObject heart2;
    public GameObject heartempty2;

    public GameObject heart3;
    public GameObject heartempty3;

    public GameObject heart4;
    public GameObject heartempty4;

    public GameObject heart5;
    public GameObject heartempty5;

    public GameObject heart6;
    public GameObject heartempty6;

    public GameObject heart7;
    public GameObject heartempty7;

    public GameObject heart8;
    public GameObject heartempty8;

    public GameObject heart9;
    public GameObject heartempty9;

    public GameObject heart10;
    public GameObject heartempty10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 playerPos = player.gameObject.GetComponent<Transform>().position;
            this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

            //heart 1
            Vector3 heart1Pos = heart1.gameObject.GetComponent<Transform>().position;
            heart1Pos.x = playerPos.x + xChange1;
            heart1Pos.y = playerPos.y - yChange1;
            heart1.transform.position = new Vector3(heart1Pos.x, heart1Pos.y, heart1Pos.z);

            Vector3 heartempty1Pos = heartempty1.gameObject.GetComponent<Transform>().position;
            heartempty1Pos.x = playerPos.x + xChange1;
            heartempty1Pos.y = playerPos.y - yChange1;
            heartempty1.transform.position = new Vector3(heartempty1Pos.x, heartempty1Pos.y, heartempty1Pos.z);

            //heart 2
            Vector3 heart2Pos = heart2.gameObject.GetComponent<Transform>().position;
            heart2Pos.x = playerPos.x + xChange2;
            heart2Pos.y = playerPos.y - yChange1;
            heart2.transform.position = new Vector3(heart2Pos.x, heart2Pos.y, heart2Pos.z);

            Vector3 heartempty2Pos = heartempty2.gameObject.GetComponent<Transform>().position;
            heartempty2Pos.x = playerPos.x + xChange2;
            heartempty2Pos.y = playerPos.y - yChange1;
            heartempty2.transform.position = new Vector3(heartempty2Pos.x, heartempty2Pos.y, heartempty2Pos.z);

            //heart 3
            Vector3 heart3Pos = heart3.gameObject.GetComponent<Transform>().position;
            heart3Pos.x = playerPos.x + xChange3;
            heart3Pos.y = playerPos.y - yChange1;
            heart3.transform.position = new Vector3(heart3Pos.x, heart3Pos.y, heart3Pos.z);

            Vector3 heartempty3Pos = heartempty3.gameObject.GetComponent<Transform>().position;
            heartempty3Pos.x = playerPos.x + xChange3;
            heartempty3Pos.y = playerPos.y - yChange1;
            heartempty3.transform.position = new Vector3(heartempty3Pos.x, heartempty3Pos.y, heartempty3Pos.z);
            
            //heart 4
            Vector3 heart4Pos = heart4.gameObject.GetComponent<Transform>().position;
            heart4Pos.x = playerPos.x + xChange4;
            heart4Pos.y = playerPos.y - yChange1;
            heart4.transform.position = new Vector3(heart4Pos.x, heart4Pos.y, heart4Pos.z);

            Vector3 heartempty4Pos = heartempty4.gameObject.GetComponent<Transform>().position;
            heartempty4Pos.x = playerPos.x + xChange4;
            heartempty4Pos.y = playerPos.y - yChange1;
            heartempty4.transform.position = new Vector3(heartempty4Pos.x, heartempty4Pos.y, heartempty4Pos.z);

            //heart 5
            Vector3 heart5Pos = heart5.gameObject.GetComponent<Transform>().position;
            heart5Pos.x = playerPos.x + xChange5;
            heart5Pos.y = playerPos.y - yChange1;
            heart5.transform.position = new Vector3(heart5Pos.x, heart5Pos.y, heart5Pos.z);

            Vector3 heartempty5Pos = heartempty5.gameObject.GetComponent<Transform>().position;
            heartempty5Pos.x = playerPos.x + xChange5;
            heartempty5Pos.y = playerPos.y - yChange1;
            heartempty5.transform.position = new Vector3(heartempty5Pos.x, heartempty5Pos.y, heartempty5Pos.z);

            //heart 6
            Vector3 heart6Pos = heart6.gameObject.GetComponent<Transform>().position;
            heart6Pos.x = playerPos.x + xChange6;
            heart6Pos.y = playerPos.y - yChange2;
            heart6.transform.position = new Vector3(heart6Pos.x, heart6Pos.y, heart6Pos.z);

            Vector3 heartempty6Pos = heartempty6.gameObject.GetComponent<Transform>().position;
            heartempty6Pos.x = playerPos.x + xChange6;
            heartempty6Pos.y = playerPos.y - yChange2;
            heartempty6.transform.position = new Vector3(heartempty6Pos.x, heartempty6Pos.y, heartempty6Pos.z);

            //heart 7
            Vector3 heart7Pos = heart7.gameObject.GetComponent<Transform>().position;
            heart7Pos.x = playerPos.x + xChange7;
            heart7Pos.y = playerPos.y - yChange2;
            heart7.transform.position = new Vector3(heart7Pos.x, heart7Pos.y, heart7Pos.z);

            Vector3 heartempty7Pos = heartempty7.gameObject.GetComponent<Transform>().position;
            heartempty7Pos.x = playerPos.x + xChange7;
            heartempty7Pos.y = playerPos.y - yChange2;
            heartempty7.transform.position = new Vector3(heartempty7Pos.x, heartempty7Pos.y, heartempty7Pos.z);

            //heart 8
            Vector3 heart8Pos = heart8.gameObject.GetComponent<Transform>().position;
            heart8Pos.x = playerPos.x + xChange8;
            heart8Pos.y = playerPos.y - yChange2;
            heart8.transform.position = new Vector3(heart8Pos.x, heart8Pos.y, heart8Pos.z);

            Vector3 heartempty8Pos = heartempty8.gameObject.GetComponent<Transform>().position;
            heartempty8Pos.x = playerPos.x + xChange8;
            heartempty8Pos.y = playerPos.y - yChange2;
            heartempty8.transform.position = new Vector3(heartempty8Pos.x, heartempty8Pos.y, heartempty8Pos.z);
            
            //heart 9
            Vector3 heart9Pos = heart9.gameObject.GetComponent<Transform>().position;
            heart9Pos.x = playerPos.x + xChange9;
            heart9Pos.y = playerPos.y - yChange2;
            heart9.transform.position = new Vector3(heart9Pos.x, heart9Pos.y, heart9Pos.z);

            Vector3 heartempty9Pos = heartempty9.gameObject.GetComponent<Transform>().position;
            heartempty9Pos.x = playerPos.x + xChange9;
            heartempty9Pos.y = playerPos.y - yChange2;
            heartempty9.transform.position = new Vector3(heartempty9Pos.x, heartempty9Pos.y, heartempty9Pos.z);

            //heart 10
            Vector3 heart10Pos = heart10.gameObject.GetComponent<Transform>().position;
            heart10Pos.x = playerPos.x + xChange10;
            heart10Pos.y = playerPos.y - yChange2;
            heart10.transform.position = new Vector3(heart10Pos.x, heart10Pos.y, heart10Pos.z);

            Vector3 heartempty10Pos = heartempty10.gameObject.GetComponent<Transform>().position;
            heartempty10Pos.x = playerPos.x + xChange10;
            heartempty10Pos.y = playerPos.y - yChange2;
            heartempty10.transform.position = new Vector3(heartempty10Pos.x, heartempty10Pos.y, heartempty10Pos.z);
        }
    }
}
