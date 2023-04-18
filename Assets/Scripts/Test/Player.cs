using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController Chc;
    public float MoveSpeed;
  
    //public float TurnSmoothTime = 0f;
    //float TurnSmoothVelocity;

    //test
    //Vector2 movement;
    //Vector3 mousePos;
    //public Camera cam;
    //public Rigidbody Rb;

 

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    


    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            //Movment
            Chc.Move(direction * MoveSpeed * Time.deltaTime);

            //Rotation 1
            //float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref TurnSmoothVelocity, TurnSmoothTime);
            //transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }

        //tesdt
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        //Vector2 lookDir = mousePos - Rb.position;
        //float angle = Mathf.Atan2();
    }
}
