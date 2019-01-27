using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemTrigger : MonoBehaviour
{
    public ItemController instance;
    public GameObject other;
    bool destroy = false;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        instance.itemNumber--;
        instance.collected++;
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
            Destroy(other);
        }
    }
}
