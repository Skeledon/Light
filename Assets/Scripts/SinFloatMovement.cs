using UnityEngine;

public class SinFloatMovement : MonoBehaviour
{
    [SerializeField]
    private float _period;

    [SerializeField]
    private float _amplitude;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float _higherValue;

    private float _lowerValue;

    private float _currentTime;

    private Transform t;


    void Start()
    {
        t = transform;
        _higherValue = t.position.y + _amplitude;
        _lowerValue = t.position.y - _amplitude;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
