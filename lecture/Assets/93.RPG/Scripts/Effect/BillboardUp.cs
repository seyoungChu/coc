using UnityEngine;
using System.Collections;
namespace RPG
{
    public class BillboardUp : MonoBehaviour
    {

        private TextMesh textmesh;
        public float UpSpeed = 1.0f;

        void Awake()
        {
            textmesh = gameObject.GetComponent<TextMesh>();
        }
        void Update()
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y + Time.deltaTime * UpSpeed,
                                             transform.position.z);
            transform.LookAt(Camera.main.transform);
            transform.Rotate(new Vector3(0.0f, 180.0f, 0.0f));

        }
        public void SetText(string str)
        {
            if (textmesh == null)
            {
                textmesh = gameObject.GetComponent<TextMesh>();
            }

            textmesh.text = str; // text string change~
            textmesh.GetComponent<Renderer>().material.color = Color.red; // text color change~
        }

    }
}









