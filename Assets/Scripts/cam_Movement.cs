using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float lookSpeed = 2f;

    float yaw = 0f;
    float pitch = 0f;

    void Update()
    {
        // Mouse Look
        yaw += lookSpeed * Input.GetAxis("Mouse X");
        pitch -= lookSpeed * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical"); 
        float upDown = 0f;

        if (Input.GetKey(KeyCode.E)) upDown = 1f;
        if (Input.GetKey(KeyCode.Q)) upDown = -1f;

        Vector3 direction = new Vector3(h, upDown, v);
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}