using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour {

    //Reference to components
    Transform ThisTransform;

	// Use this for initialization
	void Start () {
        ThisTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - ThisTransform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        //if (!(Mathf.Abs(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - ThisTransform.position.x) <= .2) &&
        //    !(Mathf.Abs(Camera.main.ScreenToWorldPoint(Input.mousePosition).y - ThisTransform.position.y) <= .2)) {
            ThisTransform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        //}

    }
}
