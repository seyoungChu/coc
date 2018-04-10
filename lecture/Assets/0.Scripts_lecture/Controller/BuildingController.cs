using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : BaseController
{
    public Transform myTarget = null;

    public tk2dAniController aniController;

    public override void FSM_SetUp()
    {
        this.myTarget = null;

    }

    public override void UpdateController()
    {
        fsm.CurrentState.DoCheck();
        fsm.CurrentState.DoAct();
        if (aniController != null)
        {
            aniController.UpdateAnimation();
        }
    }

    public void ChangeDirection(Direction16WayType newDir)
    {
        if (aniController != null)
        {
            aniController.ChangeDirection16Way(newDir);
            aniController.PlayAnimation();
        }
    }

	public override void Init(Entity owner)
	{
        base.Init(owner);

	}

}
