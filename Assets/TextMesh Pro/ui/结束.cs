using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class 结束 : MonoBehaviour
{
    public int point;
    public TextMeshProUGUI _textMeshPro_text;

    // Start is called before the first frame update
    void Start()
    {
        point = ceshi.pt;
        _textMeshPro_text.text = "Game Over Your Point:" + point; 

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
