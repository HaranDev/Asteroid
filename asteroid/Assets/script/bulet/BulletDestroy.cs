using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour 
{
	void OnEnable()
	{
		Invoke ("Destroy", 2f);//invokes destroyer
	}
	public void Destroy()
	{
		gameObject.SetActive (false);//bullet set inactive
	}
	void OnDisable()
	{
		CancelInvoke ();//prevents stacking of invoke
	}


}
