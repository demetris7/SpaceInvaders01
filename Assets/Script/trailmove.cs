using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailmove : MonoBehaviour
{
    int speed = 4;
    Enemy en;
    
    private void Start()
    {
        en = new Enemy();
    }
    void Update()
    {

        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Boundaries")
        {
            if (gameObject.tag == "trail")
            {
                gameObject.SetActive(false);
            }
            

        }
        else if(collision.tag=="Enemy")
        {
          //  Destroy(collision.gameObject);
            en.DamageEnemy(Bulletmov.Dmg,collision.gameObject);
        }
        else if(collision.tag=="Boss")
        {
            en.DamageEnemy(50, collision.gameObject);
        }
    }
}
