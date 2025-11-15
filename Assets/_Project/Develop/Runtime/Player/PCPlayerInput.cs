using UnityEngine;

public class PCPlayerInput : IPlayerInput
{
    public Vector2 GetMovementDirection()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        return new Vector2(horizontalInput, verticalInput);
    }

    public Vector3 GetLookDirection()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePosition);

        return worldMousePos;
    }

    public bool IsShootKeyPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
