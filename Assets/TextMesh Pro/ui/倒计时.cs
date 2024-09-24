using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class 倒计时 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI _textMeshPro_text;
    public float time = 40;
    private float tm;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        string tm = time.ToString("0.00"); 
        _textMeshPro_text.text = "Time:" + tm;
        if (time <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
