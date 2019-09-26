using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreChanger : MonoBehaviour {

    TextMeshProUGUI textComponent;

    GameStateManager gameStateManager;

	// Use this for initialization
	void Start () {
        textComponent = GetComponent<TextMeshProUGUI>();
        gameStateManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
	}
	
	// Update is called once per frame
	void Update () {
        textComponent.text = gameStateManager.Score.ToString();
	}
}
