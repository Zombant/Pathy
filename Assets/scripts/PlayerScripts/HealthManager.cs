using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    public float Health;

    public GameObject ExplosionPrefab;

    public GameObject greenBar;

    GameObject gameManager;
    StatsManager statsManager;
    float damageCooldown;
    public bool canTakeDamage;


	// Use this for initialization
	void Start () {
        Health = GameObject.FindGameObjectWithTag("GameManager").GetComponent<StatsManager>().PlayerHealth;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        statsManager = gameManager.GetComponent<StatsManager>();
        damageCooldown = statsManager.PlayerDamageCooldown;
        canTakeDamage = true;
    }
	


	// Update is called once per frame
	void Update () {
        greenBar.transform.localScale = new Vector3(Health / 100, 1, 1);
        //TODO: PUT ALL STATS UPDATES IN ALL SCRIPTS IN AN INVOKEREPEATING
        damageCooldown = statsManager.PlayerDamageCooldown;
        if (Health <= 0) { die(); }

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        //Lose health if contact with the player's ammo
        if (col.gameObject.CompareTag("EnemyAmmo"))
        {
            loseHealth(col.gameObject.GetComponent<EnemyAmmo>().Damage);
            Destroy(col.gameObject);

        }

    }

    void die() {
        GameObject explosion = Instantiate(ExplosionPrefab);
        explosion.transform.position = transform.position;
        Destroy(gameObject);
    }

    public void loseHealth(float value) {
        if (canTakeDamage) {
            Health -= value;
            canTakeDamage = false;
            Invoke("damageEnable", damageCooldown);
        }
    }

    void damageEnable() {
        canTakeDamage = true;
    }
}
