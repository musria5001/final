using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class point3 : MonoBehaviour
{
    private float speed=4f;
    private Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       followplayer(); 
    }
   private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "Player")
        {
         
 
            Vector2 difference1 = other.transform.position - transform.position;
            difference1.Normalize();
            other.transform.position = new Vector2(other.transform.position.x + difference1.x * 3, other.transform.position.y + difference1.y * 3);
            Vector2 difference2 = transform.position - other.transform.position;
            difference2.Normalize();
            transform.position = new Vector2(transform.position.x + difference2.x * 2, transform.position.y + difference2.y * 2);
            other.gameObject.GetComponent<get>().getpoint(-3);//得分计数
        }
        if (other.gameObject.tag == "point1")
        {
            Vector2 difference1 = other.transform.position - transform.position;
            difference1.Normalize();
            other.transform.position = new Vector2(other.transform.position.x + difference1.x, other.transform.position.y + difference1.y);
            Vector2 difference2 = transform.position - other.transform.position;
            difference2.Normalize();
            transform.position = new Vector2(transform.position.x + difference2.x, transform.position.y + difference2.y);
        }
    }
  
    private void followplayer()
    {
        transform.position =Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
    }
}      
