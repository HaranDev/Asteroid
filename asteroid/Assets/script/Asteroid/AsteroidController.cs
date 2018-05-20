using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour 
{
	public float Speed=1f;
	public float tourquerange;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		InvokeRepeating ("move", 0f, 1f);
	}
	void move()
	{
		
		rb.velocity = transform.right * Speed;
		rb.AddTorque(Random.Range(tourquerange,2*tourquerange));
	}

//this could be used for additional random rotation	
//	void Update()
//	{
//		//transform.Rotate (0, 0, Random.Range (0, 360f));
//		//InvokeRepeating ("Start",3,3);
//			
//	}
//	
	
}
