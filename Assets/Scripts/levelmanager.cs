using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour {

	public void LoadLevel(string levelname)
    {
        print("Loading level" + levelname);
        //loads the scene named levelname
        SceneManager.LoadScene(levelname);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public void BrickDestroyed()
    {
        //if the brick is the last one to be destroyed
        if (brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }*/
    public void QuitGame()
    {

        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }

}
