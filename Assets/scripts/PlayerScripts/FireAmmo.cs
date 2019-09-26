using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Launches ammo from the Turret on the Ship
 */
public class FireAmmo : MonoBehaviour {

	//Reference to Turret
	GameObject Turret = null;
	Transform TurretTransform = null;

    //Reference to GameManager
    GameObject gameManager;

	//Reference to ammo prefab
	public GameObject AmmoPrefab = null;

	//How often ammo should be fired
	float FireRate;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        Turret = GameObject.Find ("Turret");
		TurretTransform = Turret.GetComponent<Transform> ();

        FireRate = gameManager.GetComponent<StatsManager>().PlayerFireRate;
        cancelInvoke();

        
    }
	

    void createAmmo() {
        Instantiate (AmmoPrefab, TurretTransform.position, TurretTransform.rotation);
        FireRate = gameManager.GetComponent<StatsManager>().PlayerFireRate;
    }



    public void cancelInvoke() {
        CancelInvoke();
    }
    public void startInvoke() {
        InvokeRepeating("createAmmo", 1, FireRate);
    }
}
