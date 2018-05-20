using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour 
{	
	public Image black;
	public Animator anim;
	public void changescene()
	{
		//Debug.Log ("Called");
		StartCoroutine (Fading ());

	}
	IEnumerator	Fading()
	{
		anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => black.color.a == 1);
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
