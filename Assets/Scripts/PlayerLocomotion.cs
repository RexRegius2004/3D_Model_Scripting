using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    Vector3 moveDirection;
    Transform cameraObject;

    public void Start()
    {
        cameraObject = Camera.main.transform;
    }
    public void HandlesAllMovement()
    {
        HandlesMovement();
        HandlesRotation();
    }

    private void HandlesMovement()
    {
        moveDirection = cameraObject.forward * PlayerManager.Instance.inputManager.verticalinput;
        moveDirection = cameraObject.right * PlayerManager.Instance.inputManager.verticalinput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * PlayerManager.Instance.moveSpeed;
        Vector3 movementVelocity = moveDirection;
        PlayerManager.Instance.rigidbody.velocity = movementVelocity;
    }
    private void HandlesRotation()
    {

    }
}
