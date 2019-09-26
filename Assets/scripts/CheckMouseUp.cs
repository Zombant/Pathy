using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMouseUp : MonoBehaviour {

    //References to other components
    GameStateManager gameStateManager;

	// Use this for initialization
	void Start () {
        gameStateManager = GetComponent<GameStateManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0)) {
            gameStateManager.pauseGame();
        }
        if (Input.GetMouseButtonDown(0)) {
            gameStateManager.startGame();
        }
    }
}
