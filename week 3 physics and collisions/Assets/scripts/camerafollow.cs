using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the marble (player)
    public float smoothSpeed = 0.125f; // Speed at which the camera follows the player
    public Vector3 offset; // Offset to maintain distance from the marble

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calculate desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smooth the transition
        transform.position = smoothedPosition; // Update camera position
    }
}
