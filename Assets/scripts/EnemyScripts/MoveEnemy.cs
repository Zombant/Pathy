using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    float distance;

    float radiusOfPlayer;

    GameObject player;
    GameObject gameManager;

    string enemyType;

    EnemyStatsManager enemyStatsManager;

    Vector2 goToLocation;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        radiusOfPlayer = gameManager.GetComponent<StatsManager>().PlayerRadius;
        enemyStatsManager = GetComponent<EnemyStatsManager>();
        enemyType = enemyStatsManager.EnemyType;
        generateNewLocation();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(player == null) { return; }
        if (enemyStatsManager.pursuingPlayer) {
            if(enemyType == "Blue") {
                transform.Translate(new Vector3(0, gameObject.GetComponent<EnemyStatsManager>().Speed, 0));
            } else {
                //TODO: MAKE ONLY START MOVING IF THE PLAYER MOVES TO AVOID SHAKING
                distance = Vector3.Distance(transform.position, player.transform.position);
                if (distance > radiusOfPlayer) {
                    transform.Translate(new Vector3(0, gameObject.GetComponent<EnemyStatsManager>().Speed, 0));

                } else if(distance < radiusOfPlayer) {
                    transform.Translate(new Vector3(0, -gameObject.GetComponent<EnemyStatsManager>().Speed, 0));

                }
            }
        } else {
            if (Mathf.Abs(transform.position.x - goToLocation.x) <= .5 && Mathf.Abs(transform.position.y - goToLocation.y) <= .5) {
                generateNewLocation();
            }

            //Rotate
            Vector3 diff = new Vector3(goToLocation.x - transform.position.x, goToLocation.y - transform.position.y);
            diff.Normalize();
            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

            //Move
            transform.Translate(new Vector3(0, gameObject.GetComponent<EnemyStatsManager>().Speed * 5, 0));

        }

    }

    public void generateNewLocation()
    {
        if (player == null) { return; }
        goToLocation = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width - 10), Random.Range(0, Screen.height - 10)));
        while (Vector3.Distance(goToLocation, player.transform.position) < radiusOfPlayer)
        {
            goToLocation = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width - 10), Random.Range(0, Screen.height - 10)));
        }
    }
}
