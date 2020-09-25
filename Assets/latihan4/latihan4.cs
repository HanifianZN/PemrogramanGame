using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan4 : MonoBehaviour
{
    karakter player1;
    void Start()
    {
        player1 = new karakter();
        player1.Name   = "dico";
        player1.Health = 100;
        player1.Damage = 30;
    Debug.Log("Name: " + player1.Name + ", Health: " + player1.Health + ", Damage : " + player1.Damage);

        player1.Jump();
    }

    void Update()
    {
        
    }
}
