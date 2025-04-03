using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _jumpHeight;

    private float _jumpSpeed {  get { return Mathf.Sqrt((_jumpHeight * _rigidbody2d.gravityScale * Mathf.Abs(Physics2D.gravity.y)) * 2); } }


    private Rigidbody2D _rigidbody2d;

    private const float MINIMUM_SPEED = .005f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }


    public void MoveHorizontal(float velocityX)
    {
        _rigidbody2d.linearVelocityX = velocityX * _speed;
        if (Mathf.Abs(_rigidbody2d.linearVelocityX) < MINIMUM_SPEED)
        {
            _rigidbody2d.linearVelocityX = 0;
        }
    }

    public void Jump()
    {
        if(IsGrounded())
        {
            _rigidbody2d.linearVelocityY = _jumpSpeed;
        }
    }

    public void JumpRelease()
    {
        if (_rigidbody2d.linearVelocityY > 0)
        {
            _rigidbody2d.linearVelocityY /= 2;
        }
    }

    public bool IsGrounded()
    {
        return Mathf.Abs(_rigidbody2d.linearVelocityY) < MINIMUM_SPEED;
    }
}
