using UnityEngine;
using System.Collections;

public class BeetleControl : MonoBehaviour {
	
	public float BeetleSpeed = 1.0f;
	private Vector3[] TargetPos = new Vector3[10];
	private int AddedIndex = 0;
	private int CurrentTargetIndex = 0;
	
	// Use this for initialization
	void Start () {
		GetComponent<Animation>().wrapMode = WrapMode.Loop;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 Diff = TargetPos[CurrentTargetIndex] - transform.position;
		if(Diff.magnitude < 0.1f)
		{
			if(TargetPos.Length-1 > CurrentTargetIndex)
			{
				CurrentTargetIndex++;
				if(TargetPos[CurrentTargetIndex] == Vector3.zero)
				{
					Destroy(gameObject);
				}
				return;
			
			}else
			{
				Destroy(gameObject);
				return;
			}
		}
		
		Vector3 Direction = Diff.normalized;
		transform.Translate(Direction * Time.deltaTime * BeetleSpeed, Space.World);
		transform.LookAt(TargetPos[CurrentTargetIndex]);
		
	}
	
	public void SetTargetPos(Vector3 tpos)
	{
		this.TargetPos[AddedIndex] = tpos;
		AddedIndex++;
	}
	

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
