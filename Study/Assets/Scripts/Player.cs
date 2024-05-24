using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    private bool isWalk = false;
    private bool isRun = false;

    void Awake()
    {
        _idle = new IdleState(this);
        _move = new MoveState(this);
        _run = new RunState(this);

        _fsm = GetComponent<FSM>();
    }

    void Start()
    {
        _fsm.InitFSM(_idle);
    }

    private void FSMActive()
    {
        if (isWalk && isRun)
        {
            _fsm.ChangeState(_run);
        }
        else if (isWalk)
        {
            _fsm.ChangeState(_move);
        }
        else
        {
            _fsm.ChangeState(_idle);
        }
    }

    private void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        if (direction != Vector2.zero)
        {
            isWalk = true;
            FSMActive();
        }
        else
        {
            isWalk = false;
            FSMActive();
        }
    }

    private void OnDash(InputValue value)
    {
        isRun = value.isPressed;
        FSMActive();
    }
}
