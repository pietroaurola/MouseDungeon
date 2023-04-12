using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public float moveSpeed = 0f;

    public Rigidbody rb;
    public Camera Cam;

    Vector3 movement;
    //Vector3 mousePos;
    Vector3 rotation;
    public float sensY;
    float xRotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(movement.x, movement.z, 0f).normalized;

        //mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);

        
    }

    void Rotation()
    {
        rotation.y = Input.GetAxisRaw("MouseY") * Time.deltaTime * sensY;

        xRotation += rotation.y;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);


        //ROTATION1
        //Vector3 LookDir = mousePos - rb.position;
        //float angle = Mathf.Atan2(LookDir.z, LookDir.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = Angle;

        //ROTATION2
           
    }

}
    
