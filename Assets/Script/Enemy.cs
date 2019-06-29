using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

   private int health;
    public int Health{

            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamageEnemy(int damage,GameObject enemyobj)
    {
        health = health - damage;
        if (health <= 0)
        {
            GM.Killenemy(enemyobj.gameObject);
        }
    }
    
    
}
