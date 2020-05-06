using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Generate : MonoBehaviour 
{
	public GameObject rocks;
	int result = 0;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("CreateRocks", 1f, 1.5f);
	}
	
	void OnGUI()
	{
		GUI.color = Color.black;
		GUILayout.Label("Result: " + result.ToString());
	}

	// Update is called once per frame
	void CreateRocks () 
	{
		Instantiate(rocks);
	}
}
