using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float MoveSpeed = 10.0f;
	private Vector3 targetPos;
	private Vector3 direction;
	// Use this for initialization
	void Awake () {
		targetPos = Vector3.zero;
	}
	void Start()
	{
		targetPos = GameObject.FindWithTag("Player").transform.position;
		Vector3 dir = targetPos - transform.position;		
		this.direction = dir.normalized;
		this.direction = new Vector3(this.direction.x, 0.0f,this.direction.z);
	}
	
	// Update is called once per frame
	void Update () {
		if(targetPos == Vector3.zero)
		{
			return;
		}
		
		transform.Translate(this.direction * MoveSpeed * Time.deltaTime,Space.World);
		if(transform.position.z > 11.0f)
		{
			Destroy(gameObject);
		}
		if(transform.position.z < -11.0f)
		{
			Destroy(gameObject);
		}
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			other.transform.gameObject.SendMessage("Hitted");
			Destroy(gameObject);
		}
	}
	
}
