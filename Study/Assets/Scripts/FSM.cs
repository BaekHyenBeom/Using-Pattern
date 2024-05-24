using System.Collections;
using UnityEngine;

public class FSM : MonoBehaviour
{
    private BaseState _baseState;
 
    public void InitFSM(BaseState baseState)
    {
        _baseState = baseState;
        StartCoroutine("State");
    }

    public void ChangeState(BaseState baseState)
    {
        StopCoroutine("State");
        _baseState.OnStateExit();
        _baseState = baseState;
        StartCoroutine("State");
    }

    IEnumerator State()
    {
        _baseState.OnStateEnter();

        while (true)
        {
            _baseState.OnStateUpdate();
            yield return new WaitForSeconds(1f);
        }
    }
}
