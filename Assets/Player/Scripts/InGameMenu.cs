﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		menuopen();
	}

	void menuopen()
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("Mainmenu");
		}
	}
}
