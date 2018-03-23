//For Lecture

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tk2dAniController : MonoBehaviour {

    [HideInInspector]
    public tk2dSpriteAnimator animator_main; //애니메이션을 재생할 애니메이터

    protected Dictionary<AnimationType, Tk2dAniData> AnimationList; //애니메이션 컨트롤러를 쓰는 객체별로 자신에게 필요한 애니메이션을 담아둔다.

    protected Dictionary<AnimationType, string[]> animationNameList; //애니메이션 클립 리스트.

    protected string[] directionName; //방향 스트링 값 

    [HideInInspector]
    public int currDirection; //현재 방향
    [HideInInspector]
    public int currLevel = 1;
    public AnimationType currAnimation; //현재 애니메이션

    protected Vector3 originScale = Vector3.zero; //초기 scale
    protected Vector3 flipScale = Vector3.zero; //좌우반전을 위한 scale(x스케일에 -1을 곱한다)
    //unit
    public DirectionType directionType = DirectionType.End;
    public DirectionType[] rotationTypeList = new DirectionType[0];

    //building
    public Direction16WayType directionType16 = Direction16WayType.End;
    public Direction16WayType[] rotationTypeList16 = new Direction16WayType[0];
    bool isSkip = false;
    public int sortLayer = 0; //레이어 

    protected virtual void Awake()
    {
        animator_main = GetComponent<tk2dSpriteAnimator>();
        flipScale = originScale = transform.localScale;
        flipScale.x *= -1;
    }

    public virtual void Init(BuildingGroupID id)
    {

    }

    public virtual void Init(UnitType type)
    {

    }


    /// <summary>
    /// 레이어세팅
    /// </summary>
    /// <param name="layer">소팅레이어</param>
    public virtual void SetLayer(int layer)
    {

    }

    /// <summary>
    /// 객체 레벨에 맞게 tk2d 애니메이션을 로드하기 위한 스트링값을 미리 세팅한다 
    /// 건물,유닛등 특성에 따라 애니메이션에 방향이 없거나 애니메이션 동작이 추가,삭제 되어있으므로 그에 맞게 재정의해서 사용한다.
    /// </summary>
    /// <param name="lv">레벨</param>
    public virtual void SetAnimationForLevel(int lv)
    {
        currLevel = lv;
    }

    /// <summary>
    /// 현재 적용중인 애니메이션을 변경한다.
    /// </summary>
    /// <param name="type">애니메이션 종류</param>
    public virtual void ChangeAnimation(AnimationType type)
    {
        animator_main.Library = AnimationList[type].animation;
        currAnimation = type;
    }

    public virtual void UpdateAnimation()
    {
        if (isSkip == true)
        {
            return;
        }
        if (animator_main == null)
        {
            Debug.LogWarning(gameObject.name + "의 animator_main이 null입니다.", gameObject); isSkip = true;
            return;
        }

        animator_main.UpdateAnimation(Time.deltaTime);
    }

    /// <summary>
    /// 방향 변경
    /// </summary>
    /// <param name="type">방향</param>
    public virtual bool ChangeDirection(DirectionType type)
    {
        if ((int)type < 0 || (int)type > 7)
        {
            Debug.LogError("ChangeDirection Error:" + type.ToString());
        }
        bool retValue = false;
        if (this.directionType != type)
        {
            retValue = true; //바꼈다.
        }
        this.directionType = type;
        currDirection = (int)type;
        return retValue;
    }

    /// <summary>
    /// 16방향애니메이션 처리.
    /// </summary>
    /// <param name="type"></param>
    public virtual bool ChangeDirection16Way(Direction16WayType type)
    {
        if ((int)type < 0 || (int)type > 15)
        {
            Debug.LogError("ChangeDirection Error:" + type.ToString());
        }
        bool retValue = false;
        if (this.directionType16 != type)
        {
            retValue = true; //바꼈다.
        }
        this.directionType16 = type;
        currDirection = (int)type;
        return retValue;
    }

    /// <summary>
    /// 애니메이션 재생 - [현재애니메이션타입][현재방향]으로 구성된 문자열을 가지고 tk2d 애니메이터에서 클립을 재생한다.
    /// </summary>
    public virtual void PlayAnimation(bool bLoop = true)
    {
        if (animator_main == null)
        {
            Debug.Log(gameObject.name + "의 animator_main이 null입니다.");
            return;
        }
        animator_main.Stop();
        animator_main.Play(animationNameList[currAnimation][currDirection]);

        if (bLoop)
        {
            animator_main.CurrentClip.wrapMode = tk2dSpriteAnimationClip.WrapMode.Loop;
        }
        else
        {
            animator_main.CurrentClip.wrapMode = tk2dSpriteAnimationClip.WrapMode.Once;
        }
    }
}
