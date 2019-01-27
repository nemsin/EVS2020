using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Text timeText;
    public float timer = 30;
    public int itemNumber = 2;
    public int collected = 0;

    private void Start()
    {
        StartCoroutine("TimerCountdown");
    }

    IEnumerator TimerCountdown()
    {
        for (float i = timer; i > 0 ; i -= 1 )
        {
            timer--;
            yield return new WaitForSeconds(1f);
            }
    }
    private void Update()
    {
       
        //timer -= Time.deltaTime;
        timeText.text = "Time: " + timer;
        if (itemNumber == 0 || timer <= 0)
        {
            SceneManager.LoadSceneAsync(1);
        }
        
    }   
}
