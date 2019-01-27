using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryFiller : MonoBehaviour
{
    private GameController gameController;
    private GameObject gameControllerObject;
    private int inventorySize = 0;
    // Start is called before the first frame update
    private List<Image> imageList = new List<Image>();
    void Start()
    {
        this.gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        this.gameController = gameControllerObject.GetComponent<GameController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (inventorySize != this.gameController.Inventory.Count)
        {
            inventorySize = this.gameController.Inventory.Count;

            for (int i = 0; i < inventorySize; i++)
            {
                imageList.Add(this.gameController
                    .Inventory[i]
                    .GetComponent<Image>());
            }
        }
        */
    }
}
