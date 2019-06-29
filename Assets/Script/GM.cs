using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
   
    [SerializeField]
    private GameObject gameoverUI;

    public static GM gm;
    [HideInInspector]
    public bool isdead = false;
   static int sum=0;
    // Start is called before the first frame update
    private void Awake()
    {
    }
    void Start()
    {

       
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (sum == 14)
        {
            Debug.Log("Level completed");
            GameOver();
                }
    }
    public static void Killenemy(GameObject en)
    {
        sum++;
        Destroy(en);
    }
    public  void GameOver()
    {
         gameoverUI.SetActive(true);
        isdead = true;
       // Time.timeScale = 0;
    }
}
