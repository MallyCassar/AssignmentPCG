using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {


   // public GameObject Right;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (this.transform.position.y <= -4f || this.transform.position.y >= 4f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
        }

        

        // P2 Up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Player 2 is pressing Up Arrow");
            Mathf.Clamp(GetComponent<Transform>().position.y, -4f, 4f);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 4f, 0f);
        }

        //P2 Down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Player 2 is pressing Down Arrow");
            //Mathf.Clamp(0, -4f, 4F);
            //Mathf.Clamp(Right.GetComponent<Transform>().position.y, -4f, 4f);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -4f, 0f);
            
        }

        
    }
}
