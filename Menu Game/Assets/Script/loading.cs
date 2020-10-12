using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    [SerializeField]
    private float DelayLoading = 3f;

    [SerializeField]
    private string NamaScene;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > DelayLoading)
        {
            SceneManager.LoadScene(NamaScene);
        }
    }
}


