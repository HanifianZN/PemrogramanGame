using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter{

    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }

        }

        public int Damage
        {
            get
            {
            return damage;
            }
            set
            {
            damage = value;
        }
    }
    
    public void MoveLeft()
    {
        Debug.Log("gerak ke kiri");
    }
    public void MoveRight()
    {
        Debug.Log("gerak ke kanan");
    }
    public void Jump()
    {
        Debug.Log("loncat");
    }
    public void Attack()
    {
        Debug.Log("serang");
    }
}
