using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemController : MonoBehaviour
{
    public int itemNumber = 1;
    public int collected = 0;
    private void Update()
    {
        if (itemNumber == 0)
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
