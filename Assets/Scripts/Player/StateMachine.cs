using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine
{
    protected IState currentState;

    public void ChangeState(IState newstate)
    {
        currentState?.Exit();//���� ������Ʈ���� �������� �� ����Ǵ� �Լ� 

        currentState = newstate;

        currentState?.Enter();//���ο� ������Ʈ�� ������ �� ����Ǵ� �Լ�
    }

    public void HandleInput()
    {
        currentState?.HandleInput();//�Է� �� ó��
    }

    public void Update()
    {
        currentState?.UpDate();//������Ʈ ���� ����
    }

    public void PhysicsUpdate()
    {
        currentState.PhysicsUpdate();//���� ���� ó��
    }
}
