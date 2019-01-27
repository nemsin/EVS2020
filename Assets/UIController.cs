using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private GameController gameController;
    private GameObject gameControllerObject;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
        float pennys = gameController.Money;
        scoreText.text = "Money: " + pennys;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
