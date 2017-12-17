using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftcolscore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
            PlayerPrefs.SetInt("rightscore", PlayerPrefs.GetInt("rightscore") + 1);
    }
}
