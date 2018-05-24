using UnityEngine;
using System.Collections;
namespace RPG
{
    public class Spawner : MonoBehaviour
    {

        public float spawnTime = 0.5f;
        public float lastTime;
        public GameObject monster;

        // Use this for initialization
        void Start()
        {
            lastTime = Time.time;
        }

        // Update is called once per frame
        void Update()
        {
            if (Time.time > spawnTime + lastTime)
            {
                lastTime = Time.time;
                Instantiate(monster, transform.position, transform.rotation);
            }

        }
    }
}











