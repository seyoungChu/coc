using UnityEngine;
using System.Collections;
namespace RPG
{
    public class Eff_OnceAnimationDestroy : MonoBehaviour
    {

        public float animationSpeed = 1.0f; //100% speed
        public AnimationClip clip;

        // Use this for initialization
        void Start()
        {
            GetComponent<Animation>().wrapMode = WrapMode.ClampForever;
            GetComponent<Animation>()[clip.name].layer = 10;
            GetComponent<Animation>()[clip.name].speed = animationSpeed;
            GetComponent<Animation>()[clip.name].enabled = false;

            GetComponent<Animation>().Stop();

        }

        // Update is called once per frame
        void Update()
        {

            if (GetComponent<Animation>()[clip.name].enabled == false)
            {
                GetComponent<Animation>()[clip.name].enabled = true;
            }
            if (GetComponent<Animation>()[clip.name].normalizedTime > 0.99f) //99%
            {
                Destroy(gameObject);
            }


        }
    }
}



















