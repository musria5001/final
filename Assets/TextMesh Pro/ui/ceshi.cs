using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ceshi : MonoBehaviour
{
    public int point;
    public static int pt;
    public TextMeshProUGUI _textMeshPro_text;

    // Start is called before the first frame update
    void Start()
    {
        pt = 0;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        pt = point;
        _textMeshPro_text.text = "Point:" + point;

    }
}
