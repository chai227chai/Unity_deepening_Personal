using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine
{
    protected IState currentState;

    public void ChangeState(IState newstate)
    {
        currentState?.Exit();//이전 스테이트에서 빠져나올 때 실행되는 함수 

        currentState = newstate;

        currentState?.Enter();//새로운 스테이트에 진입할 때 실행되는 함수
    }

    public void HandleInput()
    {
        currentState?.HandleInput();//입력 값 처리
    }

    public void Update()
    {
        currentState?.UpDate();//스테이트 동작 실행
    }

    public void PhysicsUpdate()
    {
        currentState.PhysicsUpdate();//물리 동작 처리
    }
}
