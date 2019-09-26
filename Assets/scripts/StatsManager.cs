using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour {

    [Space(20)]

    [Header("Player Stats")]
    [Space(5)]
    public int PlayerHealth;
    public float PlayerSpeed;
    public float PlayerFireRate;
    public float PlayerDamage;
    public float PlayerAmmoThrust;
    public float PlayerAmmoLifeTime;
    public float PlayerRadius;
    public float PlayerDamageCooldown;

    [Space(20)]

    [Header("Spawner Stats")]
    [Space(5)]
    public float SpawnerSpeed;

    [Space(20)]

    [Header("Universal Enemy Stats")]
    [Space(5)]
    public float EnemyAmmoSpeed;
    public int MaxNumOfEnemies;

    [Space(20)]

    [Header("Blue Stats")]
    [Space(5)]
    public int BlueInitialHealth;
    public float BlueSpeed;
    public float BlueDamage;
    public float BlueRotationSpeed;
    public int BluePointValue;
    public float BlueFieldOfView;

    [Space(20)]

    [Header("Yellow Stats")]
    [Space(5)]
    public int YellowInitialHealth;
    public float YellowSpeed;
    public float YellowFireRate;
    public float YellowDamage;
    public float YellowRotationSpeed;
    public int YellowPointValue;
    public float YellowFieldOfView;

    [Space(20)]

    [Header("Red Stats")]
    [Space(5)]
    public int RedInitialHealth;
    public float RedSpeed;
    public float RedFireRate;
    public float RedDamage;
    public float RedRotationSpeed;
    public int RedPointValue;
    public float RedFieldOfView;
}
