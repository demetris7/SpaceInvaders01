using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailmov2 : MonoBehaviour
{
    int speed = 3;
    GM gm;
  
    private void Start()
    {
 
        gm = FindObjectOfType(typeof(GM)) as GM;

            }
    void Update()
    {


        transform.Translate(Vector3.up* Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Boundaries")
        {
            Destroy(this.gameObject);

        }
        else if(collision.tag=="Player")
        {
            EnemyMov.Speed = 0;
          
          //  EnemyMov.insta.Speed = 0;
            // Debug.Log("hey");
            gm.GameOver();
            //GameOVER();

          //  GM.GameOver();
        }
       
       
    }
}
