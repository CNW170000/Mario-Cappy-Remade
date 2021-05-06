using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float _rotationSpeed = 6f;
    public float diveDistance = 10f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 rotation;

    Vector3 impact = Vector3.zero;
    Vector3 velocity;
    bool isGrounded;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 18f;
        }
        else
        {
            speed = 12f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * 25*Time.deltaTime, 0);

        this.transform.Rotate(this.rotation);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            SoundControl.PlaySound("Jump");
        }

        if (Input.GetButtonDown("Fire2") && isGrounded == false)
        {
            Vector3 dive = transform.forward * diveDistance;
            controller.Move(dive * 10*speed * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

   // private void OnControllerColliderHit(ControllerColliderHit hit)
   // {
        //if (hit != null && hit.gameObject.CompareTag("Rail") == true)
       // {
            //Vector3.Cross(hit.normal, -Vector3.right)
           // AddImpact(hit.normal, 50);
            //Debug.Log("Player hit by " + hit.gameObject.name);
       // }
   // }

    //public void AddImpact(Vector3 dir, Single force)
    //{
    //    impact += dir.normalized * force / mass;
    //}
}
