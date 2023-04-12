using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float Damping;

    private Vector3 velocity = Vector3.zero;


    private void FixedUpdate()
    {
        Vector3 MovePosition = Target.position + Offset;
        transform.position = Vector3.SmoothDamp(transform.position, MovePosition, ref velocity, Damping);
    }
}
