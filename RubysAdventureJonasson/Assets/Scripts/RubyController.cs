using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 20.0f;


    public int maxHealth = 5;
    public float timeInvincible = 2.0f;

    public int health { get { return currentHealth; }}
    public int currentHealth;


    bool isInvincible;
    float invincibleTImer;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Create 2 variables to use the unity built in axes
        float Horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (isInvincible)
        {
            invincibleTImer -= Time.deltaTime;
            if (invincibleTImer < 0)
                isInvincible = false;
        }
    }
        void FixedUpdate()
        {
            //Create our movement vector
            Vector2 position = rigidbody2d.position;

            //create horzantal and vertical movement 
            position.x = position.x + 20.0f * horizontal * Time.deltaTime;
            position.y = position.y + 20.0f * vertical * Time.deltaTime;
            //setting the new position

            rigidbody2d.MovePosition(position);
        }


    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {

            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTImer = timeInvincible;
        }


        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}