using UnityEngine;
using System.Collections;

public class BeetleHit : MonoBehaviour {
	private GameObject HPText;
	
	void Start () {
		
		HPText = gameObject.transform.parent.Find("BeetleHP").gameObject;
		
	}
	public void Hit(int damage)
	{
		HPText.SendMessage("Hited", damage);
	}
	
	public void TowerID(int id)
	{
		HPText.SendMessage("SetTowerID", id);
	}
}
