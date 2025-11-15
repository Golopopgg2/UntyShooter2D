using UnityEngine;

public class PCPlayerInput : IPlayerInput
{
    public Vector2 GetMovementDirection()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log("Horizontal: " + horizontalInput);
        Debug.Log("Vertical: " + verticalInput);

        return new Vector2(horizontalInput, verticalInput);
    }

    public Vector3 GetLookDirection()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePosition);

        return worldMousePos;
    }
}
