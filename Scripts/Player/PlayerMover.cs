using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private PlayerInput _playerInput;
    private Vector2 _direction;

    private float _currentSpeed;

    private void Awake()
    {
        _currentSpeed = _speed;
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        _direction = _playerInput.Player.Move.ReadValue<Vector2>();
        Move(_direction);
    }

    private void Move(Vector2 direction)
    {
        float scaledMoveSpeed = _currentSpeed * Time.deltaTime;
        Vector3 move = new Vector3(direction.x, direction.y, 0);
        transform.position += move * scaledMoveSpeed;
    }

    public void IncreaseSpeed(float speed)
    {
        _currentSpeed = speed;
    }

    public void SetSpeedNormal()
    {
        _currentSpeed = _speed;
    }
}
