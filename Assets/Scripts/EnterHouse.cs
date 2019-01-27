using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class EnterHouse : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseClick(){ SceneManager.LoadSceneAsync("House1", LoadSceneMode.Single);}
}
