using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCalculator : MonoBehaviour
{
    public GameObject player;
    public GameObject attackCenter;
    public GameObject attackOrigin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = new Vector3(this.transform.position.x, this.transform.position.y);
        Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePos = mouseScreenPosition;
        this.transform.position = mousePos;

        var dir = mousePos - playerPos;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        attackCenter.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
