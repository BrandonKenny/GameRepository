using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = new Vector3(this.transform.position.x, this.transform.position.y);
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mouseScreenPosition);

        mousePos = mouseScreenPosition;
        this.transform.position = mousePos;
        //mousePos.x = Mathf.Clamp(mousePosInBlocksX, 0.5f, 15.5f);
        //this.transform.position = mousePos;
    }
}
