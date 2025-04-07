using UnityEngine;

public class RotationMovement : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
    }
}
