using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float moveH, moveV;
    private float addspeed = 0f;
    [SerializeField] private float inspeed = 5f;
    public float movespeed;
    public float 体力 = 4;
    public bool timeuse;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        speedchange();
        if (timeuse == true)
        {
            体力 = 体力 - Time.deltaTime;
        }
        else if (timeuse == false && 体力 <= 4)
        {
            体力 = 体力 + Time.deltaTime;
        }
        if (体力 <= 0)
        {
            addspeed = 0f;
            timeuse = false;
        }
        movespeed = inspeed + addspeed;
        moveH = Input.GetAxis("Horizontal") * movespeed;
        moveV = Input.GetAxis("Vertical") * movespeed;

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV);
    }

    void speedchange()
    {
        if (Input.GetKeyDown("c") && addspeed == 0f && 体力 >= 1)
        {
            addspeed = 3f;
            timeuse = true;
        }

        else if (Input.GetKeyDown("c") && addspeed == 3f)
        {
            addspeed = 0f;
            timeuse = false;

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "qiang")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(gameObject);
        }


    }
}

