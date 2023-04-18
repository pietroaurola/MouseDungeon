using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOn : MonoBehaviour
{
    public bool Enemy = false;
    public Transform Target;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Enemy == true)
            {
                Debug.Log("Non ti stacco");
                transform.LookAt(Target);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("Nemico");
            Enemy = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("NonNemico");
        Enemy = false;
    }
}
