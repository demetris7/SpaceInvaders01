using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bulletmov : MonoBehaviour
{
    public Transform firepoint;
    int speed;
    public GameObject bulletprefab;
    private float firerate=2;
    private float timeTofire=0;
    [HideInInspector]
    public static int Dmg=100;
        // Start is called before the first frame update
       GameObject bullet;

    private void OnEnable()
    {
        speed = 10;

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time>timeTofire)
        {
            timeTofire = Time.time + 1 / firerate;
            Shoot();
           
        }

    }
    void Shoot()
    {
        bullet = ObjectPooling.instance.GetPooledObjs();
        if (bullet != null)
        {
            bullet.transform.position = firepoint.position;
            bullet.transform.rotation = Quaternion.identity;
            bullet.SetActive(true);
        }
        //clone = Instantiate(bulletprefab, firepoint.position, Quaternion.identity);
    }
  
}
