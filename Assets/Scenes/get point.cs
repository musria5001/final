using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
public class get : MonoBehaviour
{
    public int point;
    private ceshi ceshi;
    private void Start()
    {
        point = 0;
        ceshi = GameObject.Find("����").GetComponent<ceshi>();
    }
    // Start is called before the first frame update
    public void  getpoint(int add)//�÷�
    {
        point  = point + add;
        ceshi.point = point;
    }
}
