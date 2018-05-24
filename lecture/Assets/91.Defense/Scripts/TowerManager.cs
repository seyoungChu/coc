using UnityEngine;
using System.Collections;

public class TowerManager : MonoBehaviour {
	
	public GameObject[] towers;
	
	void Start()
	{
		int index = 0;
		foreach(GameObject tower in towers)
		{
			tower.GetComponent<TowerControl>().TowerID = index;
			index++;
		}
	}
	
	void OnGUI()
	{
		GUI.color = Color.red;
		for(int i = 0 ; i < towers.Length ; i++)
		{
			GUI.Label(new Rect(10,10+i*20.0f,100,20), towers[i].GetComponent<TowerControl>().tState.ToString());
		}
		    
		
	}
	
	public void EnemyDieToTower(int Towerid)
	{
		towers[Towerid].SendMessage("EnemyDead");
	}
}
