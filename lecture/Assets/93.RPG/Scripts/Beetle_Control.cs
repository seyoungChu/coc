using UnityEngine;
using System.Collections;
namespace RPG
{
    public class Beetle_Control : MonoBehaviour
    {

        public Vector3 targetPos = Vector3.zero;
        public float MoveSpeed = 5.0f;

        public GameObject hitEffect;
        public GameObject damageEffect;
        public GameObject dieEffect;

        public AnimationClip DieAnim;

        public int HP = 100;

        public enum BeetleState
        {
            Idle = 0,
            Walk = 1,
            Attack = 2,
            Hit = 3,
            Dead = 4,
            Size
        }
        private BeetleState state = BeetleState.Idle;

        // Use this for initialization
        void Start()
        {
            GetComponent<Animation>().wrapMode = WrapMode.Loop;

            GetComponent<Animation>()[DieAnim.name].wrapMode = WrapMode.Once;
            GetComponent<Animation>()[DieAnim.name].layer = 1;

            GetComponent<Animation>().Play("move");
        }

        // Update is called once per frame
        void Update()
        {
            if (CheckState())
                return;
            SearchTarget();


            Vector3 currentPos = transform.position;
            Vector3 diffPos = targetPos - currentPos;
            if (diffPos.magnitude < 2.0f)
            {
                return;
            }
            diffPos = diffPos.normalized;
            transform.Translate(diffPos * Time.deltaTime * MoveSpeed, Space.World);
            //target billboard
            transform.LookAt(targetPos);

        }

        void SearchTarget()
        {
            GameObject target = GameObject.FindWithTag("Player");
            targetPos = target.transform.position;
        }

        void OnGUI()
        {
            GUI.color = Color.red;
            GUI.Label(new Rect(Screen.width - 100, 10, 100, 20), state.ToString());
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "AttackCol")
            {
                int damage = Random.Range(10, 30);
                CheckHP(damage);
                //state = Beetle_Control.BeetleState.Hit;
                Instantiate(hitEffect, transform.position, transform.rotation);

                GameObject damageObj = Instantiate(damageEffect, transform.position, transform.rotation) as GameObject;
                if (damageObj != null)
                {
                    damageObj.SendMessage("SetText", damage.ToString());
                }

            }
        }
        void CheckHP(int damage)
        {
            this.HP -= damage;
            if (this.HP <= 0 && state != Beetle_Control.BeetleState.Dead)
            {
                state = Beetle_Control.BeetleState.Dead;

                GetComponent<Animation>().Stop();
                GetComponent<Animation>().CrossFade(DieAnim.name);

            }
        }

        bool CheckState()
        {
            bool isDead = false;
            switch (state)
            {
                case BeetleState.Dead:
                    isDead = true;
                    if (GetComponent<Animation>()[DieAnim.name].normalizedTime > 0.95f)
                    {
                        Instantiate(dieEffect, transform.position, transform.rotation);
                        Destroy(gameObject);
                    }
                    break;

            }
            return isDead;
        }
    }

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
