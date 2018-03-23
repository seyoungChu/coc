//For Lecture

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniControllerNormalUnit : tk2dAniController
{


    UnitBasicData data;
    UnitData unitdata;
    //    UnitType myType;

    protected override void Awake()
    {
        base.Awake();
    }

    /// <summary>
    /// AnimationList,animationNameList를 각 객체에 맞게 세팅한다.
    /// </summary>
    public override void Init(UnitType type)
    {
        //    myType = type;

        if (animator_main == null)
        {
            animator_main = transform.Find("nd_cha_main").gameObject.AddComponent<tk2dSpriteAnimator>();
        }

        AnimationList = new Dictionary<AnimationType, Tk2dAniData>();

        animationNameList = new Dictionary<AnimationType, string[]>();

        directionName = new string[8];

        //방향별 스트링 지정
        directionName[0] = "n";
        directionName[1] = "ne";
        directionName[2] = "e";
        directionName[3] = "se";
        directionName[4] = "s";
        directionName[5] = "sw";
        directionName[6] = "w";
        directionName[7] = "nw";

        //애니메이션이름을 보관할 리스트 - idle,walk,attack
        string[] idlelist = new string[8];
        string[] walklist = new string[8];
        string[] attacklist = new string[8];

        animationNameList.Add(AnimationType.Idle, idlelist);
        animationNameList.Add(AnimationType.Walk, walklist);
        animationNameList.Add(AnimationType.Attack, attacklist);

        //현재방향,애니메이션 지정
        currDirection = (int)DirectionType.SE;
        currAnimation = AnimationType.Idle;

        //data = DataManager.GetUnitBasicData(type);

        //AnimationList.Add(AnimationType.Idle, DataManager.Animation((Tk2dAnimationType)data.idle_ani));
        //AnimationList.Add(AnimationType.Walk, DataManager.Animation((Tk2dAnimationType)data.walk_ani));
        //AnimationList.Add(AnimationType.Attack, DataManager.Animation((Tk2dAnimationType)data.attack_ani));

        //animator_main.Library = DataManager.Animation((Tk2dAnimationType)data.idle_ani).animation;

    }

    /// <summary>
    /// 레벨에 따른 애니메이션 이름을 세팅한다. - 이 이름으로 애니메이션 재생클립을 호출한다.
    /// </summary>
    /// <param name="lv"></param>
    public override void SetAnimationForLevel(int lv)
    {
        //unitdata = DataManager.GetUnitData(data.unit_group_ID + lv);

        string level = "lv" + lv.ToString(); //스트링변환 레벨 2라면 -> lv2

        //빌딩프리팹 모음
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        //idle애니메이션 이름 조합
        for (int i = 0; i < 8; ++i)
        {
            sb.Append(level);
            sb.Append("_");
            sb.Append(AnimationList[AnimationType.Idle].key);
            sb.Append("_");
            sb.Append(directionName[i]);
            animationNameList[AnimationType.Idle][i] = sb.ToString();
            sb.Remove(0, sb.Length);
        }

        //walk애니메이션 이름 조합
        for (int i = 0; i < 8; ++i)
        {
            sb.Append(level);
            sb.Append("_");
            sb.Append(AnimationList[AnimationType.Walk].key);
            sb.Append("_");
            sb.Append(directionName[i]);
            animationNameList[AnimationType.Walk][i] = sb.ToString();
            sb.Remove(0, sb.Length);
        }

        //attack애니메이션 이름 조합
        for (int i = 0; i < 8; ++i)
        {
            sb.Append(level);
            sb.Append("_");
            sb.Append(AnimationList[AnimationType.Attack].key);

            //가드맨은 공격에 방향이 없으므로 방향추가를 하지 않는다.(lv1_attack)
            if (data.unit_group_ID != (int)UnitType.GuardsMan)
            {
                sb.Append("_");
                sb.Append(directionName[i]);
            }

            animationNameList[AnimationType.Attack][i] = sb.ToString();
            sb.Remove(0, sb.Length);
        }

    }
}
