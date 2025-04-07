using System.Collections.Generic;
using UnityEngine;

public class LightField : MonoBehaviour, IColorChange
{
    [SerializeField]
    private ColorActivated[] _linkedItems;

    [SerializeField]
    private ColorState.State _firstState;

    private SpriteRenderer _spriteRenderer;

    private ColorState.State _currentState;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _currentState = _firstState;
        SetColor(_currentState);
    }

    public void SetColor(ColorState.State state)
    {
        foreach (ColorActivated change in _linkedItems)
        {
            change.BackgroundColorChanged(state);
        }

        _currentState = state;
        _spriteRenderer.color = ColorState.StateColors[(int)state];
    }

}
