using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Launches ammo from the Turret on the Ship
 */
public class EnemyShoot : MonoBehaviour {

    //Reference to GameManager
    GameObject gameManager;

    //Reference to ammo prefab
    public GameObject AmmoPrefab = null;

    //How often ammo should be fired
    float FireRate;
    float delayFire;

    float Damage;

    // Use this for initialization
    void Start() {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        Invoke("startInvoke", 1f);
        Damage = GetComponent<EnemyStatsManager>().Damage;
        delayFire = Random.Range(0, 2f);

    }
    void Update() {
        Damage = GetComponent<EnemyStatsManager>().Damage;
        FireRate = GetComponent<EnemyStatsManager>().FireRate;
    }

    void createAmmo() {
        if (GetComponent<EnemyStatsManager>().pursuingPlayer == true) {
            GameObject go = Instantiate(AmmoPrefab, transform.position, transform.rotation);
            go.GetComponent<EnemyAmmo>().Damage = Damage;
        }
        
    }

    void startInvoke() {
        InvokeRepeating("createAmmo", delayFire, FireRate);
    }

}
