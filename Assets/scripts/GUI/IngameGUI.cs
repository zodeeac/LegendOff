﻿using UnityEngine;
using System.Collections;

public class IngameGUI : MonoBehaviour {

	float widthCenter, heightCenter, widthBG, heightBG;
	GameObject player;
	public float guiScale = 1f;
	public Texture2D background;
	public Texture2D lifebar;
	public Texture2D staminaBar;
	public Texture2D poisonIcon;
	public Texture2D bleedIcon;
	string soulDisplay;

	// Use this for initialization
	void Awake () {
		widthCenter = Screen.currentResolution.width / 2f;
		heightCenter = Screen.currentResolution.height / 2f; 
		widthBG = (Screen.currentResolution.width / 3f) * guiScale;
		heightBG = widthBG / 4f;
		player = GameObject.FindGameObjectWithTag ("Player");
		soulDisplay = ""+0;
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, widthBG, heightBG), background);
		//Debug
		GUI.Label(new Rect(10,heightBG + 10, 100,20), soulDisplay);
	}

	void Update(){
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel("mainmenu");
		}
		soulDisplay = ""+player.GetComponent<Stats> ().souls;
	}
}