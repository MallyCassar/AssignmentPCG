using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightscore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
            PlayerPrefs.SetInt("leftscore", PlayerPrefs.GetInt("leftscore") + 1);
    }
}
