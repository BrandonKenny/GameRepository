using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player;
    public GameObject red;

    public GameObject plainsBoss;
    public GameObject plainsDefeated;

    public GameObject snowBoss;
    public GameObject snowDefeated;

    public GameObject desertBoss;
    public GameObject desertDefeated;

    public GameObject forestBoss;
    public GameObject forestDefeated;

    public GameObject finalBoss;
    public GameObject finalDefeated;

    public GameObject bossMusic;
    public GameObject normalMusic;

    public GameObject bossWall;

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    //Player stuff
    public IEnumerator RedShow()
    {
        if (player != null)
        {
            red.gameObject.GetComponent<Transform>().position = new Vector2(player.gameObject.GetComponent<Transform>().position.x, player.gameObject.GetComponent<Transform>().position.y);
        }
        yield return new WaitForSeconds(0.1f);
        red.gameObject.GetComponent<Transform>().position = new Vector2(500f, 0f);
    }
    public void Death()
    {
        StartCoroutine(Death2());
        Destroy(player);
    }
    public IEnumerator Death2()
    {
        //player.gameObject.GetComponent<Transform>().position = new Vector3(player.gameObject.GetComponent<Transform>().position.x, player.gameObject.GetComponent<Transform>().position.y, 20f);
        StartCoroutine(RedShow());
        yield return new WaitForSeconds(1);
        LoadLevel("Lose");
    }
    
    //Plains Boss stuff
    public void PlainsDeathStart()
    {
        StartCoroutine(PlainsDeath());
        bossMusic.GetComponent<AudioSource>().Stop();
        normalMusic.GetComponent<AudioSource>().Play();
        Destroy(plainsBoss);
    }
    public IEnumerator PlainsDeath()
    {
        // FOR BUILD MODE
        plainsDefeated.gameObject.GetComponent<Transform>().position = new Vector2(840f, 965f);
        // FOR PREVIEW MODE
        //plainsDefeated.gameObject.GetComponent<Transform>().position = new Vector2(480.5f, 450.5f);
        yield return new WaitForSeconds(3.5f);
        plainsDefeated.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1500f);
    }

    //Snow Boss stuff
    public void SnowDeathStart()
    {
        StartCoroutine(SnowDeath());
        bossMusic.GetComponent<AudioSource>().Stop();
        normalMusic.GetComponent<AudioSource>().Play();
        Destroy(snowBoss);
    }
    public IEnumerator SnowDeath()
    {
        // FOR BUILD MODE
        snowDefeated.gameObject.GetComponent<Transform>().position = new Vector2(840f, 965f);
        // FOR PREVIEW MODE
        //snowDefeated.gameObject.GetComponent<Transform>().position = new Vector2(480.5f, 450.5f);
        yield return new WaitForSeconds(3.5f);
        snowDefeated.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1500f);
    }

    //Desert Boss stuff
    public void DesertDeathStart()
    {
        StartCoroutine(DesertDeath());
        bossMusic.GetComponent<AudioSource>().Stop();
        normalMusic.GetComponent<AudioSource>().Play();
        Destroy(desertBoss);
    }
    public IEnumerator DesertDeath()
    {
        // FOR BUILD MODE
        desertDefeated.gameObject.GetComponent<Transform>().position = new Vector2(840f, 965f);
        // FOR PREVIEW MODE
        //desertDefeated.gameObject.GetComponent<Transform>().position = new Vector2(480.5f, 450.5f);
        yield return new WaitForSeconds(3.5f);
        desertDefeated.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1500f);
    }

    //Forest Boss stuff
    public void ForestDeathStart()
    {
        StartCoroutine(ForestDeath());
        bossMusic.GetComponent<AudioSource>().Stop();
        normalMusic.GetComponent<AudioSource>().Play();
        Destroy(forestBoss);
    }
    public IEnumerator ForestDeath()
    {
        // FOR BUILD MODE
        forestDefeated.gameObject.GetComponent<Transform>().position = new Vector2(840f, 965f);
        // FOR PREVIEW MODE
        //forestDefeated.gameObject.GetComponent<Transform>().position = new Vector2(480.5f, 450.5f);
        yield return new WaitForSeconds(3.5f);
        forestDefeated.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1500f);
    }

    //Final Boss stuff
    public void FinalDeathStart()
    {
        StartCoroutine(FinalDeath());
        bossMusic.GetComponent<AudioSource>().Stop();
        normalMusic.GetComponent<AudioSource>().Play();
        Destroy(finalBoss);
    }
    public IEnumerator FinalDeath()
    {
        // FOR BUILD MODE
        finalDefeated.gameObject.GetComponent<Transform>().position = new Vector2(840f, 965f);
        // FOR PREVIEW MODE
        //finalDefeated.gameObject.GetComponent<Transform>().position = new Vector2(480.5f, 450.5f);
        yield return new WaitForSeconds(3.5f);
        finalDefeated.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1500f);
        LoadLevel("Outro");
    }

    //BossWall Text
    public IEnumerator BossWall()
    {
        // FOR BUILD MODE
        bossWall.gameObject.GetComponent<Transform>().position = new Vector2(840f, 965f);
        // FOR PREVIEW MODE
        //bossWall.gameObject.GetComponent<Transform>().position = new Vector2(480.5f, 450.5f);
        yield return new WaitForSeconds(3.5f);
        bossWall.gameObject.GetComponent<Transform>().position = new Vector2(0f, 1500f);
    }
}
