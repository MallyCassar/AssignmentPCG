using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingobstacle : MonoBehaviour {

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nexPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform smallTrans;

    [SerializeField]
    private Transform transB;



	// Use this for initialization
	void Start () {
        //Gets Current position
        posA = smallTrans.localPosition;

        //Pos b is the empty created and moved to target position
        posB = transB.localPosition;
        nexPos = posB;
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}

    //Move Function
    private void move() {
        smallTrans.localPosition = Vector3.MoveTowards(smallTrans.localPosition, nexPos, speed * Time.deltaTime);

        if(Vector3.Distance(smallTrans.localPosition,nexPos) <= 0.1)
        {
            newDes();
        }
    }

    private void newDes()
    {
        //If not equal to A it will use pos B
        nexPos = nexPos != posA ? posA : posB;
    }
  
}
