using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    
    private void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Escape) && panel.activeSelf == true)
        {
            panel.SetActive(false);
            Debug.Log(panel.activeSelf);
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && panel.activeSelf == false)
        {
            panel.SetActive(true);
            Debug.Log(panel.activeSelf);
        }
    }
}
