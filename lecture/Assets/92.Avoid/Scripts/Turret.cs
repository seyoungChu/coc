using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {
	
	public float Speed = 5.0f;
	public enum State {Idle = 0 , Move = 1, Search = 2,Shot = 3}
	public State _state = State.Idle;
	public float RotateSpeed = 500.0f;
	public float MovingTime = 1.0f;
	Vector3 MoveTarget;
	float LastMoveTime;
	float LastShootTime;
	public GameObject bullet;
	
	private GameObject targetPlayer;
	private Vector3 MoveDirection;
	public Transform Shooter;
	public TextMesh StateText;
	
	
	// Use this for initialization
	void Start () {
		MoveTarget = Vector3.zero;
		LastMoveTime = Time.time;
		LastShootTime = Time.time;
		targetPlayer = GameObject.FindWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckState();
		if(MoveDirection.x != 0.0f)
		{
			Debug.Break();
		}
		
	
	}
	void CreateMoveTarget()
	{

		MoveTarget = new Vector3(0.0f,0.0f,Random.Range(-10.0f,10.0f));
		
		Vector3 diff = MoveTarget - transform.position;
		diff = diff.normalized;
		MoveDirection = new Vector3(0.0f,0.0f,diff.z);
		MoveDirection = MoveDirection.normalized;
		
	}
	void Move()
	{
		transform.Translate(MoveDirection * Time.deltaTime * Speed);
	}
	
	void CheckState(){
		switch(_state)
		{
		case State.Idle:
			if(targetPlayer != null)
			{
				_state = Turret.State.Move;
				CreateMoveTarget();
				LastMoveTime = Time.time;
			}	
			else
			{
				targetPlayer = GameObject.FindWithTag("Player");
			}
			break;
			
		case State.Move:
			if(Time.time > MovingTime + LastMoveTime)
			{
				_state = Turret.State.Search;
				MoveTarget = transform.position; 
				
			}else
			{
				float dis =Mathf.Abs( Vector3.Distance(MoveTarget,transform.position) );
				if(dis < 0.5f)
				{
					CreateMoveTarget();
				}else
				{
					Move();
				}
			}
			break;
		case State.Search:
			Vector3 diff2 = targetPlayer.transform.position - transform.position;
			if(Mathf.Abs(Vector3.Angle(Shooter.forward, diff2)) < 10.0f)
			{
				
				_state = Turret.State.Shot;
				
			}else
			{
				
				Shooter.Rotate(Vector3.up, Time.deltaTime * RotateSpeed);
				
			}
			
			break;
		case State.Shot:
			GetComponent<AudioSource>().Play();
			Instantiate(bullet, transform.position, transform.rotation);
			
			_state = Turret.State.Idle;
			break;
			
		}
		StateText.text = _state.ToString();
	}
	
	void OnGUI()
	{
		
		//GUI.Label(new Rect(10,10,200,20),_state.ToString());
		//Vector3 diff2 = targetPlayer.transform.position - transform.position;
		//GUI.Label(new Rect(10,30,200,20),Mathf.Abs(Vector3.Angle(transform.forward, diff2.normalized)).ToString());
		//GUI.Label(new Rect(10,50,200,20),MoveTarget.ToString());
		//GUI.Label(new Rect(10,70,200,20),MoveDirection.ToString());
		//GUI.Label(new Rect(10,90,200,20),transform.position.ToString());
	}
}
