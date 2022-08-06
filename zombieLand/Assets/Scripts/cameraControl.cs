using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Transform target;
    float mouseSpeed=4;
    float mouseY, mouseX;
    float minY = -40, maxY = 40;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position, .3f);

        mouseX += Input.GetAxis("Mouse X") * mouseSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * mouseSpeed;
        this.transform.localRotation = Quaternion.Euler(0, mouseX, 0);
        mouseY = Mathf.Clamp(mouseY, minY, maxY);
        transform.GetChild(0).localRotation = Quaternion.Euler(mouseY, 0, 0);
    }
}
