using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playbutton : MonoBehaviour 
{
	void OnMouseDown()
	{
		Debug.Log ("mousedetected");
		GameObject.Find ("Changer").GetComponent<SceneChanger> ().changescene ();
	}


}
