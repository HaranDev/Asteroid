using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour 
{
	public static float timercount=0f;
	private Text timerdata;

	void Start ()
	{
		timerdata = GetComponent<Text> ();
		PlayerPrefs.SetFloat ("timercount", timercount);

	}
	void Update()
	{
		timercount += Time.deltaTime;
		PlayerPrefs.SetFloat ("timercount", timercount);
		timerdata.text = "Time:" + timercount.ToString ("F");
		if (timercount >= 60)
		{	timercount = 60f;
			PlayerPrefs.SetFloat ("timercount", timercount);
			GameObject.Find ("Changer").GetComponent<SceneChanger> ().changescene ();
		}
	}
	float getTimercount()
	{
		return timercount;
	}

}
