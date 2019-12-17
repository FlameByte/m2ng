using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpSpeedY;
    public float speedX;

    bool facingRight, Jumping;
    float speed;

 




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //player movement
        MovePlayer(speed);

        //vasakule liikumine
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = -speedX;
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speed = 0;
        }

        //paremale liikumine
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = speedX;
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            speed = 0;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
        }

    }
    // code for player movement
    void MovePlayer(float playerSpeed)
    {
        rb.velocity = new Vector3(speed, rb.velocity.y,0);
    }



    public void WalkLeft(){
        speed = -speedX;
    }

    public void WalkRight(){
        speed = speedX;
    }

    public void StopMoving(){
        speed = 0; 
    }
    public void Jump(){
        rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
    }

    



}
