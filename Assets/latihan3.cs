using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan3 : MonoBehaviour

{ 
    // Start is called before the first frame update
    void Start()
    {
        int c = jumlah (60 , 40);
        Debug.Log("hasil jumlah a dan b adalah " + c);
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// mrupakan fungsi penjumalahan dari 2 input angka
    /// </summary>
    /// <param name="a">Masukkan Angka Integer</param>
    /// <param name="b">Masukkan Angka Integer</param>
    /// <returns></returns>
    int jumlah (int a, int b)
    {
    return a + b;
    }
}
