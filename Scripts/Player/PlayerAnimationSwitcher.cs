using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationSwitcher : MonoBehaviour
{
    private Animator _animator;
    private PlayerInput _playerInput;
    private Vector2 _direction;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
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
        _animator.SetFloat("DirectionX", _direction.x);
        _animator.SetFloat("DirectionY", _direction.y);
    }

    public void WinningPosition()
    {
        _animator.SetFloat("DirectionX", 0);
        _animator.SetFloat("DirectionY", 0);
        _animator.Play("WinAnim");
    }
}
