using UnityEngine;
using System.Collections;

public class DetectTriggerControl : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Trigger Enter");
		if(other.tag == "enemy")
		{
			gameObject.SendMessageUpwards("DetectEnemy", other.gameObject);
			
		}
	}
	
	
	void OnTriggerExit(Collider other)
	{
		Debug.Log("Trigger Exit");
		if(other.tag == "enemy")
		{
			gameObject.SendMessageUpwards("LeaveEnemy");
		}
	}
	
}
