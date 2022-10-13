using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InitializeScene : ObjectModel
{
    bool isSceneLoading;

    private void Update()
    {
        if (isSceneLoading == false)
        {
            isSceneLoading = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}