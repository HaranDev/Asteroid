using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TriggerDestroy : MonoBehaviour 
{ 	public static int health=3;
	public Text helth;
	public GameObject partic;
	void Start()
	{
		helth.text="Health:"+  (health-1).ToString ();
	}
	void OnTriggerEnter2D (Collider2D other)
	{	//Debug.Log ("trigerred");
		if (other.CompareTag ("bullet")) 
		{
			other.gameObject.SetActive (false);
			gameObject.SetActive (false);
			GameObject ast = ParticlePool.cur.getPooledObject ();
			if(ast==null) return;
			ast.transform.position = transform.position;
			ast.transform.rotation = transform.rotation;
			ast.SetActive (true);

		}
		if ((other.CompareTag("player"))) 
		{	gameObject.SetActive (false);
			health--;
			if (health <= 0) 
			{
				other.gameObject.SetActive (false);

				GameObject.Find ("Changer").GetComponent<SceneChanger> ().changescene ();

			}
		}
	}
	void Update()
	{
		helth.text = "Health:" + (health-1).ToString ();

	}
}
