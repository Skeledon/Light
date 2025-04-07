using UnityEngine;

public class ColorWall : MonoBehaviour
{
    [SerializeField]
    private ColorState.State _state;

    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
        GetComponent<SpriteRenderer>().color = ColorState.StateColors[(int)_state];
    }
    public void BackgroundColorChanged(ColorState.State state)
    {
        if (_state == state)
        {
            _collider.enabled = false;
        }
        else
        {
            _collider.enabled = true;
        }
    }


}
