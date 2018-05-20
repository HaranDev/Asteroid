using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteWarp : MonoBehaviour
{
    void FixedUpdate () 
	{	
		Vector3 pos = transform.position;
		if (transform.position.y > 10.75f)//checks boundary with respect to y axis 
			pos.y = -10.75f;//resets player position accordng to axis				
		if (transform.position.y < -10.75f)//checks boundary with respect to y axis
			pos.y = 10.75f;//resets player position accordng to axis
		if (transform.position.x > 14.2f)//checks boundary with respect to x axis
			pos.x = -14.2f;//resets player position accordng to axis
		if (transform.position.x < -14.2f)//checks boundary with respect to x axis
			pos.x = 14.2f;//resets player position accordng to axis
		transform.position = pos;
	}
}
