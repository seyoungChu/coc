using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingState_IDLE : FSMState
{
    BuildingController Owner;

    public BuildingState_IDLE(BuildingController _owner)
    {
        base.controller = _owner;
        this.Owner = _owner;
        stateID = StateID.IDLE;
    }

    public override void DoBeforeEntering()
    {
        base.DoBeforeEntering();
    }

    public override void DoCheck()
    {
        if (this.changeState == true)
        {
            Owner.SetTransition(Transition.IdleToSearch);
        }
    }

    public override void DoAct()
    {
        if (Owner.gameObject.activeSelf == true)
        {
            this.changeState = true;
        }
    }

    public override void DoBeforeLeaving()
    {
        this.changeState = false;
    }
}

public class BuildingState_TargetFind : FSMState
{
    BuildingController Owner;
    Transform target = null;

    public BuildingState_TargetFind(BuildingController _owner)
    {
        base.controller = _owner;
        this.Owner = _owner;
        stateID = StateID.SEARCH;

    }

    public override void DoBeforeEntering()
    {
        target = null;
    }

    public override void DoCheck()
    {
        if (this.changeState == true)
        {
            Owner.SetTransition(Transition.SearchToAttack);
        }
    }

    public override void DoAct()
    {
        float searchRange = Owner.OwnerEntity.searchRange;
        target = EntityManager.Instance.GetCloseEntity(Owner.transform.position, searchRange, EntityType.Unit);
        if (target != null)
        {
            this.changeState = true;
            Owner.myTarget = target;
        }
    }

    public override void DoBeforeLeaving()
    {
        this.changeState = false;
    }
}

public class BuildingState_Attack : FSMState
{
    BuildingController Owner;
    Entity target;

    public BuildingState_Attack(BuildingController Owner)
    {
        base.controller = Owner;
        this.Owner = Owner;
        stateID = StateID.ATTACK;
    }

	public override void DoBeforeEntering()
	{
        base.DoBeforeEntering();
	}

	public override void DoCheck()
	{
        throw new NotImplementedException();
	}

	public override void DoAct()
	{
        throw new NotImplementedException();
	}

	public override void DoBeforeLeaving()
	{
        base.DoBeforeLeaving();
	}

}


