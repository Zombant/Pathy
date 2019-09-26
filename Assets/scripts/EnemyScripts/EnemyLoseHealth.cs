using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoseHealth : MonoBehaviour {

    GameObject gameManager;

    EnemyStatsManager stats;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        stats = GetComponent<EnemyStatsManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        //Lose health if contact with the player's ammo
        if (col.gameObject.CompareTag("PlayerAmmo")) {
            stats.loseHealth(gameManager.GetComponent<StatsManager>().PlayerDamage);
            Destroy(col.gameObject);
            
        }

    }
    
}
