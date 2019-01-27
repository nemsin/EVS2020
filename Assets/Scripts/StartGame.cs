using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject Controller;


    public void LoadWorldMap()
    {
        DontDestroyOnLoad(Controller);

        SceneManager.LoadSceneAsync(0);
    }
}

