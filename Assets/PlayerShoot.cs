using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public int rotationOffset;

    public Joystick joystickRotation;

    // Update is called once per frame
    void Update()
    {
        //Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
        //difference.Normalize ();

        //float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);

        Vector3 moveVector = (Vector3.up * joystickRotation.Horizontal + Vector3.left * joystickRotation.Vertical);
        if (joystickRotation.Horizontal != 0 || joystickRotation.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }
    }
}
