using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed = 200.0f;

    public GameObject effect;


    // Update is called once per frame
    void Update()
    {

        Vector3 moveAmount = transform.up * speed * Time.deltaTime;
        transform.Translate(moveAmount);

        if (transform.position.y > 150.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject main = GameObject.Find("Main");
        GameControl gameControl = main.GetComponent<GameControl>();
        gameControl.AddPoint(100);
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }



}
