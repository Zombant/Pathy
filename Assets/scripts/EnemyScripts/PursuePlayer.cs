using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuePlayer : MonoBehaviour {

    GameObject player;
    float distanceToPlayer;
    EnemyStatsManager enemyStatsManager;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyStatsManager = GetComponent<EnemyStatsManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null) { return; }
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer < enemyStatsManager.FieldOfView) {
            enemyStatsManager.pursuingPlayer = true;
        } else {
            enemyStatsManager.pursuingPlayer = false;
        }

    }
}