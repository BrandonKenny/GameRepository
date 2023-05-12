using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertBoss : MonoBehaviour
{
    public GameObject player;
    private bool isInPlayerRange = false;
    public LayerMask playerLayer;
    private float playerRange = 7;
    public int desertBossHealth = 40;
    public Animator animator;
    public GameObject projectilePrefab;
    private bool hasStarted = false;
    public LevelManager levelManager;

    public Transform attackOrigin;
    public Transform attack;

    public GameObject bossMusic;
    public GameObject normalMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isInPlayerRange = Physics2D.OverlapCircle(this.gameObject.GetComponent<Transform>().position, playerRange, playerLayer);
        if (isInPlayerRange && !hasStarted)
        {
            StartCoroutine(DesertBossfight());
            bossMusic.GetComponent<AudioSource>().Play();
            normalMusic.GetComponent<AudioSource>().Stop();
            hasStarted = true;
            //Debug.Log("In Range");
        }
        else
        {
            //Debug.Log("No");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Debug.Log("Collide with walls");
        }
        else
        {
            desertBossHealth--;
            if (desertBossHealth <= 0)
            {
                levelManager.DesertDeathStart();
            }
        }
    }

    IEnumerator DesertBossfight()
    {
        if (!hasStarted)
        {
            yield return new WaitForSeconds(2);
            while (this != null)
            {
                StartCoroutine(VerticalSpam());
                animator.SetInteger("DesertState", 1);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 0f);
                yield return new WaitForSeconds(2);
                animator.SetInteger("DesertState", 0);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
                yield return new WaitForSeconds(1);
                StartCoroutine(CircleAttack());
                animator.SetInteger("DesertState", 2);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-3f, -3f);
                yield return new WaitForSeconds(2);
                animator.SetInteger("DesertState", 0);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
                yield return new WaitForSeconds(1);
                StartCoroutine(DiagonalSpam());
                animator.SetInteger("DesertState", 2);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-3f, 3f);
                yield return new WaitForSeconds(2);
                animator.SetInteger("DesertState", 0);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
                yield return new WaitForSeconds(1);
                StartCoroutine(SpikeAttack());
                animator.SetInteger("DesertState", 4);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -3f);
                yield return new WaitForSeconds(2);
                animator.SetInteger("DesertState", 0);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
                yield return new WaitForSeconds(1);
                StartCoroutine(DoubleCircle());
                animator.SetInteger("DesertState", 1);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 3f);
                yield return new WaitForSeconds(2);
                animator.SetInteger("DesertState", 0);
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
                //this.gameObject.GetComponent<Transform>().position = new Vector2(0f, 0f);
                yield return new WaitForSeconds(1);
            }
        }
    }

    IEnumerator CircleAttack()
    {
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 22.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 67.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 112.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 135f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 157.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 180f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 202.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 247.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 292.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 315f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 337.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    IEnumerator DoubleCircle()
    {
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 180f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 22.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 202.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 67.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 247.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 112.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 292.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 135f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 315f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 157.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 337.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 180f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 22.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 202.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 67.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 247.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 112.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 292.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 135f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 315f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.125f);
        attack.rotation = Quaternion.Euler(0f, 0f, 157.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 337.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    IEnumerator SpikeAttack()
    {
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 135f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 180f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 315f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        attack.rotation = Quaternion.Euler(0f, 0f, 22.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 67.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 112.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 157.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 202.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 247.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 292.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 337.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 135f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 180f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 315f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        attack.rotation = Quaternion.Euler(0f, 0f, 22.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 67.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 112.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 157.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 202.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 247.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 292.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 337.5f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    IEnumerator DiagonalSpam()
    {
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 45f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 225f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    IEnumerator VerticalSpam()
    {
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        yield return new WaitForSeconds(0.25f);
        attack.rotation = Quaternion.Euler(0f, 0f, 270f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(projectilePrefab, attackOrigin.position, attack.rotation);
        attack.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
