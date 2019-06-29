using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMov : MonoBehaviour
{

    public Transform point1ofreturn;
    int speed=2;
    Vector3 positionstart;
    float distx;
    Vector3 df2;
   
    //float lerpValue = 0;
    float time=15;
    float time2 = 25;
    // Start is called before the first frame update
    void Start()
    {
       
        df2 = new Vector3(0 ,4, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
     
        
           
       
        

        distx = Vector3.Distance(df2, transform.position);
        if (distx > 8)
        {
            speed*=-1;
        }


        if (time2 > 0)
        {


            time2 -= Time.deltaTime;

            if (transform.position.y <= 4)
            {


                transform.Translate(Vector3.left * speed * Time.deltaTime);


            }
            else
            {

                time -= Time.deltaTime;
                if (time < 0)
                {
                    transform.position = Vector3.MoveTowards(transform.position, df2, 2 * Time.deltaTime);
                }
                //  StartCoroutine(waittoMove(8));

            }

        }
        else
        {


            transform.position = Vector3.MoveTowards(transform.position, point1ofreturn.position, 2 * Time.deltaTime);
        }
        // 
        /*if (lerpValue < 1)
        {
            
            lerpValue += Time.deltaTime / movementTime;
            transform.position = Vector3.Lerp(df, df2, lerpValue);
        }
        else
        {
          
                lerpValue = 0;
            
            
        }*/
    }
    IEnumerator waittoMove(float delayTime)
    {
        Debug.Log("here3");
        yield return new WaitForSeconds(delayTime);
        
       
       
    }
}
