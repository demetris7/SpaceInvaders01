using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseUI : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject gamepauseui;
    // Start is called before the first frame update
    void Start()
    {
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
   public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
   public void Resume()
    {
        gamepauseui.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
   public void Pause()
    {
        gamepauseui.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
