using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour {

    public int Score;

    //References to other GameObjects
    GameObject playerObject;

	// Use this for initialization
	void Start () {
        Score = 0;
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerObject.GetComponent<MovePlayer>().enabled = false;
        playerObject.GetComponent<ChangeDirection>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void pauseGame() {
        if (playerObject == null) { return; }
        playerObject.GetComponent<MovePlayer>().enabled = false;
        playerObject.GetComponent<ChangeDirection>().enabled = false;
        GameObject.FindGameObjectWithTag("Turret").GetComponent<FireAmmo>().cancelInvoke();
    }
    public void startGame() {
        if (playerObject == null) { return; }
        playerObject.GetComponent<MovePlayer>().enabled = true;
        playerObject.GetComponent<ChangeDirection>().enabled = true;
        GameObject.FindGameObjectWithTag("Turret").GetComponent<FireAmmo>().startInvoke();
    }
    public void gameOver() {

    }
}
