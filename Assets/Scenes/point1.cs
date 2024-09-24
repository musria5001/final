using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class point1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool peng = false;
    public float time = 5;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(peng==true)
        {
            time = time - Time.deltaTime;
        }
      if(time<=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "Player")
        {
            peng = true;
            time = 5;
      
            other.gameObject.GetComponent<get>().getpoint(1);//得分计数
            Vector2 difference1 = other.transform.position - transform.position;
            difference1.Normalize();
            other.transform.position = new Vector2(other.transform.position.x + difference1.x, other.transform.position.y + difference1.y);
            Vector2 difference2 = transform.position - other.transform.position;
            difference2.Normalize();
            transform.position = new Vector2(transform.position.x + difference2.x, transform.position.y + difference2.y);
         
        }

    
        if (other.gameObject.tag == "point0")
        {
            peng=true;
        }
            if (other.gameObject.tag == "qiang")
        {
            Destroy(gameObject);
        }
    }
}      
