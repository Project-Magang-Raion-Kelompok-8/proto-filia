using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_walk : MonoBehaviour {

    public float moveSpeed = 10f;
    public float distance;
    private bool movingLeft = true;
    public Transform groundDetection;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left*moveSpeed*Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);


        if (groundInfo.collider == false)
        {
            if(movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }
        }
	}
}
