using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    int speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(Vector3.left*Time.deltaTime*speed);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
    

        if (col.collider.tag=="Enemy")
        {
            Debug.Log("Game over");
            //Destroy(this.gameObject);

        }

    }
}
