using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class is attached to each Ammo object that is released
 * from the Ship Turret
 */
public class Ammo : MonoBehaviour {

    GameObject gameManager;

	//This Rigidbody2D
	Rigidbody2D ThisBody = null;

	//Speed of Ammo
	float Thrust;

    //How long each Ammo lives for
    float LifeTime;

	void OnEnable () {
		//CancelInvoke ();
	}

	/*
	 * Initialize Ammo and make it move forward
	 */
	void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
		ThisBody = GetComponent<Rigidbody2D> ();

        Thrust = gameManager.GetComponent<StatsManager>().PlayerAmmoThrust;
        LifeTime = gameManager.GetComponent<StatsManager>().PlayerAmmoLifeTime;

        ThisBody.AddForce(transform.up * Thrust);
        Invoke("Die", LifeTime);
    }

    void Update() {
        Thrust = gameManager.GetComponent<StatsManager>().PlayerAmmoThrust;
        LifeTime = gameManager.GetComponent<StatsManager>().PlayerAmmoLifeTime;
    }

    /*
	 * This method handles collisions
	 */
    void OnTriggerEnter2D (Collider2D col) {
		

	}

	/*
	 * Destroy Ammo when the lifetime is over
	 */
	void Die(){
		Destroy (gameObject);
	}

    
}
