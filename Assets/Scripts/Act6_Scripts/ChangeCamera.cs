using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera rearCamera;
    public Camera driverCamera;
    private bool toggle = false;

    void Start()
    {
        rearCamera.enabled = true;
        driverCamera.enabled = false;

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && !toggle)
        {
            rearCamera.enabled = true;
            driverCamera.enabled = false;
            toggle = true;
        }

        else if (Input.GetKey(KeyCode.Space) && toggle)
        {
            rearCamera.enabled = false;
            driverCamera.enabled = true;
            toggle = false;
        }
    }
}
