using UnityEngine;

public class BallTriggerColorSwitch : BaseColorSwitch
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        _currentState++;
        _currentState %= _stateOrder.Length;
        ChangeColors(_stateOrder[_currentState]);
    }
}
