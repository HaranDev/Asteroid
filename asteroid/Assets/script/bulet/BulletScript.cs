using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour 
{	public float maxspeed;
	
	// Update is called once per frame
	void Update () 
	{
		
		Vector3 pos=transform.position;
		Vector3 movement = new Vector3 (0, maxspeed*Time.deltaTime, 0);//forward movement
		pos = pos + (transform.rotation * movement);//position according to playership
		transform.position = pos;
	}
}
