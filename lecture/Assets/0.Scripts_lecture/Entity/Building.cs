using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Entity
{
    public EntityCategory category = EntityCategory.None;

    public EntityType myType = EntityType.None;

    public bool isSelect = false;

    public Vector3 originPos = Vector3.zero;
    public Vector3 lastPos = Vector3.zero;

    private Vector3 dragStartPos = Vector3.zero;
    private Vector3 dragEndPos = Vector3.zero;
    private List<Vector3> movePosList = new List<Vector3>();

    private int myGridIndex = 0;

    private tk2dSprite mySprite;


    public List<Grid> obstacle = new List<Grid>();

    public override void CashingObject()
    {
        myTransform = transform;
        mySprite = transform.Find("sprite").GetComponent<tk2dSprite>();

    }

    public override void InitEntity(EntityData data)
    {
        this.category = data.entCategory;
        this.myType = data.entType;
        this.level = data.Level;
        this.hp = data.HP;

        this.CreateBuildingControl();
    }

    public override void UpdateEntity()
    {
        if (isSelect == true)
        {
            DragUpdate();
        }
    }


    public void CreateBuildingControl()
    {

    }

    void DragUpdate()
    {
        //BuildingManager에서 가상으로 그려둔 타일맵기반으로 움직인다. 

        lastPos = myTransform.localPosition;

        InputManager.FingerInput current_input = InputManager.Instance.GetCurrentInput();
        if (current_input.currentRayHitTransform != null)
        {
            if (current_input.currentRayHitTransform.gameObject.layer == LayerMask.NameToLayer("Grid"))
            {
                Vector3 currentHitTransformPosition = current_input.currentRayHitTransform.position;
                if (lastPos != currentHitTransformPosition)
                {
                    if (movePosList.Contains(currentHitTransformPosition) == false)
                    {
                        movePosList.Add(currentHitTransformPosition);
                    }
                }
            }
            else
            {
                //Debug.LogWarning(LayerMask.LayerToName(current_input.currentRayHitTransform.gameObject.layer));
            }
        }

        if (movePosList.Count > 0)
        {
            myTransform.localPosition = movePosList[0];
            movePosList.RemoveAt(0);
        }

    }


}
