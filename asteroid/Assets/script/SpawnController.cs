using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
	public	float spawntime = 5f;
	public float decay = 0.95f;
	public float next = 0;
	void Update () 
	{
		next -= Time.deltaTime;
		if(next<=0)
		{
			next += spawntime;
			spawntime *= decay;
			Quaternion angle = Quaternion.Euler (0, 0, Random.Range (0, 360f));
			GameObject ast = GenPoolScript.cur.getPooledObject ();
			if(ast==null) return;
			ast.transform.RotateAround (Vector3.zero, Vector3.forward, Random.Range (0, 360f));
			ast.transform.position = new Vector3 (0, Random.Range(10f,-30f) , 0);
			ast.transform.rotation = angle;
			ast.SetActive (true);
		}
			
	}
}
