using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfire : MonoBehaviour
{
	public float firedelay=0.5f;
	public Vector3 boff=new Vector3(0,0.5f,0);
	public GameObject bullet;
	public int poolamount= 2 ;
	float cooldown=0;
	void Start()
	{
		PoolScript.current.getPooledObject (bullet,poolamount);//initiate bulletpool
		
	}
	void Update () 
	{
		cooldown -= Time.deltaTime; 
		if (Input.GetButtonUp("Jump") && cooldown <= 0)//when button for jump is pressed  
		{
			cooldown += firedelay;
			Vector3 off = transform.rotation * boff;
			GameObject obj = PoolScript.current.objectreturn();//get object from pool
			if (obj == null)
				return;
			
			obj.transform.position = transform.position + off;//position of bullet
			obj.transform.rotation = transform.rotation;//rotation of bullet
			obj.SetActive (true);

		}	
	}
}
