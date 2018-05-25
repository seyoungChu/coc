using UnityEngine;
using System.Collections;

public class TowerControl : MonoBehaviour
{

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
    void Start()
    {
        LastShootTime = Time.time;

        if (Shooter == null)
        {
            Shooter = gameObject.transform.Find("Shooter");
        }

    }

    // Update is called once per frame
    void Update()
    {
        switch (tState)
        {
            case TowerState.Idle:
                break;
            case TowerState.Attack:
                OnAttack();
                break;
        }
    }
    //
    public void OnAttack()
    {
        if (this.Target == null)
        {
            if (this.NextTarget != null)
            {
                this.Target = this.NextTarget;
            }
        }
        if (this.Target != null)
        {
            if (Time.time > LastShootTime + ShootDelayTime)
            {
                LastShootTime = Time.time;

                GameObject missile = Instantiate(Resources.Load("missileFBX"),
                                                 Shooter.transform.position,
                                                 Shooter.transform.rotation) as GameObject;
                if (missile != null)
                {
                    missile.tag = "missile";
                    missile.AddComponent<MissileControl>();

                    missile.SendMessage("SetTargetPosition", this.Target);
                    missile.SendMessage("SetShootTowerID", this.TowerID);
                }

            }

        }

    }

    public void DetectEnemy(GameObject target)
    {
        Debug.Log("Detect Enemy Called");

        switch (tState)
        {
            case TowerState.Idle:

                LastShootTime = Time.time;
                this.Target = target;
                tState = TowerControl.TowerState.Attack;

                break;
            case TowerState.Attack:

                this.NextTarget = target;

                break;
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













