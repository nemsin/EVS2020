using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryFiller : MonoBehaviour
{
    private GameController gameController;
    private GameObject gameControllerObject;
    // Start is called before the first frame update
    private Image[] imageList = new Image[5];
    void Start()
    {
        this.gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for ()
        {

        }
    }
}
