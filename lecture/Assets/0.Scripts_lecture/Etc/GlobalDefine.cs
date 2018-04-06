using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{
    //게임상 오브젝트들의 레이어 정의
    public static readonly int LAYERMASK_UI = 1 << LayerMask.NameToLayer("UI"); //ui

    public static readonly int LAYERMASK_BUILDING = 1 << LayerMask.NameToLayer("Building"); //설치된 건물

    public static readonly int LAYERMASK_GRID = 1 << LayerMask.NameToLayer("Grid");

    public static readonly int LAYERMASK_ALL_PICKLAYER = LAYERMASK_UI | LAYERMASK_BUILDING | LAYERMASK_GRID; //모든레이어를 선택가능 - 테스트씬에서 사용

    public static readonly int LAYERMASK_REPLAY_PICKLAYER = LAYERMASK_UI;//리플레이 피킹레이어 - 리플레이에서는 월드맵을 직접 찍을 일이 없다.

    public static readonly int LAYERMASK_BATTLE_PICKLAYER = LAYERMASK_UI | LAYERMASK_BUILDING; //배틀전용 피킹레이어

    public static readonly int LAYERMASK_PICKLAYER = LAYERMASK_UI | LAYERMASK_BUILDING;//베이스맵 피킹 레이어

    public static readonly Vector3 EXCEPT_POSITON = new Vector3(-10000.0f, -10000.0f, -10000.0f);
    
}

public class Grid
{
    public bool isObstacle = false;
    public bool isPathObstacle = false;
    public GameObject gridObject = null;
    public Vector3 position;
    public Building building;
    public int column;
    public int row;

    public Grid(Vector3 pos)
    {
        this.position = pos;
    }

    public void SetColRow(int col, int row)
    {
        this.column = col;
        this.row = row;
    }

    public void Release()
    {
        this.isObstacle = false;
        this.isPathObstacle = false;
        this.building = null;
    }

    public void MarkAsObstacle(Building building)
    {
        this.building = building;
        this.isObstacle = true;
    }

}


public enum EntityCategory : int
{
    None = -1,
    WatchTower = 10000,
    Creed = 20000,
    Max
}

public enum EntityType : int
{
    None = -1,
    Normal,
    Unit,
    Defense,
    Resource,
    Max
}

public class EntityData
{
    public EntityCategory entCategory;
    public EntityType entType;
    public int HP;
    public int Level;

}
