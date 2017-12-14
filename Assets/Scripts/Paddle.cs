using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public GameObject P1;

    // Update is called once per frame
    void Update () {

        float mouseY = (Input.mousePosition.y / Screen.height * 14f) - 7f;
        mouseY = Mathf.Clamp(mouseY, -4f, 4f);

        //Vector3 Saves any point in (x,y,z)
        //keeps the y position fixed
        Vector3 paddlePosition = new Vector3(-7.24f, mouseY, 0);

        //sets the position of the paddle (this) to the paddlePosition
        this.transform.position = paddlePosition;

    }
}
