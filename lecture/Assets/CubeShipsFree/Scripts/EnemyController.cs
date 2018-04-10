using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 30.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveAmount = transform.up * speed * Time.deltaTime;
        transform.Translate(moveAmount);


        if (transform.position.y < -150.0f)
        {
            transform.position = new Vector3(Random.Range(-90.0f, 90.0f), 90.0f, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(Random.Range(-90.0f, 90.0f), 90.0f, 0.0f);
    }


}
