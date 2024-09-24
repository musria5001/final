using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qiang : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "point1"|| other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<get>().getpoint(-5);//得分计数
            Destroy(other.gameObject);
        }
    }
}
