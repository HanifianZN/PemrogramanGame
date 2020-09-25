using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prajurit : manusia
{    
    void Start()
    {
        Debug.Log("seorang prajurit dapat :");
            Makan();
            Tidur();
            Menyerang();
    }
    void Update()
    {
        
    }

    void Menyerang()
    {
        Debug.Log("Menyerang");
    }
}
