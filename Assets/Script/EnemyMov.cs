using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{

    public static EnemyMov insta;
    private static int speed;

    public static int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    // Vector3 pos{itionstart;
    //Vector3 positiony;
    float distx;
    float disty;
   
  
    void Start()
    {
        speed = 2;
        //positionstart = transform.position;
        
    }


    void Update()
    {
     //       distx = Vector3.Distance(positionstart, transform.position);
       //     disty= Vector3.Distance(positiony, transform.position);
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x>3f ||transform.position.x<-3f)
            {

            transform.position += Vector3.down * 0.5f;

                //transform.Translate(Vector3.down * Time.deltaTime * 20);              
                speed *= -1;
            //    positiony = transform.position;
          


        }/*else
          /*  {
            Debug.Log("ok");
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            
            }*/

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GM.gm.GameOver();
        }
    }

}
