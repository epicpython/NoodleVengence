﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapearonbuttonpress : MonoBehaviour {

	public string letter;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (letter == "h")
		{
			if (Input.GetKeyDown (KeyCode.H)) 
			{
				Debug.Log ("pressed H");
				Destroy (gameObject);
			}
		}else if (letter == "j")
		{
			if (Input.GetKeyDown (KeyCode.J)) 
			{
				Debug.Log ("pressed J");
				Destroy (gameObject);
			}
		}else if (letter == "k")
		{
			if (Input.GetKeyDown (KeyCode.K)) 
			{
				Debug.Log ("pressed K");
				Destroy (gameObject);
			}
		} else if (letter == "l")
		{
			if (Input.GetKeyDown (KeyCode.L)) 
			{
				Debug.Log ("pressed L");
				Destroy (gameObject);
			}
		}
		
	}
}
