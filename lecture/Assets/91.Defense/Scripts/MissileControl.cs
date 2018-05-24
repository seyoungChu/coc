using UnityEngine;
using System.Collections;

public class MissileControl : MonoBehaviour {
	
	public float MissileSpeed = 3.0f;
	public Vector3 TargetPosition;
	public GameObject TargetGO;
	private int MissileDamage = 50;
	private int towerId;
	
	// Use this for initialization
	void Start () {
		
		transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 Diff = TargetPosition - transform.position;
		Vector3 Direction = Diff.normalized;
		if(Diff.magnitude < 0.1f)
		{
			if(TargetGO == null) 
			{
				
				Destroy(gameObject);
				return;
			}
			
			TargetGO.SendMessage("Hit", MissileDamage);
			TargetGO.SendMessage("TowerID",this.towerId);
			Instantiate(Resources.Load("Prefabs/Spark"), transform.position, transform.rotation);
			Destroy(gameObject);
			return;
		}
		
		transform.Translate(Direction * Time.deltaTime * MissileSpeed, Space.World);
		transform.LookAt(TargetPosition);
	
	}
	
	public void SetTargetPosition(GameObject TargetObj)
	{
		this.TargetGO = TargetObj;
		if(TargetGO != null)
		{
			this.TargetPosition = this.TargetGO.transform.position;
		}else
		{
			
			Destroy(gameObject);
		}
	}
	
	public void SetShootTowerID(int id)
	{
		this.towerId = id;
	}
	
	
}









