using UnityEngine;
using System.Collections;

public class BeetleHPControl : MonoBehaviour {
	
	private TextMesh textMesh;
	public int BeetleHP = 200;
	private GameObject towerMang;
	private int towerId;
	
	void Start () {
		textMesh = gameObject.GetComponent<TextMesh>();
		textMesh.text = BeetleHP.ToString();
		towerMang = GameObject.Find("Towers");
	}
	void Update () {
		transform.LookAt(Camera.main.transform);
		transform.Rotate(Vector3.up, 180.0f);
	
	}
	public void Hited(int damage)
	{
		this.BeetleHP -= damage;
		if(this.BeetleHP <= 0 )
		{
			towerMang.SendMessage("EnemyDieToTower",this.towerId);
			Instantiate(Resources.Load("Prefabs/Explosion2"), transform.position, transform.rotation);
			Destroy(gameObject.transform.parent.gameObject);
		}
		textMesh.text = BeetleHP.ToString();
	}
	public void SetTowerID(int id)
	{
		this.towerId = id;
	}
}












