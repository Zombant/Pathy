using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("destroy", 3f);
	}
	
    void destroy() {
        Destroy(gameObject);
    }
	
}
