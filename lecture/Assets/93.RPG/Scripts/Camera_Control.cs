using UnityEngine;
using System.Collections;
namespace RPG
{

    public class Camera_Control : MonoBehaviour
    {
        // first view point var
        public enum RotationAxes { MouseXandY = 0, MouseX = 1, MouseY = 2 }
        public RotationAxes axes = RotationAxes.MouseXandY;

        public float sensitivityX = 15.0f;
        public float sensitivityY = 15.0f;

        public float minimumX = -360.0f;
        public float maximumX = 360.0f;

        public float minimumY = -60.0f;
        public float maximumY = 60.0f;

        public float rotationX = 0.0f;
        public float rotationY = 0.0f;

        public GameObject viewCameraPositionObject;



        // third view point var
        public float distance = 10.0f;
        public float height = 5.0f;
        public float heightDamping = 2.0f;
        public float rotationDamping = 3.0f;
        // maybe player...
        public GameObject target;


        public float RotateSpeed = 10.0f;

        public enum CameraViewPointState
        {
            First = 0,
            Second = 1,
            Third = 2,
        }
        public CameraViewPointState state = CameraViewPointState.Third;

        void LateUpdate()
        {
            switch (state)
            {
                case CameraViewPointState.Third:
                    ThirdView();
                    break;
                case CameraViewPointState.Second:
                    SecondView();
                    break;
                case CameraViewPointState.First:
                    FirstView();
                    break;

            }
        }
        void ThirdView()
        {
            if (target == null)
            {
                SearchTarget();
            }

            float wantedRotationAngle = target.transform.eulerAngles.y;
            float wantedHeight = target.transform.position.y + height;

            float currentRotationAngle = transform.eulerAngles.y;
            float currentHeight = transform.position.y;

            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle,
                                                   rotationDamping * Time.deltaTime);
            currentHeight = Mathf.Lerp(currentHeight, wantedHeight,
                                       heightDamping * Time.deltaTime);

            Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

            transform.position = target.transform.position;
            transform.position -= currentRotation * Vector3.forward * distance;

            transform.position = new Vector3(transform.position.x,
                                             currentHeight,
                                             transform.position.z);

            transform.LookAt(target.transform);




        }
        bool SearchTarget()
        {
            bool isFind = false;
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                isFind = true;
                target = player;
            }
            return isFind;
        }
        public void ChangeCameraState(CameraViewPointState Cstate)
        {
            this.state = Cstate;

            if (this.state == Camera_Control.CameraViewPointState.First)
            {
                if (gameObject.GetComponent<Rigidbody>())
                {
                    gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                }
            }
            else if (this.state == Camera_Control.CameraViewPointState.Second)
            {
                if (gameObject.GetComponent<Rigidbody>())
                {
                    gameObject.GetComponent<Rigidbody>().freezeRotation = false;
                }
            }
            else if (this.state == Camera_Control.CameraViewPointState.Third)
            {
                if (gameObject.GetComponent<Rigidbody>())
                {
                    gameObject.GetComponent<Rigidbody>().freezeRotation = false;
                }
            }

        }
        void FirstView()
        {
            if (axes == Camera_Control.RotationAxes.MouseXandY)
            {
                //MouseX and MouseY
                rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);

            }
            else if (axes == Camera_Control.RotationAxes.MouseX)
            {
                //MouseX
                transform.localEulerAngles = new Vector3(0,
                                                         transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX,
                                                         0);

            }
            else
            {
                //MouseY
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                transform.localEulerAngles = new Vector3(-rotationY,
                                                         transform.localEulerAngles.y,
                                                         0);


            }

            transform.position = viewCameraPositionObject.transform.position;
        }
        void SecondView()
        {
            transform.RotateAround(target.transform.position, Vector3.up,
                                   Time.deltaTime * RotateSpeed);
            transform.LookAt(target.transform);
        }


    }

}














