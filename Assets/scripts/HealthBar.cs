using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    EnemyStatsManager enemyStatsManager;

	// Use this for initialization
	void Start () {
        enemyStatsManager = transform.parent.parent.GetComponent<EnemyStatsManager>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(enemyStatsManager.Health / enemyStatsManager.initialHealth, 1, 1);
    }
}
