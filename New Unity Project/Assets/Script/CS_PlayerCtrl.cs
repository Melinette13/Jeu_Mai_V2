using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PlayerCtrl : MonoBehaviour
{
    public float speed = 10f;
    public float turn = 0.1f;
    float turnvelocity;
    public Transform camera;
    public CharacterController player;

    public float jumpHeight = 1.0f;
    private float gravity = -19.62f;

    public bool isGrounded;
    public LayerMask groundMask;

    public float groundDistance = 0.4f;

    private Vector3 velocity;
    public Transform groundOK;




    void Update()
    {

        // mouv
        float translation = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        float rotation = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        Vector3 direction = new Vector3(rotation, 0, translation).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float angleofview = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angleofview, ref turnvelocity, turn);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveindirection = Quaternion.Euler(0f, angleofview, 0f) * Vector3.forward;
            player.Move(moveindirection.normalized * speed * Time.deltaTime);
            transform.position += new Vector3(Mathf.Cos(angleofview) * speed * Time.deltaTime, 0f, Mathf.Sin(angleofview)) * speed * Time.deltaTime;
        }


        //jump

        isGrounded = Physics.CheckSphere(groundOK.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        //gravity
        velocity.y += gravity * Time.deltaTime;
        player.Move(velocity * Time.deltaTime);


    }
}
