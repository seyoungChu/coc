using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {
	Vector3 nextPos;
	public float MoveSpeed  = 5.0f;
	private float StartTime;
	private int Score;
	private int Lives;
	public GUISkin myskin;
	// Use this for initialization
	void Start () {
		nextPos = Vector3.zero;
		StartTime = Time.time;
		Lives = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!nextPos.Equals(Vector3.zero))
		{
			transform.position = Vector3.Lerp(transform.position,nextPos,0.5f*Time.deltaTime*MoveSpeed);
		}
	
	}
	
	public void SetNextPosition(Vector3 pos)
	{
		nextPos = pos;
	}
	
	void OnGUI()
	{
		
		GUI.skin = myskin;
		Score = (int)(Time.time - StartTime);
		GUI.Label(new Rect(10,10,200,40),"Score : " + Score.ToString());
		GUI.Label(new Rect(10,50,200,40),"Lives : " + Lives.ToString());
	}
	public void Hitted()
	{
		Lives -= 1;
		GetComponent<AudioSource>().Play();
	}
}
