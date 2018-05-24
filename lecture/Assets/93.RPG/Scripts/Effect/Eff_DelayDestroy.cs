using UnityEngine;
using System.Collections;
namespace RPG
{
    public class Eff_DelayDestroy : MonoBehaviour
    {
        public float delayTime;
        public float destroyTime;
        public float createTime;

        // Use this for initialization
        void Start()
        {
            createTime = Time.time;
            OnRenderOnOff(false);

        }

        // Update is called once per frame
        void Update()
        {
            if (createTime + delayTime < Time.time)
            {
                OnRenderOnOff(true);
            }
            if (createTime + delayTime + destroyTime < Time.time)
            {
                Destroy(gameObject);
            }

        }

        void OnRenderOnOff(bool onoff)
        {
            MeshRenderer[] render = GetComponentsInChildren<MeshRenderer>();

            foreach (MeshRenderer ren in render)
            {
                ren.enabled = onoff;
            }
        }
    }
}


























