using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class point5 : MonoBehaviour
{
    public bool canpeng;
    public float time=4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (canpeng==false&&time<=4)
        {
            time = time + Time.deltaTime;
        }
      if(time>=4)
        {
            canpeng=true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "Player"&&canpeng==true)
        {
            canpeng = false;
            time = 0;
   
            Vector2 difference1 = other.transform.position - transform.position;
            difference1.Normalize();
            other.transform.position = new Vector2(other.transform.position.x + difference1.x, other.transform.position.y + difference1.y);
            Vector2 difference2 = transform.position - other.transform.position;
            difference2.Normalize();
            transform.position = new Vector2(transform.position.x + difference2.x * 2, transform.position.y + difference2.y * 2);
            other.gameObject.GetComponent<get>().getpoint(5);

        }
        if (other.gameObject.tag == "qiang" )
        {
            Destroy(gameObject);
        }
        
    }
   
}      
