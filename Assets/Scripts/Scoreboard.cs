using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

    public static Scoreboard instance;

    public Text score1Text;
    public Text score2Text;

    public int score1 = 0;
    public int score2 = 0;

	// Use this for initialization
	void Start () {
        instance = this;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("score1") == 5 || PlayerPrefs.GetInt("score2") == 5)
        {
            SceneManager.LoadScene("level2");
        }

        if (PlayerPrefs.GetInt("score1") == 10 || PlayerPrefs.GetInt("score2") == 10)
        {
            SceneManager.LoadScene("level3");
        }

    }

    //OnGUI is used to only runs once but keeps update functuality.
    void OnGUI() {
        score1Text.text = PlayerPrefs.GetInt("score1").ToString();
        score2Text.text = PlayerPrefs.GetInt("score2").ToString();
    }

    void OnApplicationClose()
    {
        PlayerPrefs.SetInt("score1", 0);
        PlayerPrefs.SetInt("score2", 0);
    }
}
