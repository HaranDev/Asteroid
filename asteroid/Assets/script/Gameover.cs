using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour 
{
	
	private float a;
	public Text timerdata;
	// Use this for initialization
	void Start () 
	{
		a = PlayerPrefs.GetFloat ("timercount");//gets timer value from previous scene  
		timerdata.text = "You Survived:" + a.ToString ("F")+"seconds";
		Invoke ("Changing", 3f);
	}
	void Changing()
	{
		Debug.Log ("scene Change");
		GameObject.Find ("Changer").GetComponent<SceneChanger> ().changescene ();

	}

}
