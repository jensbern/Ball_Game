using System.Collections;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
//För att fixa ett bättre hopp, kolla på https://www.youtube.com/watch?v=7KiK0Aqtmzc
public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;

    private int count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            Debug.Log("Pick Up");
        }
        if(other.gameObject.CompareTag("J"))
        {
            Vector3 Player_Velocity = rb.velocity;

            rb.velocity += new Vector3(0, 8, 0); 
            Debug.Log(rb.velocity);
        }
             
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 16)
        {
            winText.text = "You Win!"; 
        }
    }
}
