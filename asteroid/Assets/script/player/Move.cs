using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float maxspeed = 0.05f;
	public float rotspeed = 60f;
	// Update is called once per frame
	void Update () 
	{
		Quaternion r = transform.rotation;
		float z = r.eulerAngles.z;
		z -= Input.GetAxis ("Horizontal") * rotspeed*Time.deltaTime;//horizontal movement using z axis
		r = Quaternion.Euler (0, 0, z);
		transform.rotation = r;
		Vector3 pos = transform.position;
		Vector3 movement = new Vector3 (0, Input.GetAxis ("Vertical")*maxspeed*Time.deltaTime, 0);//vertical movement on y axis
		pos = pos + (r * movement);
		transform.position = pos;

	}
}
