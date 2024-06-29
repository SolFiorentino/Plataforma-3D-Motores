using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 720f; // Grados por segundo
    public float jumpForce = 5f; // Fuerza del salto

    private Rigidbody rb;
    private Vector3 movement;
    private float targetAngle;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        if (movement.magnitude >= 0.1f)
        {
            targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
        }

        // Saltar
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        if (movement.magnitude >= 0.1f)
        {
            // Rotación del jugador
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSpeed, 0.1f);
            rb.MoveRotation(Quaternion.Euler(0, angle, 0));

            // Movimiento del jugador
            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        // Verificar si el jugador está tocando el suelo por etiqueta
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Verificar si el jugador deja de tocar el suelo por etiqueta
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}




