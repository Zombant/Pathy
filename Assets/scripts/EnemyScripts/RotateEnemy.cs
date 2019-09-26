using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour {

    EnemyStatsManager enemyStatsManager;
    GameObject Player;

	// Use this for initialization
	void Start () {
        enemyStatsManager = GetComponent<EnemyStatsManager>();
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Player == null) { return; }
        if (enemyStatsManager.pursuingPlayer) {
            Vector3 diff = Player.transform.position - transform.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        }
	}
}
