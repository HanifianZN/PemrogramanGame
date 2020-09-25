using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan6 : MonoBehaviour
{
    public int[] intarray;
    void Start()
    {
       
        Debug.Log("menampilkan seluruh Array");
        foreach(int a in intarray)
        {
            Debug.Log(a);
        }
        Debug.Log("Nilai index ke 2 adalah" + intarray[2]);
    }

    void Update()
    {
        
    }
}
