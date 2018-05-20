using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript : MonoBehaviour 
{
	public static PoolScript current;
	List<GameObject> poooldObjectList;
	void Awake()
	{
		current = this;

	}
	public void getPooledObject( GameObject f,int p)
	{	
			poooldObjectList = new List<GameObject> ();
			for (int i = 0; i < p; i++) 
			{
				GameObject obj = (GameObject)Instantiate (f);
				obj.SetActive (false);
				poooldObjectList.Add (obj);
				
			}


	}
	

	public GameObject objectreturn () 
	{ 	int i = 0;
		
			for ( i = 0; i < poooldObjectList.Count; i++) 
			{
				if (!poooldObjectList [i].activeInHierarchy)
				{
					return poooldObjectList [i];
				}
						
			}

		return null;

	}

}
