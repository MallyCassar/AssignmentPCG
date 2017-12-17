using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updatescores : MonoBehaviour
{
    public Text leftscore;
    public Text rightscore;

    void OnGUI() {
        leftscore.text = "Score : " + PlayerPrefs.GetInt("rightscore").ToString();
        rightscore.text = "Score : " + PlayerPrefs.GetInt("leftscore").ToString();
    }

}
