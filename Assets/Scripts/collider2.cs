using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider2 : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
        if (PlayerPrefs.GetInt("score2") == 0)
        {
            PlayerPrefs.SetInt("score2", 1);
        }
        else
        {
            int temp = PlayerPrefs.GetInt("score2");
            PlayerPrefs.SetInt("score2", temp + 1);
        }
    }
}
