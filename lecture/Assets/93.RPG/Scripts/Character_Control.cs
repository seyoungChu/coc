using UnityEngine;
using System.Collections;
namespace RPG
{
    [RequireComponent(typeof(CharacterController))]
    public class Character_Control : MonoBehaviour
    {

        public float MoveSpeed = 5.0f;
        public float RotateSpeed = 500.0f;
        public float VerticalSpeed = 0.0f;
        private float gravity = 9.8f;

        public AnimationClip idleAnim;
        public AnimationClip walkAnim;
        public AnimationClip attackAnim;
        public AnimationClip skillAnim; //skill

        public float skillAnimSpeed = 1.0f; //related frame rate 

        private CharacterController charactercontroller;

        private Vector3 MoveDirection = Vector3.zero;
        private CollisionFlags collisionflag;
        public enum CharacterState
        {
            Idle = 0,
            Walk = 1,
            Attack = 2,
            Skill = 3,
            Size
        }
        private CharacterState _characterState = CharacterState.Idle;

        public GameObject skillEffect;


        // Use this for initialization
        void Start()
        {
            charactercontroller = gameObject.GetComponent<CharacterController>();

            GetComponent<Animation>().wrapMode = WrapMode.Loop;

            GetComponent<Animation>()[attackAnim.name].wrapMode = WrapMode.Once;
            GetComponent<Animation>()[attackAnim.name].layer = 1;

            GetComponent<Animation>()[skillAnim.name].wrapMode = WrapMode.Once;
            GetComponent<Animation>()[skillAnim.name].layer = 1;
            GetComponent<Animation>()[skillAnim.name].speed = skillAnimSpeed; //animation play speed 1.0 = 100%

            GetComponent<Animation>().Stop();

        }

        // Update is called once per frame
        void Update()
        {

            Move();

            CheckState();

            AnimationControl();

            BodyDirection();

            ApplyGravity();

        }
        void Move()
        {
            Transform cameraTransform = Camera.main.transform;

            Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
            forward = forward.normalized; //direction

            Vector3 right = new Vector3(forward.z, 0.0f, -forward.x);

            float v = Input.GetAxisRaw("Vertical");
            float h = Input.GetAxisRaw("Horizontal");

            Vector3 targetVector = v * forward + h * right;
            targetVector = targetVector.normalized;

            MoveDirection = Vector3.RotateTowards(MoveDirection, targetVector,
                                                  RotateSpeed * Mathf.Deg2Rad * Time.deltaTime,
                                                  1000.0f);
            MoveDirection = MoveDirection.normalized;

            Vector3 grav = new Vector3(0.0f, VerticalSpeed, 0.0f);

            Vector3 movementAmt = (MoveDirection * MoveSpeed * Time.deltaTime) + grav;

            collisionflag = charactercontroller.Move(movementAmt);


        }
        void CheckState()
        {
            if (_characterState == Character_Control.CharacterState.Attack
               || _characterState == CharacterState.Skill)
            {
                return;
            }

            if (charactercontroller.velocity.sqrMagnitude > 0.1)
            {
                //move
                _characterState = Character_Control.CharacterState.Walk;
            }
            else
            {
                _characterState = Character_Control.CharacterState.Idle;
            }

            if (Input.GetMouseButton(0)) //mouse left button
            {
                _characterState = CharacterState.Attack;
            }
            if (Input.GetMouseButton(1)) // mouse right button
            {
                Instantiate(skillEffect, transform.position, transform.rotation); //skill effect created
                _characterState = CharacterState.Skill;
            }

        }
        void AnimationControl()
        {
            switch (_characterState)
            {
                case CharacterState.Idle:
                    GetComponent<Animation>().CrossFade(idleAnim.name);
                    break;
                case CharacterState.Walk:
                    GetComponent<Animation>().CrossFade(walkAnim.name);
                    break;
                case CharacterState.Attack:
                    //90%
                    if (GetComponent<Animation>()[attackAnim.name].normalizedTime > 0.9f)
                    {
                        GetComponent<Animation>()[attackAnim.name].normalizedTime = 0.0f;
                        _characterState = Character_Control.CharacterState.Idle;
                    }
                    else
                    {
                        GetComponent<Animation>().CrossFade(attackAnim.name);
                    }

                    break;
                case CharacterState.Skill:
                    if (GetComponent<Animation>()[skillAnim.name].normalizedTime > 0.9f)
                    {
                        GetComponent<Animation>()[skillAnim.name].normalizedTime = 0.0f;
                        _characterState = CharacterState.Idle;
                    }
                    else
                    {
                        GetComponent<Animation>().CrossFade(skillAnim.name);
                    }

                    break;
            }
        }

        void BodyDirection()
        {
            Vector3 horizontalVelocity = charactercontroller.velocity;
            horizontalVelocity.y = 0.0f;
            if (horizontalVelocity.magnitude > 0.0f)
            {
                Vector3 trans = horizontalVelocity.normalized;
                transform.forward = Vector3.Lerp(transform.forward, trans, 0.5f);
            }
        }
        void OnGUI()
        {
            GUI.color = Color.red;
            GUI.Label(new Rect(10, 10, 100, 20), "state : " + _characterState.ToString());
            GUI.Label(new Rect(10, 30, 100, 20), "collision flag : " + collisionflag.ToString());

        }
        bool IsGrounded()
        {

            return (collisionflag & CollisionFlags.CollidedBelow) != 0;
        }
        void ApplyGravity()
        {
            if (IsGrounded())
            {
                VerticalSpeed = 0.0f; // on ground
            }
            else
            {
                //on air
                VerticalSpeed -= gravity * Time.deltaTime;
            }
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + transform.forward * 100.0f);

            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, transform.position + transform.up * 100.0f);

            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, transform.position + transform.right * 100.0f);


        }

    }
}



























