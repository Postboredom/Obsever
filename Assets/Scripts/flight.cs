using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight : MonoBehaviour {

    public GameObject Player;
	
	// Update is called once per frame
	void FixedUpdate () {
		
        if(Input.GetButtonDown("Jump"))
        {
            Player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 220);
        }

        if(Input.GetKey(KeyCode.A))
        {
            Player.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 10);
            Player.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(Input.GetKey(KeyCode.D))
        {
            Player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10);
            Player.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
