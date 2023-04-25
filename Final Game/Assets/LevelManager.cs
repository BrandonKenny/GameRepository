using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player;
    public GameObject red;

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public IEnumerator RedShow()
    {
        if (player != null)
        {
            red.gameObject.GetComponent<Transform>().position = new Vector2(player.gameObject.GetComponent<Transform>().position.x, player.gameObject.GetComponent<Transform>().position.y);
        }
        yield return new WaitForSeconds(0.1f);
        red.gameObject.GetComponent<Transform>().position = new Vector2(500f, 0f);
    }
    public IEnumerator Death()
    {
        player.gameObject.GetComponent<Transform>().position = new Vector3(player.gameObject.GetComponent<Transform>().position.x, player.gameObject.GetComponent<Transform>().position.y, 20f);
        StartCoroutine(RedShow());
        yield return new WaitForSeconds(1);
        LoadLevel("Lose");
    }
}
