using UnityEngine;

public interface IPlayerInput
{
    Vector3 GetLookDirection();
    Vector2 GetMovementDirection();
}