using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] float speed = 11f;
    Vector2 horizontalInput;

    [SerializeField] float gravity = -30f; // -9.81f
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] LayerMask groungMask;
    bool isGrounded;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position - (new Vector3(0,transform.localScale.y,0)), 0.2f, groungMask);
        if (isGrounded)
        {
            verticalVelocity.y = 0;
        }

        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        characterController.Move(horizontalVelocity * Time.deltaTime);

        verticalVelocity.y += gravity * Time.deltaTime;
        characterController.Move(verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
        print(horizontalInput); 
    }
}
