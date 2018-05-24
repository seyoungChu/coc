using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {
	
	bool lastUypdateWasHit;
	RaycastHit lastHit;
	public GameObject cubeObj;
	private GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		if(Physics.Raycast(ray,out hit, Mathf.Infinity) && lastUypdateWasHit != true)
		{
			//hit.collider.gameObject.renderer.material.color = Color.grey;
			lastHit = hit;
			lastUypdateWasHit = true;
			if(Input.GetMouseButtonUp(0) && player == null)
			{
				 player = Instantiate(cubeObj, hit.point, Quaternion.identity) as GameObject;
			}
			if(player != null)
			{
				player.SendMessage("SetNextPosition",hit.point);
			}
		}else
		{
			if(lastUypdateWasHit)
			{
				//lastHit.collider.gameObject.renderer.material.color = Color.red;
				lastUypdateWasHit = false;
				
			}
		}
		
	
	}
}
