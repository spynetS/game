using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float CurrentSensitivity;
    [SerializeField] private float DefaultSensitivity;
    [SerializeField] private float AimingSensitivity;

    [SerializeField] private float Rotate_X;
    [SerializeField] private float Rotate_Y;

    [SerializeField] private Transform Player;

    private void Start()
    {
        CurrentSensitivity = DefaultSensitivity;

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Rotate_X += Input.GetAxis("Mouse X") * CurrentSensitivity * Time.deltaTime;
        Rotate_Y -= Input.GetAxis("Mouse Y") * CurrentSensitivity * Time.deltaTime;

        Rotate_Y = Mathf.Clamp(Rotate_Y, -85, 85);

        Rotate();
    }

    private void Rotate()
    {
        transform.localRotation = Quaternion.Euler(Rotate_Y, 0, 0);
        Player.rotation = Quaternion.Euler(0, Rotate_X, 0);
    }
}
