using UnityEngine;
using System.Collections;

public class Spawners : MonoBehaviour {
	
	public Transform[] spawn;
	public float explosionRadius = 5.0F;    
	
	public float spawnTime = 3.0f;
	public GameObject Enemy;
	private float LastSpawnTime;
	private int spawnindex = 0;
	// Use this for initialization
	void Start () {
		LastSpawnTime = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Time.time > LastSpawnTime + spawnTime)
		{
			LastSpawnTime = Time.time;
			if(spawnindex < spawn.Length)
			{
				 Instantiate(Enemy, spawn[spawnindex].transform.position,spawn[spawnindex].transform.rotation);
				spawnindex+= 1;
			}else
			{
				spawnindex = 0;
			}
			
		}
	
	}
	
	void OnDrawGizmosSelected() {        
		Gizmos.color = Color.red;        
		foreach( Transform tran in spawn)
		{
			Gizmos.DrawWireSphere(tran.position, explosionRadius);    	
		}
		
	}
}
