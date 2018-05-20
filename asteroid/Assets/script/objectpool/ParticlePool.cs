using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ParticlePool : MonoBehaviour 
{
	public static ParticlePool cur;
	public GameObject pooledObject;
	public int poolAmount=5;
	public bool willgrow = true;
	public List<GameObject> pooledobjects;
	private int capTime = 0;
	void Awake()
	{
		cur = this;
	}
	// Use this for initialization
	void Start () 
	{
		pooledobjects = new List<GameObject> ();
		for (int i=0;i<poolAmount;i++)
		{
			GameObject obj = (GameObject)Instantiate (pooledObject);
			obj.SetActive (false);
			pooledobjects.Add (obj);//objects added to pool
		}
		InvokeRepeating ("addPool", 15f, 6.5f);//used for increasing pool size automatically by 25 percent for 4 times
	}

	// Update is called once per frame
	public GameObject getPooledObject()
	{
		for (int i = 0; i < pooledobjects.Count; i++) 
		{
			if (!pooledobjects [i].activeInHierarchy) 
			{
				return pooledobjects [i];
			}
		}
		if (willgrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject);
			pooledobjects.Add (obj);
			return obj;
		}
		return null;
	}
	public void addPool( )
	{ if(capTime < 4)
		{
			capTime++;
			int percent = Convert.ToInt32 (poolAmount * 0.25f);//increased by 25 percentage
			for (int i = 0; i < percent; i++) {
				GameObject obj = (GameObject)Instantiate (pooledObject);
				pooledobjects.Add (obj);//added to pool list
				obj.SetActive (false);
			}
			poolAmount = poolAmount + percent;
			//Debug.Log ("Pool amount added to" + poolAmount);
		} 

	}
}

