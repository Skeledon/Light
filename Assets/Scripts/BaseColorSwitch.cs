using UnityEngine;

public class BaseColorSwitch : MonoBehaviour
{
    [SerializeReference]
    private ColorChange[] _toColorChange;

    [SerializeField]
    protected ColorState.State[] _stateOrder;

    [SerializeField]
    protected int _firstState;

    protected int _currentState;

    protected virtual void Awake()
    {
        _currentState = _firstState;
    }

    public virtual void ChangeColors(ColorState.State state)
    {
        foreach (var colorChange in _toColorChange)
        {
            colorChange.SetColor(state);
        }
    }
}
