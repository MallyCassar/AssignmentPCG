using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour {


    private Paddle myPaddle;
    Rigidbody2D create;
    float randomX, randomY;
    int score1;
    int score2;
    public Text score1text;
    public Text score2text;
    private Vector3 paddleToBallVector;

    bool hasStarted = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);

        //creating a Vector2 tweak with a random X and random Y
        Vector2 tweak = new Vector2(randomX, randomY);

        if (hasStarted)
        {
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
    // Use this for initialization
    void Start () {

        create = GetComponent<Rigidbody2D>();

        //searches for Object of Type Paddle in and assigns it to myPaddle
        myPaddle = GameObject.FindObjectOfType<Paddle>();


        //saves the distance between the ball and the paddle
        paddleToBallVector = this.transform.position - myPaddle.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted)  //if (hasStarted == false)
        {
            //lock the ball with the paddle
            this.transform.position = myPaddle.transform.position + paddleToBallVector;
            
            // if left click is pressed
            if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("Left Click");
                hasStarted = true;

                //set the velocity of the ball to 2 x and 10 y
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }

        if (transform.position.x < -25f)
        {


            transform.position = Vector3.zero;
            create.velocity = Vector3.zero;

            Scoreboard.instance.Scorep2();

            StartCoroutine(Pause());

        }

        if (transform.position.x < 25f)
        {


            transform.position = Vector3.zero;
            create.velocity = Vector3.zero;

            Scoreboard.instance.Scorep1();

            StartCoroutine(Pause());

        }


    }


    private IEnumerator Pause()
    {
        throw new NotImplementedException();
    }


}

    


