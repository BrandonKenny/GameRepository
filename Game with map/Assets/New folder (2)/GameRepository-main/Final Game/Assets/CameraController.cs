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
    float yChange = 6.39f;
    //BUILD MODE
    float xChange1 = 10.56f;
    float xChange2 = 9.35f;
    float xChange3 = 8.14f;
    float xChange4 = 6.93f;
    float xChange5 = 5.72f;

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
            heart1Pos.y = playerPos.y - yChange;
            heart1.transform.position = new Vector3(heart1Pos.x, heart1Pos.y, heart1Pos.z);

            Vector3 heartempty1Pos = heartempty1.gameObject.GetComponent<Transform>().position;
            heartempty1Pos.x = playerPos.x + xChange1;
            heartempty1Pos.y = playerPos.y - yChange;
            heartempty1.transform.position = new Vector3(heartempty1Pos.x, heartempty1Pos.y, heartempty1Pos.z);

            //heart 2
            Vector3 heart2Pos = heart2.gameObject.GetComponent<Transform>().position;
            heart2Pos.x = playerPos.x + xChange2;
            heart2Pos.y = playerPos.y - yChange;
            heart2.transform.position = new Vector3(heart2Pos.x, heart2Pos.y, heart2Pos.z);

            Vector3 heartempty2Pos = heartempty2.gameObject.GetComponent<Transform>().position;
            heartempty2Pos.x = playerPos.x + xChange2;
            heartempty2Pos.y = playerPos.y - yChange;
            heartempty2.transform.position = new Vector3(heartempty2Pos.x, heartempty2Pos.y, heartempty2Pos.z);

            //heart 3
            Vector3 heart3Pos = heart3.gameObject.GetComponent<Transform>().position;
            heart3Pos.x = playerPos.x + xChange3;
            heart3Pos.y = playerPos.y - yChange;
            heart3.transform.position = new Vector3(heart3Pos.x, heart3Pos.y, heart3Pos.z);

            Vector3 heartempty3Pos = heartempty3.gameObject.GetComponent<Transform>().position;
            heartempty3Pos.x = playerPos.x + xChange3;
            heartempty3Pos.y = playerPos.y - yChange;
            heartempty3.transform.position = new Vector3(heartempty3Pos.x, heartempty3Pos.y, heartempty3Pos.z);
            
            //heart 4
            Vector3 heart4Pos = heart4.gameObject.GetComponent<Transform>().position;
            heart4Pos.x = playerPos.x + xChange4;
            heart4Pos.y = playerPos.y - yChange;
            heart4.transform.position = new Vector3(heart4Pos.x, heart4Pos.y, heart4Pos.z);

            Vector3 heartempty4Pos = heartempty4.gameObject.GetComponent<Transform>().position;
            heartempty4Pos.x = playerPos.x + xChange4;
            heartempty4Pos.y = playerPos.y - yChange;
            heartempty4.transform.position = new Vector3(heartempty4Pos.x, heartempty4Pos.y, heartempty4Pos.z);

            //heart 5
            Vector3 heart5Pos = heart5.gameObject.GetComponent<Transform>().position;
            heart5Pos.x = playerPos.x + xChange5;
            heart5Pos.y = playerPos.y - yChange;
            heart5.transform.position = new Vector3(heart5Pos.x, heart5Pos.y, heart5Pos.z);

            Vector3 heartempty5Pos = heartempty5.gameObject.GetComponent<Transform>().position;
            heartempty5Pos.x = playerPos.x + xChange5;
            heartempty5Pos.y = playerPos.y - yChange;
            heartempty5.transform.position = new Vector3(heartempty5Pos.x, heartempty5Pos.y, heartempty5Pos.z);
        }
    }
}
