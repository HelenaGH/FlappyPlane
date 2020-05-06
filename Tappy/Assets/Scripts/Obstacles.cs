using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour 
{
	public Vector2 velocity = new Vector2(-4, 0);
	public int range = 4;

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
