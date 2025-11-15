using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IPlayerInput _input;
    private TransformMovement _mover;
    private ProjectileShooter _shooter;
    private float _speed = 5;

    private void Start()
    {
        _input = new PCPlayerInput();
        _mover = new TransformMovement(transform, _speed);
        _shooter = new ProjectileShooter();
    }

    private void Update()
    {
        Vector2 moveDirection = _input.GetMovementDirection();
        Vector2 lookDirection = (_input.GetLookDirection() - transform.position).normalized;

        _mover.Move(moveDirection);
        _mover.Rotate(lookDirection);

        if (_input.IsShootKeyPressed())
        {
            _shooter.Shoot();
        }
    }
}
