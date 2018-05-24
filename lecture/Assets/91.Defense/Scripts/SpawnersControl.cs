using UnityEngine;
using System.Collections;

public class SpawnersControl : MonoBehaviour {
	
	public GameObject[] Spawners;
	public GameObject Enemy;
	
	public float SpawnDelay = 10.0f;
	private float LastSpawnTime;

	// Use this for initialization
	void Start () {
		LastSpawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > LastSpawnTime + SpawnDelay)
		{
			LastSpawnTime = Time.time;
			GameObject spawnObj = Instantiate(Enemy, 
			                                  Spawners[0].transform.position,
			                                  Spawners[0].transform.rotation) as GameObject;
			if(spawnObj != null)
			{
				for(int i  = 1 ; i < Spawners.Length; i++)
				{
					spawnObj.SendMessage("SetTargetPos", Spawners[i].transform.position);
				}
				
			}
			
		}
	
	}
	
	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		foreach(GameObject spawn in Spawners)
		{
			Gizmos.DrawWireCube(spawn.transform.position, new Vector3(1.0f,1.0f,1.0f));
		}
	}
	
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, 1.0f);
	}
	
}

















