using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        Debug.Log("waktu untuk fixed update :" + Time.deltaTime);
    }

    private void Update()
    {
        Debug.Log("waktu untuk update :" + Time.deltaTime);
    }

    void lateupdate()
    {
        Debug.Log("waktu untuk lateupdate :" + Time.deltaTime);
    }
}