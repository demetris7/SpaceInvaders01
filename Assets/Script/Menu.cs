using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    int a = 1;
    int b = 3;
   public void Play()
    {
        int res = Random.Range(a, b);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + (res));
    }
    public void Quit()
    {
        Application.Quit();
    }
}
