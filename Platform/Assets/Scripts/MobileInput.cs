using UnityEngine;

public class MobileInput : MonoBehaviour
{
    public void MoveLeftStart() => VirtualInput.Horizontal = -1f;
    public void MoveRightStart() => VirtualInput.Horizontal = 1f;
    public void StopMoving() => VirtualInput.Horizontal = 0f;
    public void Jump() => VirtualInput.JumpPressed = true;
}
