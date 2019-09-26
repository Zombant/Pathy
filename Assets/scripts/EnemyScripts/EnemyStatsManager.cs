using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatsManager : MonoBehaviour {

    public string EnemyType;

    public float FireRate;
    public float Health;
    public float Damage;
    public float Speed;
    public float RotationSpeed;
    public int PointValue;
    public float FieldOfView;
    //public float AmmoSpeed;

    public bool pursuingPlayer;

    public float initialHealth;

    GameObject gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");

        pursuingPlayer = false;
        //AmmoSpeed = gameManager.GetComponent<StatsManager>().EnemyAmmoSpeed;
        if (EnemyType == "Blue") {
            Health = gameManager.GetComponent<StatsManager>().BlueInitialHealth;
            Damage = gameManager.GetComponent<StatsManager>().BlueDamage;
            Speed = gameManager.GetComponent<StatsManager>().BlueSpeed;
            RotationSpeed = gameManager.GetComponent<StatsManager>().BlueRotationSpeed;
            PointValue = gameManager.GetComponent<StatsManager>().BluePointValue;
            FieldOfView = gameManager.GetComponent<StatsManager>().BlueFieldOfView;
        }
        if (EnemyType == "Red") {
            FireRate = gameManager.GetComponent<StatsManager>().RedFireRate;
            Health = gameManager.GetComponent<StatsManager>().RedInitialHealth;
            Damage = gameManager.GetComponent<StatsManager>().RedDamage;
            Speed = gameManager.GetComponent<StatsManager>().RedSpeed;
            RotationSpeed = gameManager.GetComponent<StatsManager>().RedRotationSpeed;
            PointValue = gameManager.GetComponent<StatsManager>().RedPointValue;
            FieldOfView = gameManager.GetComponent<StatsManager>().RedFieldOfView;
        }
        if (EnemyType == "Yellow") {
            FireRate = gameManager.GetComponent<StatsManager>().YellowFireRate;
            Health = gameManager.GetComponent<StatsManager>().YellowInitialHealth;
            Damage = gameManager.GetComponent<StatsManager>().YellowDamage;
            Speed = gameManager.GetComponent<StatsManager>().YellowSpeed;
            RotationSpeed = gameManager.GetComponent<StatsManager>().YellowRotationSpeed;
            PointValue = gameManager.GetComponent<StatsManager>().YellowPointValue;
            FieldOfView = gameManager.GetComponent<StatsManager>().YellowFieldOfView;
        }
        initialHealth = Health;

    }
	
	// Update is called once per frame
	void Update () {
        //AmmoSpeed = gameManager.GetComponent<StatsManager>().EnemyAmmoSpeed;
        if (EnemyType == "Blue") {
            if (Speed != gameManager.GetComponent<StatsManager>().BlueSpeed)
            { Speed = gameManager.GetComponent<StatsManager>().BlueSpeed; }
            if (Damage != gameManager.GetComponent<StatsManager>().BlueDamage)
            { Damage = gameManager.GetComponent<StatsManager>().BlueDamage; }
            if (RotationSpeed != gameManager.GetComponent<StatsManager>().BlueRotationSpeed)
            { RotationSpeed = gameManager.GetComponent<StatsManager>().BlueRotationSpeed; }
            if (PointValue != gameManager.GetComponent<StatsManager>().BluePointValue)
            { PointValue = gameManager.GetComponent<StatsManager>().BluePointValue; }
            if (FieldOfView != gameManager.GetComponent<StatsManager>().BlueFieldOfView)
            { FieldOfView = gameManager.GetComponent<StatsManager>().BlueFieldOfView; }
        }
        if (EnemyType == "Red") {
            if (Speed != gameManager.GetComponent<StatsManager>().RedSpeed)
            { Speed = gameManager.GetComponent<StatsManager>().RedSpeed; }
            if (Damage != gameManager.GetComponent<StatsManager>().RedDamage)
            { Damage = gameManager.GetComponent<StatsManager>().RedDamage; }
            if (FireRate != gameManager.GetComponent<StatsManager>().RedFireRate)
            { FireRate = gameManager.GetComponent<StatsManager>().RedFireRate; }
            if (RotationSpeed != gameManager.GetComponent<StatsManager>().RedRotationSpeed)
            { RotationSpeed = gameManager.GetComponent<StatsManager>().RedRotationSpeed; }
            if (PointValue != gameManager.GetComponent<StatsManager>().RedPointValue)
            { PointValue = gameManager.GetComponent<StatsManager>().RedPointValue; }
            if (FieldOfView != gameManager.GetComponent<StatsManager>().RedFieldOfView)
            { FieldOfView = gameManager.GetComponent<StatsManager>().RedFieldOfView; }
        }
        if (EnemyType == "Yellow") {
            if (Speed != gameManager.GetComponent<StatsManager>().YellowSpeed)
            { Speed = gameManager.GetComponent<StatsManager>().YellowSpeed; }
            if (Damage != gameManager.GetComponent<StatsManager>().YellowDamage)
            { Damage = gameManager.GetComponent<StatsManager>().YellowDamage; }
            if (FireRate != gameManager.GetComponent<StatsManager>().YellowFireRate)
            { FireRate = gameManager.GetComponent<StatsManager>().YellowFireRate; }
            if (RotationSpeed != gameManager.GetComponent<StatsManager>().YellowRotationSpeed)
            { RotationSpeed = gameManager.GetComponent<StatsManager>().YellowRotationSpeed; }
            if (PointValue != gameManager.GetComponent<StatsManager>().YellowPointValue)
            { PointValue = gameManager.GetComponent<StatsManager>().YellowPointValue; }
            if (FieldOfView != gameManager.GetComponent<StatsManager>().YellowFieldOfView)
            { FieldOfView = gameManager.GetComponent<StatsManager>().YellowFieldOfView; }
        }

        if (Health == 0) { die(); }
        if (GameObject.FindGameObjectWithTag("Player") == null) {
            pursuingPlayer = false;
        }
    }


    public void loseHealth(float value) {
        Health -= value;
    }

    void die() {
        Destroy(gameObject);
        gameManager.GetComponent<GameStateManager>().Score += PointValue;
        gameManager.GetComponent<EnemyManager>().numOfEnemies--;
    }

   }
