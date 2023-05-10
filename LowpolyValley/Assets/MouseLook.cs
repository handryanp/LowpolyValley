using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100.0f; // sensitivitas mouse
public Transform playerBody; // referensi transform player

float xRotation = 0.0f; // rotasi kamera

void Start()
{
    Cursor.lockState = CursorLockMode.Locked; // mengunci kursor mouse pada layar
}

void Update()
{
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f); // membatasi rotasi kamera antara -90 sampai 90 derajat pada sumbu x

    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // rotasi kamera

    playerBody.Rotate(Vector3.up * mouseX); // rotasi pemain pada sumbu y (left/right)
}

}
