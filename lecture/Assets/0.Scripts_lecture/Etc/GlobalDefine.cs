using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{
    //게임상 오브젝트들의 레이어 정의
    public static readonly int LAYERMASK_UI = 1 << LayerMask.NameToLayer("UI"); //ui

    public static readonly int LAYERMASK_BUILDING = 1 << LayerMask.NameToLayer("Building"); //설치된 건물

    public static readonly int LAYERMASK_GRID = 1 << LayerMask.NameToLayer("Grid");

    public static readonly int LAYERMASK_ALL_PICKLAYER = LAYERMASK_UI | LAYERMASK_BUILDING; //모든레이어를 선택가능 - 테스트씬에서 사용

    public static readonly int LAYERMASK_REPLAY_PICKLAYER = LAYERMASK_UI;//리플레이 피킹레이어 - 리플레이에서는 월드맵을 직접 찍을 일이 없다.

    public static readonly int LAYERMASK_BATTLE_PICKLAYER = LAYERMASK_UI | LAYERMASK_BUILDING; //배틀전용 피킹레이어

    public static readonly int LAYERMASK_PICKLAYER = LAYERMASK_UI | LAYERMASK_BUILDING;//베이스맵 피킹 레이어
    
}
