using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Entity
{
    public EntityCategory category = EntityCategory.None;

    public EntityType myType = EntityType.None;

    public bool isSelect
    {
        set
        {
            if (_isSelect == false && value == true)
            {
                if (myCollider != null)
                {
                    myCollider.enabled = false;
                }
            }
            if (_isSelect == true && value == false)
            {
                if (myCollider != null)
                {
                    myCollider.enabled = true;
                }
            }
            _isSelect = value;
        }
        get
        {
            return _isSelect;
        }
    }
    private bool _isSelect = false;
    public Vector3 originPos = Vector3.zero;
    public Vector2 lastPos = Vector2.zero;

    private Vector3 dragStartPos = Vector3.zero;
    private Vector3 dragEndPos = Vector3.zero;
    private List<Vector2> movePosList = new List<Vector2>();

    private int myGridIndex = 0;

    private tk2dSprite mySprite;
    private BoxCollider2D myCollider;



    public List<Grid> obstacle = new List<Grid>();

    public override void CashingObject()
    {
        myTransform = transform;
        mySprite = transform.Find("sprite").GetComponent<tk2dSprite>();
        myCollider = gameObject.GetComponent<BoxCollider2D>();
        if (myCollider == null)
        {
            myCollider = gameObject.AddComponent<BoxCollider2D>();
        }

    }

    public override void InitEntity(EntityData data)
    {
        this.category = data.entCategory;
        this.myType = data.entType;
        this.level = data.Level;
        this.hp = data.HP;
        this.searchRange = data.SearchRange;

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
                Vector2 currentHitTransformPosition = current_input.currentRayHitTransform.position;
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
            myTransform.localPosition = new Vector3(movePosList[0].x, movePosList[0].y, -1.0f);
            movePosList.RemoveAt(0);
        }

    }


}
