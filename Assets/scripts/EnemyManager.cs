using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    float screenHeight;
    float screenWidth;

    public GameObject Blue;
    public GameObject Yellow;
    public GameObject Red;

    GameObject gameManager;

    int enemyID;

    float radiusOfPlayer;

    GameObject player;

    GameObject spawner;

    public int numOfEnemies;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");

        radiusOfPlayer = gameManager.GetComponent<StatsManager>().PlayerRadius;
        player = GameObject.FindGameObjectWithTag("Player");

        InvokeRepeating("createBaddies", 0, 2f);
        spawner = GameObject.FindGameObjectWithTag("Spawner");
	}

    void createBaddies() {
        //ONLY USE THE FOLLOWING COMMENTED CODE IF SPAWNERS ARE NOT USED
        /*Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(
                    Random.Range(0, Screen.width - 10), 
                    Random.Range(0, Screen.height - 10), 
                    Camera.main.farClipPlane / 2));
        screenPosition.z = 3;
        while(Vector3.Distance(screenPosition, player.transform.position) < radiusOfPlayer) {
            screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(
                    Random.Range(0, Screen.width - 10),
                    Random.Range(0, Screen.height - 10),
                    Camera.main.farClipPlane / 2));
            screenPosition.z = 3;*/
        if(numOfEnemies <= gameManager.GetComponent<StatsManager>().MaxNumOfEnemies - 1) { 
            Vector3 screenPosition = new Vector3(spawner.transform.position.x, spawner.transform.position.y, 3);
            if (gameManager.GetComponent<GameStateManager>().Score < 50)
            {
                Instantiate(Blue, screenPosition, Quaternion.identity);
            }
            else if (gameManager.GetComponent<GameStateManager>().Score < 100)
            {
                enemyID = Random.Range(0, 3);
                Debug.Log(enemyID);
                switch (enemyID)
                {
                    case 0:
                        Instantiate(Blue, screenPosition, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Blue, screenPosition, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(Yellow, screenPosition, Quaternion.identity);
                        break;
                }
            }
            else if (gameManager.GetComponent<GameStateManager>().Score < 150)
            {
                enemyID = Random.Range(0, 5);
                Debug.Log(enemyID);
                switch (enemyID)
                {
                    case 0:
                        Instantiate(Blue, screenPosition, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Blue, screenPosition, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(Yellow, screenPosition, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(Yellow, screenPosition, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(Red, screenPosition, Quaternion.identity);
                        break;
                }
                
            }
            numOfEnemies++;
        }
    }
}
