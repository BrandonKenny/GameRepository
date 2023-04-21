using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public GameObject canvas;
    public void ControlsMenu()
    {
        canvas.GetComponent<RectTransform>().position = new Vector2(3000f, 0f);
    }
}
