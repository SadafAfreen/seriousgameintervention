using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;

    PlayerControls playerControls;
    PlayerControls.GroundMovementActions groundMovement;

    Vector2 horizontalInput;

    private void Awake()
    {
        playerControls = new PlayerControls();
        groundMovement = playerControls.GroundMovement;

        // groungMovement.[action].performed += context => functionName
        groundMovement.Move.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
