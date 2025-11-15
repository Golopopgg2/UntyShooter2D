using UnityEngine;

public class TransformMovement
{
    private Transform _transform;
    private float _speed;

    public TransformMovement(Transform transform, float speed)
    {
        _transform = transform;
        _speed = speed;
    }

    public void Move(Vector3 direction)
    {
        _transform.Translate(direction * _speed * Time.deltaTime, Space.World);
    }

    public void Rotate(Vector3 direction)
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
