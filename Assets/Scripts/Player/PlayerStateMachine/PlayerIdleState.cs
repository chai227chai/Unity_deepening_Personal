using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.MovementSpeedModifier = 0f;
        base.Enter();
        StartAnimation(stateMachine.Player.AnimationData.IdleParameter);
    }

    public override void Exit()
    {
        base.Exit();
        StartAnimation(stateMachine.Player.AnimationData.IdleParameter);
    }

    protected override void OnRunStarted(InputAction.CallbackContext obj)
    {
        if(stateMachine.MovementInput == Vector2.zero)
        {
            return;
        }

        base.OnRunStarted(obj);
        stateMachine.ChangeState(stateMachine.RunState);
    }

    public override void UpDate()
    {
        base.UpDate();

        if(stateMachine.MovementInput != Vector2.zero)//이동 입력이 들어왔다면
        {
            OnMove();
            return;
        }
    }
}
