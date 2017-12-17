using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;

    //To reset ball
    public GameObject ballpref;
    public Transform paddleobject;

    private GameObject ball;
    private int score;



    // Update is called once per frame
    void Update()
    {

        ball = GameObject.FindGameObjectWithTag("ball");

        scoreText.text = "" + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score += 1;
            Destroy(ball);
            (Instantiate(ballpref, new Vector3(paddleobject.transform.position.x + 7, paddleobject.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleobject;
        }    
    }
}
