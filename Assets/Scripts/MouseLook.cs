using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    //public float mouseSensitivity = 100f;

    public Transform playerBody;

    public float speed = 5.0f;
    //float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.RotateAround(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.RotateAround(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.RotateAround(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.RotateAround(new Vector3(0, speed * Time.deltaTime, 0));
        }*/
    }
}
