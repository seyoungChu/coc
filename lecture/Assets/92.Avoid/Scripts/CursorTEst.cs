using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


public class CursorTEst : MonoBehaviour {
	
	void Start()
	{
		
		IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
	 	Debug.Log(IPHost.AddressList[0].ToString());
 
	}

	void DidLockCursor() 
	{        
		Debug.Log("Locking cursor");        
		GetComponent<GUITexture>().enabled = false;    
	}   
	void DidUnlockCursor() 
	{        
		Debug.Log("Unlocking cursor");       
		GetComponent<GUITexture>().enabled = true;    
	}   
	void OnMouseDown() {        
		//Screen.lockCursor = true;
		Cursor.visible = false;
	}    
	private bool wasLocked = false;    
	void Update() {       
		if (Input.GetKeyDown("escape"))            
			Cursor.visible = true;//Screen.lockCursor = false;                
		if (!Screen.lockCursor && wasLocked) {    
			
			wasLocked = false;            
			DidUnlockCursor();        
		} 
		else            
		if (Screen.lockCursor && !wasLocked) {                
			wasLocked = true;                
			DidLockCursor();            
		}    
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(10,10,200,20), Input.mousePosition.ToString());
	}
}

