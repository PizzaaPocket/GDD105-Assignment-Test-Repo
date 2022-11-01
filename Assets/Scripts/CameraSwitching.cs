using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            camera2.SetActive(true);
            camera1.SetActive(false);
        }
    }
}
