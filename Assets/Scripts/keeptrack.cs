using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keeptrack : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.GetInt("rightscore") >= 5 || PlayerPrefs.GetInt("leftscore") >= 5)
            SceneManager.LoadScene(2);

        if (PlayerPrefs.GetInt("rightscore") >= 7 || PlayerPrefs.GetInt("leftscore") >= 7)
            SceneManager.LoadScene(3);

        if (PlayerPrefs.GetInt("rightscore") >= 10 || PlayerPrefs.GetInt("leftscore") >= 10)
            SceneManager.LoadScene(4);
    }
}
