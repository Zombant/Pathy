using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour {

    EnemyStatsManager stats;

	// Use this for initialization
	void Start () {
        stats = GetComponent<EnemyStatsManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col) {
        //Damage the player if contact with it
        if (col.gameObject.CompareTag("Player")) { 
            col.gameObject.GetComponent<HealthManager>().loseHealth(stats.Damage);
            GetComponent<Rigidbody2D>().AddForce(-transform.up * stats.Speed);
            
        }
    }


}
