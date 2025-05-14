using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class TiltObject : MonoBehaviour
{
    //Public Variables
    public float RotationSpeed = 2.0f;

    //Private Variables
    public float xRotation;
    public float yRotation;
    public float zRotation;

    InputAction moveAction;
    Vector2 moveValue;

    //Variables End

    // Use this for initialization
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        xRotation = transform.rotation.x; yRotation = transform.rotation.y; zRotation = transform.rotation.z;
        moveValue = moveAction.ReadValue<Vector2>();
        if (moveValue.x != 0f || moveValue.y != 0f)
        {
            Tilt();
        }
    }

    private void Tilt()
    {
        transform.Rotate(new Vector3(xRotation + moveValue.y, yRotation, zRotation + moveValue.x));
    }
}
