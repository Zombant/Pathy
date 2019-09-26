using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    float Speed;

    //Reference to components
    Transform ThisTransform;

    //Reference to GameManager
    GameObject gameManager;

    // Use this for initialization
    void Start () {
        ThisTransform = GetComponent<Transform>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        Speed = gameManager.GetComponent<StatsManager>().PlayerSpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Speed != gameManager.GetComponent<StatsManager>().PlayerSpeed)
        { Speed = gameManager.GetComponent<StatsManager>().PlayerSpeed; }

        if ((Mathf.Abs(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - ThisTransform.position.x) <= .2) && 
           (Mathf.Abs(Camera.main.ScreenToWorldPoint(Input.mousePosition).y - ThisTransform.position.y) <= .2)) {
            //Do nothing
        }
        else {
            ThisTransform.Translate(new Vector3(0, Speed * Time.deltaTime, 0));
        }
	}
}
