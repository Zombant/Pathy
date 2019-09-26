using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAmmo : MonoBehaviour
{

    GameObject gameManager;

    //This Rigidbody2D
    Rigidbody2D ThisBody = null;

    //Speed of Ammo
    float AmmoSpeed;

    //How long each Ammo lives for
    float LifeTime;

    public float Damage;

    void OnEnable()
    {
        CancelInvoke ();
    }

    /*
	 * Initialize Ammo and make it move forward
	 */
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        ThisBody = GetComponent<Rigidbody2D>();

        AmmoSpeed = gameManager.GetComponent<StatsManager>().EnemyAmmoSpeed;
        LifeTime = gameManager.GetComponent<StatsManager>().PlayerAmmoLifeTime;

        ThisBody.AddForce(transform.up * AmmoSpeed);
        Invoke("Die", LifeTime);
    }

    /*
	 * Destroy Ammo when the lifetime is over
	 */
    void Die()
    {
        Destroy(gameObject);
    }


}
