using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //자유 구현
    protected FSM _fsm;

    public IdleState _idle;
    public MoveState _move;
    public RunState _run;
}
