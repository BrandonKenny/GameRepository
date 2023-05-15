using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCalculator : MonoBehaviour
{
    public Transform target;
    private GameObject target2;
    public float hideDistance = 9f;
    public GameObject arrow;
    private SpriteRenderer sprite;
    private bool isInRange = false;
    public LayerMask enemy;

    public GameObject plains;
    public GameObject snow;
    public GameObject forest;
    public GameObject desert;
    public GameObject michael;

    // Start is called before the first frame update
    void Start()
    {
        sprite = arrow.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            var dir = target.position - this.transform.position;
        
            isInRange = Physics2D.OverlapCircle(transform.position, hideDistance, enemy);
            if (isInRange)
            {
                //Debug.Log("E");
                sprite.enabled = false;
            }
            else
            {
                sprite.enabled = true;
            }
        
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        if (target == null && snow != null)
        {
            //target2 = GameObject.Find("Snow_Boss");
            target = snow.GetComponent<Transform>();
        }
        if (target == null && snow == null && forest != null)
        {
            //target2 = GameObject.Find("Forest_Boss");
            target = forest.GetComponent<Transform>();
        }
        if (target == null && snow == null && forest == null && desert != null)
        {
            //target2 = GameObject.Find("Desert_Boss");
            target = desert.GetComponent<Transform>();
        }
        if (target == null && snow == null && forest == null && desert == null && michael != null)
        {
            //target2 = GameObject.Find("Michael");
            target = michael.GetComponent<Transform>();
        }
    }
}
