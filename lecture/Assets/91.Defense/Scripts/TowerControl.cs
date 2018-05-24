using UnityEngine;
using System.Collections;

public class TowerControl : MonoBehaviour {
	
	private Transform Shooter;
	private float LastShootTime;
	public float ShootDelayTime = 0.5f;
	public int TowerID;
	public enum TowerState
	{
		Idle = 1,
		Attack = 2,
		
		Size,
	}
	
	public TowerState tState = TowerState.Idle;
	
	private GameObject Target;
	private GameObject NextTarget;

	// Use this for initialization
	void Start () {
		LastShootTime = Time.time;
		
		if(Shooter == null)
		{
			Shooter = gameObject.transform.Find("Shooter");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Time.time > LastShootTime + ShootDelayTime)
		{
			LastShootTime = Time.time;
			if(tState != TowerControl.TowerState.Idle)
			{
				GameObject missile = Instantiate(Resources.Load("missileFBX"),
				                                 Shooter.transform.position,
				                                 Shooter.transform.rotation) as GameObject;
				if(missile != null)
				{
					missile.tag = "missile";
					missile.AddComponent<MissileControl>();
					if(this.Target == null)
					{
						if(this.NextTarget != null)
						{
							this.Target = this.NextTarget;
						}else
						{
							Destroy(missile);
							return;
						}
					}
					
					missile.SendMessage("SetTargetPosition",this.Target);
					missile.SendMessage("SetShootTowerID", this.TowerID);
				}
				
				                                 
			}
		}
	
	}
	
	public void DetectEnemy(GameObject target)
	{
		Debug.Log("Detect Enemy Called");
		if(tState == TowerControl.TowerState.Idle)
		{
			LastShootTime = Time.time;
			this.Target = target;
			tState = TowerControl.TowerState.Attack;
			
		}else if(tState == TowerControl.TowerState.Attack)
		{
			
			this.NextTarget = target;
			
		}
	}
	public void LeaveEnemy()
	{
		Debug.Log("Enemy Leave");
		tState = TowerControl.TowerState.Idle;
	}
	
	public void EnemyDead()
	{
		this.Target = this.NextTarget;
		this.NextTarget = null;
	}
}













