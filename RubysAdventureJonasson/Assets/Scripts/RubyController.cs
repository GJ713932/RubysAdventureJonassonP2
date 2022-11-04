using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create 2 variables to use the unity built in axes
        float Horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Create our movement vector
        Vector2 position = transform.position;

        //create horzantal and vertical movement 
        position.x = position.x + 3.0f * Horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        //setting the new position
        transform.position = position; 
    }
}