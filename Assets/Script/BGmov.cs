using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmov : MonoBehaviour
{
    Renderer m_Renderer;
    private int yoffset = -10;
    Camera cm;
    bool tileinstatiated = false;
    GameObject clone;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {

        m_Renderer = GetComponent<Renderer>();
        cm = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime*4f);
        

        Vector3 viewPos = cm.WorldToViewportPoint(transform.position);
        if (viewPos.y < 0 && tileinstatiated==false)
        {
           clone= Instantiate(prefab, new Vector3(0, 15f, 0), Quaternion.identity);
            clone.name="background";
            tileinstatiated = true;
        }
      
        if (transform.position.y == 0.08f)
        {
            Instantiate(this.gameObject, new Vector3(0, 20, 0), Quaternion.identity);
            Debug.Log("ok");
        }
       
    else if(transform.position.y<yoffset)
        {
            Destroy(this.gameObject);
        }
        

    }
  

}
