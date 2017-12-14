using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour {


    private Paddle myPaddle;

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
        
       
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left")
        {
            UpdateScore1();
            
            if(score1 == 5)
            {
                SceneManager.LoadScene("Level2");
            }

            if(score1 == 10)
            {
                SceneManager.LoadScene("Level3");
            }
        }

        if (collision.gameObject.name == "Right")
        {
            UpdateScore2();

            if (score2 == 5)
            {
                SceneManager.LoadScene("Level2");
            }

            if (score2 == 10)
            {
                SceneManager.LoadScene("Level3");
            }
        }


    }

    void UpdateScore1()
    {
        score1 += 1;

        score1text.text = score1.ToString();

    }

    void UpdateScore2()
    {
        score2 += 1;
        score2text.text = score2.ToString();
    }


}
