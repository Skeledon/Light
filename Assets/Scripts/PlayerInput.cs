using UnityEngine;
using Rewired;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private int _playerIndex;

    [SerializeField]
    private PlayerController _controller;

    private Player _player;

    void Awake()
    {
        _player = ReInput.players.GetPlayer(_playerIndex);
    }

    private void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        _controller.MoveHorizontal(_player.GetAxis("MoveX"));

        if(_player.GetButtonDown("Jump"))
        {
            _controller.Jump();
        }
        if (_player.GetButtonUp("Jump"))
        {
            _controller.JumpRelease();
        }
    }
    
}
