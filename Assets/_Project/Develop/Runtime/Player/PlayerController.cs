using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IPlayerInput _input;
    private float _speed = 5;

    private void Start()
    {
        _input = new PCPlayerInput();
    }

    private void Update()
    {
        Vector2 moveDirection = _input.GetMovementDirection();
        Vector2 lookDirection = (_input.GetLookDirection() - transform.position).normalized;

        transform.Translate(moveDirection * _speed * Time.deltaTime, Space.Self);

        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
