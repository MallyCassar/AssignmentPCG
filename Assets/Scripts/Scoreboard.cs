using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

    public static Scoreboard instance;

    public Text score1Text;
    public Text score2Text;

    public int score1;
    public int score2;

	// Use this for initialization
	void Start () {
        instance = this;

        score1 = score2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Scorep1()
    {
        score1 += 1;
        score1Text.text = score1.ToString();

        if (score1 == 5)
        {
            SceneManager.LoadScene("Level2");
        }

        if (score1 == 10)
        {
            SceneManager.LoadScene("Level3");
        }

    }

    public void Scorep2()
    {
        score2 += 1;
        score2Text.text = score1.ToString();

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
