using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; 
    public float mouseSensitivity = 2f; 
    public float verticalLookLimit = 80f; 

    private float rotationX = 0f; 
    private float rotationY = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationY += mouseX;
        player.rotation = Quaternion.Euler(0, rotationY, 0);
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -verticalLookLimit, verticalLookLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}