﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemTrigger : MonoBehaviour
{
    public ItemController itemController;

    private GameController gameController;
    private GameObject gameControllerObject;

    bool destroy = false;

    private void Start()
    {
        this.gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();

        this.itemController = this.gameObject.GetComponentInParent<ItemController>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        itemController.itemNumber--;
        //itemController.collected++;
        destroy = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(destroy == true)
        {
            if(gameController.Inventory.Count < 5)
            {
                GameObject instance = GameObject.Instantiate(gameObject);
                instance.gameObject.SetActive(false);
                gameController.Inventory.Add(instance);
                DontDestroyOnLoad(instance);
            }
            else
            {
                Debug.Log("Zu viele Klopapiere!!!");
            }

            Destroy(this.gameObject);
        }
    }
}
