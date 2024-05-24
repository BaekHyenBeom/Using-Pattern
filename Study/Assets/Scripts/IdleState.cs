using UnityEngine;
using UnityEngine.TextCore.Text;

public class IdleState : BaseState
{
    public IdleState(Character character) : base(character)
    {

    }

    public override void OnStateEnter()
    {
        Debug.Log("정지 Start");
    }

    public override void OnStateExit()
    {
        Debug.Log("정지 End");
    }

    public override void OnStateUpdate()
    {
        Debug.Log("정지 Now");
    }
}

public class MoveState : BaseState
{
    public MoveState(Character character) : base(character)
    {

    }

    public override void OnStateEnter()
    {
        Debug.Log("걷기 Start");
    }

    public override void OnStateExit()
    {
        Debug.Log("걷기 End");
    }

    public override void OnStateUpdate()
    {
        Debug.Log("걷기 Now");
    }
}

public class RunState : BaseState
{
    public RunState(Character character) : base(character)
    {

    }

    public override void OnStateEnter()
    {
        Debug.Log("달리기 Start");
    }

    public override void OnStateExit()
    {
        Debug.Log("달리기 End");
    }

    public override void OnStateUpdate()
    {
        Debug.Log("달리기 Now");
    }
}