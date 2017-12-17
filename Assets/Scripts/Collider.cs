using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with" + collision.gameObject.name);

        if (PlayerPrefs.GetInt("score1") == 0)
        {
            PlayerPrefs.SetInt("score1", 1);
        }
        else
        {
            int temp = PlayerPrefs.GetInt("score1");
            PlayerPrefs.SetInt("score1", temp+1);
        }
    }
}
