using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform firepoint;
    int speed;
    public GameObject bulletprefab;
    float rand;
    GameObject clone;
    // Start is called before the first frame update
    float firerate = 0.999f;
    GameObject bullet;
    float time=5;
    private void OnEnable()
    {
        speed = 5;

    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        


            if (this.gameObject.tag != "Enemy")
            {
            if (time < 0)
            {
                Shoot();
                time = 5;
            }
            }
        
        else
        {


            if (Random.value > firerate)
            {



                Shoot();


            }
        }
    }
        void Shoot()
        {
        if (PauseUI.gameIsPaused == false || GM.gm.isdead==false)
        {

            clone = Instantiate(bulletprefab, firepoint.position, Quaternion.Euler(new Vector3(0, 0, -180)));
        }
        }

    
}
