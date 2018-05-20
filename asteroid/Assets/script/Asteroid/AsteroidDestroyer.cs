using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour 
{
	void OnEnable()
	{
		Invoke ("Destroy", 3f);//invokes destroy
	}
	public void Destroy()
	{
		gameObject.SetActive (false);//game object is inavtive
	}
	void OnDisable()
	{
		CancelInvoke ();//prevents from stacking up invokes
	}

}
