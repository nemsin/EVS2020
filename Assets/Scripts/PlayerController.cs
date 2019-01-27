using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animatorPlayer;
    public float speed;
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        animatorPlayer.SetFloat("Horizontal", moveHorizontal);
        animatorPlayer.SetFloat("Vertical", moveVertical);
        Vector3 movement = new Vector3(moveHorizontal, moveVertical,0.0f);
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}
