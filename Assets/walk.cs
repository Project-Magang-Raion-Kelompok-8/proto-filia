using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    public float speed = 50f;
    public float jumpUp = 20f;
    public Rigidbody2D rb;
    public bool onGround;
    public bool facingRight=false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (facingRight == true)
            {
                changeDirection();
            }
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (facingRight == false)
            {
                changeDirection();
            }
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
           
        }
        if (Input.GetKeyDown(KeyCode.W) && onGround)
        {
            rb.AddForce(Vector3.up * jumpUp, ForceMode2D.Impulse);
        }
    }

    void changeDirection()
    {
        facingRight = !facingRight;
        Vector3 playerDr = gameObject.transform.localScale;
        playerDr.x *= -1;
        transform.localScale = playerDr;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        onGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }




}
