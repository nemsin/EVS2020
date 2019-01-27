using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryFiller : MonoBehaviour
{
    private GameController gameController;
    private GameObject gameControllerObject;
    private static int inventorySize = 5;
    // Start is called before the first frame update
    private Image[] imageList = new Image[inventorySize];
    void Start()
    {
        this.gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        this.gameController = gameControllerObject.GetComponent<GameController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = inventorySize; i <inventorySize; i++)
        {
            imageList[i] = this.gameController.GetComponent<Image>();
        }
    }
}
